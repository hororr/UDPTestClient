using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDPClient
{


    //THeader header = new THeader();
    
    public class UDPMessage
    {
        public class THeader
        {
            public UInt16 dataLength { get; set; }
            public UInt16 crc16 { get; set; }
            static public UInt16 sequence { get; set; }
            public Byte msgType { get; set; }
            public Byte reserved { get; set; }
            public UInt16 seq_recieved { get; set; }

        } ;


        Byte[] SOF = new Byte[3] { (Byte)'S', (Byte)'O', (Byte)'F' };
        Byte[] EOF = new Byte[3] { (Byte)'E', (Byte)'O', (Byte)'F' };
        public Byte[] UDPpacket { get; set; }
        public THeader header;
        public Byte[] data24;
        uint leds;
        int ledArrayLength;
        int typeOfPacket;
        public UDPMessage(Byte[] _bArray)
        {
            header = new THeader();
            ParsePacket(_bArray);
        }
        public UDPMessage(uint _leds, int _type)
        {
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

        public void FinalizePacket()
        {
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

        public bool ParsePacket(Byte[] _bArray) {
            bool goodPacket=false;

            if  (   ( (_bArray[0]== SOF[0]) && (_bArray[1]== SOF[1]) && (_bArray[2] == SOF[2])) &&
                    ( (_bArray[_bArray.Length-3]== EOF[0]) &&   (_bArray[_bArray.Length-2]== EOF[1]) &&  (_bArray[_bArray.Length-1]== EOF[2])   ) )
                goodPacket=true;

            if (!goodPacket)
                return false;

            //fill header
            header.dataLength = (UInt16)((_bArray[3] << 8) + _bArray[4]);
            header.crc16 = (UInt16)((_bArray[5] << 8) + _bArray[6]);
            header.seq_recieved = (UInt16)((_bArray[7] << 8) + _bArray[8]);
            header.msgType = (Byte)_bArray[9];
            header.reserved = (Byte)_bArray[10];

            data24 = new Byte[header.dataLength];
            //fill colors array
            Buffer.BlockCopy(_bArray, 11, data24, 0, header.dataLength); //data 900

            return true;
        }
        

    }
}
