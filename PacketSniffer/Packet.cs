using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
namespace PacketSniffer
{
    [Serializable]
    public class Packet
    {
        /// <summary>
        /// 用于解析数据包的结构及数据
        /// </summary>
        enum ProtocolType
        {
            IGGP = 3,
            ICMP = 1,
            IDP = 22,
            IGMP = 2,
            IP = 4,
            ND = 77,
            PUP = 12,
            TCP = 6,
            UDP = 17,
            OTHERS = -1
        }

        private List<byte> byte_Data = new List<byte>();  //数据

        private List<byte> byte_options;  //可选数据

        private byte[] raw_Packet;

        private DateTime dateTime;

        private ProtocolType protocolType;

        private IPAddress src_IPAddress;

        private IPAddress des_IPAddress;

        private int src_Port;

        private int des_Port;

        private int totalLength;

        private int headLength;

        private byte tos;  //服务协议

        private int verpro;  //版本协议

        private string title;  //标识

        private string flag; //标志

        private int fragoffset;  //片偏移

        private int ttl;   //生存时间TTL

        private string headchecksum;  //校验和
        public Packet(byte[] raw)
        {
            if (raw == null)
            {
                throw new ArgumentNullException();  //抛出空指针异常
            }

            if (raw.Length < 20)
            {
                throw new ArgumentException();   //raw无效异常
            }

            raw_Packet = raw;
            dateTime = DateTime.Now;

            verpro = (raw[0] & 0xF0) / 16;

            headLength = (raw[0] & 0x0F) * 4;

            tos = raw[1];

            totalLength = raw[2] * 256 + raw[3];   //总长度占两个字节，从下标2开始

            title = Convert.ToString(raw[4], 2).PadLeft(8, '0') + Convert.ToString(raw[5], 2).PadLeft(8, '0');

            flag = Convert.ToString((raw[6] & 0xE0) / 32, 2).PadLeft(3, '0');

            fragoffset = (raw[6] & 0x1F) * 256 + raw[7];

            ttl = raw[8];

            headchecksum = Convert.ToString(raw[10], 2).PadLeft(8, '0') + Convert.ToString(raw[11], 2).PadLeft(8, '0');

            if (headLength > 20)  //头部长于20，表示有数据包中有可选数据
            {
                byte_options = new List<byte>();
                for (int i = 20; i < headLength; i++)
                {
                    byte_options.Add(raw[i]);
                }
            }

            for (int j = headLength; j < totalLength; j++)
            {
                byte_Data.Add(raw[j]);
            }

            if ((raw[0] & 0x0F) < 5)
            {
                throw new ArgumentException();  //头部错误异常
            }

            if ((raw[2] * 256 + raw[3]) != raw.Length)
            {
                throw new ArgumentException();  //包长度错误
            }

            if (Enum.IsDefined(typeof(ProtocolType), (int)raw[9]))
            {
                protocolType = (ProtocolType)raw[9];
            }
            else
            {
                protocolType = ProtocolType.OTHERS;
            }
            //MessageBox.Show(raw.Length + "");
            src_IPAddress = new IPAddress(BitConverter.ToUInt32(raw, 12));  //从第十二个字节开始读取源IP地址,不能使用“BitConverter.ToInt32”，否则会越界
            //MessageBox.Show("src:" + src_IPAddress);
            des_IPAddress = new IPAddress(BitConverter.ToUInt32(raw, 16));  //读取目的IP地址
            //MessageBox.Show("des:" + des_IPAddress);
            //MessageBox.Show("" + totalLength);
            if (protocolType == ProtocolType.TCP || protocolType == ProtocolType.UDP)
            {
                src_Port = raw[headLength] * 256 + raw[headLength + 1];  //获取源端口
                des_Port = raw[headLength + 2] * 256 + raw[headLength + 3];  //获取目的端口
                //if (protocolType == ProtocolType.TCP)
                //{
                //    headLength += 20;
                //}
                //else if (protocolType == ProtocolType.UDP)
                //{
                //    headLength += 8;
                //}
            }
            else
            {
                src_Port = -1;
                des_Port = -1;
            }
        }

        public string Src_IP
        {
            get
            {
                return src_IPAddress.ToString();
            }
        }

        public int VerPro  //版本协议号
        {
            get
            {
                return verpro;
            }
        }

        public int HeadLength  //头部长度
        {
            get
            {
                return headLength;
            }
        }

        public byte Tos  //服务类型
        {
            get
            {
                return tos;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
        }  //标识

        public string Flag
        {
            get
            {
                return flag;
            }
        }   //标志

        public int FragOffset
        {
            get
            {
                return fragoffset;
            }
        }  //片偏移

        public int Ttl
        {
            get
            {
                return ttl;
            }
        }   //生存时间

        public string ProString
        {
            get
            {
                return protocolType.ToString();
            }
        }  //协议

        public string HeadCheckSum
        {
            get
            {
                return headchecksum;
            }
        }  //头部校验和

        public List<byte> Byte_Options
        {
            get
            {
                return byte_options;
            }
        }  //可选数据

        public List<byte> Byte_Data
        {
            get
            {
                return byte_Data;
            }
        }

        public string Src_PORT
        {
            get
            {
                if (src_Port != -1)
                {
                    return src_Port.ToString();
                }
                else
                {
                    return "";
                }
            }
        }

        public string Des_IP
        {
            get
            {
                return des_IPAddress.ToString();
            }
        }

        public string Des_PORT
        {
            get
            {
                if (des_Port != -1)
                    return des_Port.ToString();
                else
                    return "";
            }
        }

        public string Type
        {
            get
            {
                return protocolType.ToString();
            }
        }

        public int TotalLength
        {
            get
            {
                return totalLength;
            }
        }

        public string Time
        {
            get
            {
                return dateTime.ToLongTimeString();
            }
        }

        public string getHexString()   //16进制显示
        {
            StringBuilder sb = new StringBuilder(raw_Packet.Length);
            for (int i = 0; i < totalLength; i += 30)  //每行30个
            {
                for (int j = i; j < totalLength && j < i + 30; j++)
                {
                    sb.Append(raw_Packet[j].ToString("X2") + " ");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }

        public string getCharString()  //字符显示
        {
            StringBuilder sb = new StringBuilder();
            for (int i = headLength; i < TotalLength; i += 30)
            {
                for (int j = i; j < TotalLength && j < i + 30; j++)
                {
                    if (raw_Packet[j] > 31 && raw_Packet[j] < 128)
                        sb.Append((char)raw_Packet[j]);
                    else
                        sb.Append(".");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
