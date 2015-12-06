using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDPClient
{
    public partial class Form1 : Form
    {
        int programType;
        
        //Byte[] SOF = new Byte[3] { (Byte)'S', (Byte)'O', (Byte)'F' };
        //Byte[] EOF = new Byte[3] { (Byte)'E', (Byte)'O', (Byte)'F' };
        //Byte[] UDPpacket = new Byte[913];

        //Byte[] data24 = new Byte[300 * 3];


        public class THeader {
            public UInt16 dataLength { get; set; }
            public UInt16 crc16 { get; set; }
            static public UInt16 sequence { get; set; }
            public Byte msgType { get; set; }
            public Byte reserved { get; set; }
        } ;

        //THeader header = new THeader();

        public class UDPMessage {
            Byte[] SOF = new Byte[3] { (Byte)'S', (Byte)'O', (Byte)'F' };
            Byte[] EOF = new Byte[3] { (Byte)'E', (Byte)'O', (Byte)'F' };
            public Byte[] UDPpacket { get; set; }
            THeader header;
            public Byte[] data24;
            uint leds;
            int ledArrayLength;
            int typeOfPacket;
            public UDPMessage(uint _leds, int _type) {
                THeader.sequence++;
                leds = _leds;
                typeOfPacket = _type;
                if (typeOfPacket == 3) 
                    ledArrayLength = (int)(leds * 3);
                else
                    ledArrayLength = (int)(leds * 3);
                header = new THeader();
                data24 = new Byte[ledArrayLength];
                UDPpacket = new Byte[ledArrayLength + 8 + 3 + 3];
            }
            
            public void FinalizePacket() {
                // calc datalength
                header.dataLength = (UInt16)(ledArrayLength);
                // calc crc

                // type
                header.msgType = (Byte)typeOfPacket; // rgb24


                Buffer.BlockCopy(SOF, 0, UDPpacket, 0, 3); //SOF 3b

                //MSB?
                UDPpacket[3] = (Byte)((header.dataLength >> 8) & 0xFF);
                UDPpacket[4] = (Byte)(header.dataLength & 0xFF);
                UDPpacket[5] = (Byte)((header.crc16 >> 8) & 0xFF);
                UDPpacket[6] = (Byte)(header.crc16 & 0xFF);
                UDPpacket[7] = (Byte)((THeader.sequence >> 8) & 0xFF);
                UDPpacket[8] = (Byte)(THeader.sequence & 0xFF);
                UDPpacket[9] = header.msgType;
                UDPpacket[10] = header.reserved;

                Buffer.BlockCopy(data24, 0, UDPpacket, 3 + 8, ledArrayLength); //data 900

                Buffer.BlockCopy(EOF, 0, UDPpacket, 3 + 8 + ledArrayLength, 3); //EOF 3b

                THeader.sequence++;
            }

        }

        public void CreateUDPPacket()
        {
            /*
            Buffer.BlockCopy(SOF, 0, UDPpacket, 0, 3); //SOF 3b

            //MSB?
            UDPpacket[3] =  (Byte) ((header.dataLength >> 8) & 0xFF);
            UDPpacket[4] =  (Byte) (header.dataLength & 0xFF);
            UDPpacket[5] =  (Byte) ((header.crc16 >> 8) & 0xFF);
            UDPpacket[6] = (Byte)(header.crc16 & 0xFF);
            UDPpacket[7] = header.msgType;
            UDPpacket[8] = header.reserved;

            Buffer.BlockCopy(data24, 0, UDPpacket, 9, 1); //data 900

            Buffer.BlockCopy(EOF, 0, UDPpacket, 8+1, 3); //EOF 3b
            */
        }

        public Form1()
        {
            InitializeComponent();
        }

        private int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter >= 900)
                counter = 0;

            //CreateUDPPacket();
            UDPMessage msg = new UDPMessage(300,3);
            if (programType == 1)
            {
                msg.data24[counter++] = 255;
            }
            else if (programType == 2) {
                msg.data24[counter++] = 255;
                msg.data24[counter++] = 255;
                msg.data24[counter++] = 255;
            }
            msg.FinalizePacket();
            
            //send
            
            UdpClient client = new UdpClient();
            IPEndPoint ip = new IPEndPoint(IPAddress.Broadcast, 8081);
            client.Send(msg.UDPpacket, msg.UDPpacket.Length, ip);
            client.Close();
             
            /*
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
           ProtocolType.Udp);

            IPAddress broadcast = IPAddress.Parse("192.168.0.25");

            byte[] sendbuf = Encoding.ASCII.GetBytes("fuck");
            IPEndPoint ep = new IPEndPoint(broadcast, 8081);

            s.SendTo(sendbuf, ep);*/
        }

        private void setTimerInterval()
        {
            timer1.Interval = Int32.Parse(textBox_interval.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            setTimerInterval();
            programType = 1;
            timer1.Start();
                        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            counter = 0;
        }

        Socket sock;
        IPEndPoint endPoint;
        private void Form1_Load(object sender, EventArgs e)
        {
            //sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //IPAddress serverAddr = IPAddress.Parse("255.255.255.255");
            //endPoint = new IPEndPoint(IPAddress.Broadcast, 11000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setTimerInterval();
            programType = 2;
            timer1.Start();
        }
    }
}
