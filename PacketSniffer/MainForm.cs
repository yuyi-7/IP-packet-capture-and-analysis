using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace PacketSniffer
{
    public partial class MainForm : Form
    {
        private bool issaved = true;
        private delegate void updateInfodelegate();
        private int SIO_RCVALL = -2147483648 | 0x18000000 | 1;
        List<Packet> packets = new List<Packet>();
        Packet temp_packet;
        Socket socket;
        NetworkInterface[] adapters;
        NetworkInterface selectedadapter;  //选择的网卡
        IPAddress iP;
        int totalLength = 0;
        byte[] buffer;
        string selectednetcard = null;
        int selectedindex = 0;
        bool iscallstop = false;

        public MainForm()
        {
            InitializeComponent();
            SetNetcard();
            btn_Stop.Enabled = false;
        }
        /// <summary>
        /// 获取本地网卡并显示到界面供选择
        /// </summary>
        public void SetNetcard()
        {
            adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                comboBox1.Items.Add(adapter.Name);
            }
        }

        /// <summary>
        /// 抓取数据包
        /// </summary>
        public void StartCap()
        {
            //MessageBox.Show(selectedadapter.Name);
            buffer = new byte[1024 * 1024];
            UnicastIPAddressInformationCollection UIPt = selectedadapter.GetIPProperties().UnicastAddresses;
            foreach (UnicastIPAddressInformation item in UIPt)
            {
                //MessageBox.Show(item.Address.ToString());
                if (item.Address.AddressFamily == AddressFamily.InterNetwork)  //只获取IPV4的地址
                {
                    MessageBox.Show("你选择的网卡的IP地址为："+item.Address.ToString());
                    iP = item.Address;
                }
            }
            socket = new Socket(iP.AddressFamily, SocketType.Raw, ProtocolType.IP);
            //socket.IOControl(SIO_RCVALL, BitConverter.GetBytes(1), null);
            socket.Bind(new IPEndPoint(iP, 0));   //绑定本地的IP和端口号
            socket.IOControl(SIO_RCVALL, BitConverter.GetBytes((int)1), null);
            if (!iscallstop)
            {
                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(this.OnReceive), null);
            }
        }
        /// <summary>
        /// 处理接收到的数据
        /// </summary>
        /// <param name="ar"></param>
        private void OnReceive(IAsyncResult ar)
        {
            int len = socket.EndReceive(ar);
            if (socket != null)
            {
                byte[] receiveBuffer = new byte[len];
                Array.Copy(buffer, 0, receiveBuffer, 0, len);
                Packet packet = new Packet(receiveBuffer);
                packets.Add(packet);
                temp_packet = packet;
                updateInfodelegate updateInfodelegate = new updateInfodelegate(UpdateData);
                dataGridView.Invoke(updateInfodelegate);
            }
            if (!iscallstop)
            {
                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(this.OnReceive), null);
            }
        }

        /// <summary>
        /// 显示选中的数据包信息
        /// </summary>
        public void ShowPacketInfo(int index)
        {
            //dataGridView.Rows.Add(temp_packet.Src_IP, temp_packet.Src_PORT, temp_packet.Des_IP, temp_packet.Des_PORT, temp_packet.Type, temp_packet.Time, temp_packet.TotalLength);
            //MessageBox.Show("点了一下" + index);
            Packet p = packets[index];
            txt_Data.Text = p.getHexString();
            txt_Info.Text = p.getCharString();
        }

        /// <summary>
        /// 更新表格中的数据
        /// </summary>
        public void UpdateData()
        {
            totalLength += temp_packet.TotalLength;
            dataGridView.Rows.Add(temp_packet.Src_IP, temp_packet.Src_PORT, temp_packet.Des_IP, temp_packet.Des_PORT, temp_packet.Type, temp_packet.Time, temp_packet.TotalLength);
            lbl_PackCount.Text = "收到的数据包：" + packets.Count;
            lbl_TotalLength.Text = "数据包总长度：" + totalLength + " [bytes]";
        }

        private void btn_Start_Click(object sender, EventArgs e)  //开始捕获
        {
            btn_Start.Enabled = false;
            btn_Stop.Enabled = true;
            comboBox1.Enabled = false;

            iscallstop = false;
            selectednetcard = (string)comboBox1.SelectedItem;
            if (selectednetcard == null)
            {
                MessageBox.Show("未选择网卡，请正确选择网卡设备！");
                return;
            }
            foreach (NetworkInterface adapter in adapters)
            {
                if (selectednetcard == adapter.Name)
                    selectedadapter = adapter;
            }

            if (issaved)
            {
                dataGridView.Rows.Clear();
                packets.Clear();
            }
            StartCap();
        }

        private void btn_Stop_Click(object sender, EventArgs e)  //暂停
        {
            iscallstop = true;
            btn_Start.Enabled = true;
            btn_Stop.Enabled = false;
            comboBox1.Enabled = true;
            issaved = false;

            socket.Shutdown(SocketShutdown.Both);
        }

        private void btn_Clear_Click(object sender, EventArgs e)  //清除显示
        {
            btn_Stop.PerformClick();
            if (!issaved)
            {
                DialogResult result = MessageBox.Show("是否要保存当前数据包？", "通知", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    btn_Save.PerformClick();
                    packets.Clear();
                    dataGridView.Rows.Clear();
                }
                if (result == DialogResult.No)
                {
                    packets.Clear();
                    dataGridView.Rows.Clear();
                }
            }
            else
            {
                dataGridView.Rows.Clear();
            }
            totalLength = 0;
            lbl_PackCount.Text = "收到的数据包：";
            lbl_TotalLength.Text = "数据包总长度：" + totalLength + " [bytes]";
            issaved = true;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                return;
            }
            selectedindex = dataGridView.CurrentRow.Index;  //获取单击的行号从0开始
            ShowPacketInfo(selectedindex);
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            if (selectedindex < packets.Count)
            {
                Packet p = packets[selectedindex];
                new PackInfo(p).ShowDialog();
            }
            else
            {
                MessageBox.Show("未选中数据包!");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)  //保存
        {
            if (packets.Count == 0)
            {
                MessageBox.Show("没有捕获到数据包！！！");
                return;
            }
            btn_Stop.PerformClick();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "|*.pzz";
            string path;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path = sfd.FileName;
                IFormatter aft = new BinaryFormatter();
                Stream stream = new FileStream(path, FileMode.OpenOrCreate);
                aft.Serialize(stream, packets);
                stream.Close();
            }
        }

        private void btn_Open_Click(object sender, EventArgs e)  //打开
        {
            btn_Stop.PerformClick();
            if (!issaved)
            {
                DialogResult result = MessageBox.Show("是否要保存当前数据包？", "通知", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    btn_Save.PerformClick();
                    dataGridView.Rows.Clear();
                }
                if (result == DialogResult.No)
                {
                    packets.Clear();
                    dataGridView.Rows.Clear();
                    lbl_PackCount.Text = "收到的数据包：";
                    lbl_TotalLength.Text = "数据包总长度：" + totalLength + " [bytes]";
                }
            }
            issaved = true;
            totalLength = 0;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "|*.pzz";
            string path;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                IFormatter aft = new BinaryFormatter();
                Stream stream = new FileStream(path, FileMode.Open);
                packets = (List<Packet>)aft.Deserialize(stream);

                stream.Close();
                foreach (Packet item in packets)
                {
                    totalLength += item.TotalLength;
                    dataGridView.Rows.Add(item.Src_IP, item.Src_PORT, item.Des_IP, item.Des_PORT, item.Type, item.Time, item.TotalLength);
                    lbl_PackCount.Text = "收到的数据包：" + packets.Count;
                    lbl_TotalLength.Text = "数据包总长度：" + totalLength + " [bytes]";
                }
            }
        }
    }


}
