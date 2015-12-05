using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDPClient
{
    public partial class Form1 : Form
    {
        Char[] SOF = new Char[3] { 'S', 'O', 'F' };
        Char[] EOF = new Char[3] { 'E', 'O', 'F' };
        Byte[] UDPpacket = new Byte[913];

        Byte[] data24 = new Byte[300 * 3];


        public class THeader {
            public UInt16 dataLength { get; set; }
            public UInt16 crc16 { get; set; }
            public Byte msgType { get; set; }
            public Byte reserved { get; set; }
        } ;

        THeader header;

        public void CreateUDPPacket()
        {
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

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void setTimerInterval()
        {
            timer1.Interval = Int32.Parse(textBox_interval.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            setTimerInterval();
            CreateUDPPacket();

            //send

        }
    }
}
