﻿using System;
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
            UDPMessage msg = new UDPMessage(300, 3);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            setTimerInterval();
            programType = 2;
            timer1.Start();
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            UDPMessage msg = new UDPMessage(0, 51);
            msg.FinalizePacket();

            UdpClient client = new UdpClient();
            IPEndPoint ip = new IPEndPoint(IPAddress.Broadcast, 8081);
            client.Send(msg.UDPpacket, msg.UDPpacket.Length, ip);
            client.Close();

        }

        private void button_auto_Click(object sender, EventArgs e)
        {
            UDPMessage msg = new UDPMessage(0, 50);
            msg.FinalizePacket();

            UdpClient client = new UdpClient();
            IPEndPoint ip = new IPEndPoint(IPAddress.Broadcast, 8081);
            client.Send(msg.UDPpacket, msg.UDPpacket.Length, ip);
            client.Close();
        }

        private void button_manual_Click(object sender, EventArgs e)
        {
            UDPMessage msg = new UDPMessage(0, 52);
            msg.FinalizePacket();

            UdpClient client = new UdpClient();
            IPEndPoint ip = new IPEndPoint(IPAddress.Broadcast, 8081);
            client.Send(msg.UDPpacket, msg.UDPpacket.Length, ip);
            client.Close();
        }

        private void button_setfps_Click(object sender, EventArgs e)
        {
            byte fps = (byte)Int32.Parse(textBox_fps.Text);

            UDPMessage msg = new UDPMessage(1, 60);
            msg.data24[0] = fps;
            msg.FinalizePacket();

            UdpClient client = new UdpClient();
            IPEndPoint ip = new IPEndPoint(IPAddress.Broadcast, 8081);
            client.Send(msg.UDPpacket, msg.UDPpacket.Length, ip);
            client.Close(); 
        }

        private void button_prg_Click(object sender, EventArgs e)
        {
            byte prg = (byte)Int32.Parse(textBox_prg.Text);
            UDPMessage msg = new UDPMessage(1, 20);
            msg.data24[0] = prg;
            msg.FinalizePacket();

            UdpClient client = new UdpClient();
            IPEndPoint ip = new IPEndPoint(IPAddress.Broadcast, 8081);
            client.Send(msg.UDPpacket, msg.UDPpacket.Length, ip);
            client.Close(); 

        }
    }
}
