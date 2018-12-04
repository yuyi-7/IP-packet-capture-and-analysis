using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacketSniffer
{
    public partial class PackInfo : Form
    {
        Packet p;
        string byte_options = null;
        string byte_data = null;
        public PackInfo(Packet p)
        {
            InitializeComponent();
            this.p = p;
            this.ShowDetail();
        }
        //DTRC
        private void ShowDetail()
        {
            lbl_Pri.Text = "优先级0->7：" + (p.Tos & 0xE0) / 32;
            lbl_D.Text = "D:" + (p.Tos & 0x10) / 16;
            lbl_T.Text = "T:" + (p.Tos & 0x08) / 8;
            lbl_R.Text = "R:" + (p.Tos & 0x04) / 4;
            lbl_C.Text = "C:" + (p.Tos & 0x02) / 2;
            lbl_Version.Text = "版本号：IPV" + p.VerPro;
            lbl_HeadLength.Text = "头部长度：" + p.HeadLength;
            lbl_TOS.Text = "服务类型：" + Convert.ToString(p.Tos, 2).PadRight(8,'0');
            lbl_TotalLength.Text = "总长度：" + p.TotalLength;
            lbl_Title.Text = "标识：" + p.Title;
            lbl_Flag.Text = "标志：" + p.Flag;
            lbl_FragOffset.Text = "片偏移量：" + p.FragOffset;
            lbl_TTL.Text = "生存时间(TTL)：" + p.Ttl;
            lbl_Protocol.Text = "协议：" + p.ProString;
            lbl_HeadCheckSum.Text = "头部校验和：" + p.HeadCheckSum;
            lbl_Src_IP.Text = "源IP：" + p.Src_IP;
            lbl_Des_IP.Text = "目的IP：" + p.Des_IP;
            if (p.HeadLength != 20)
            {
                foreach (byte item1 in p.Byte_Options)
                {
                    byte_options += item1.ToString("X2") + " ";
                }
            }  //将可选数据转为16进制字符串
            lbl_Options.Text = "选项：" + byte_options;
            foreach (byte item2 in p.Byte_Data)
            {
                byte_data += item2.ToString("X2") + " ";
            }
            txt_Data.Text = byte_data;
        }

        private void lbl_Version_Click(object sender, EventArgs e)
        {

        }
    }
}
