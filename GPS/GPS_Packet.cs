using System;
namespace GPS
{
    public class GPS_Packet
    {
       // create constructure
        public GPS_Packet(byte[] packet)
        {
            /// TODO
            // 1. initialize properties 
            header = packet[0..2];
          
            length = packet[2..4];
        
            unitCode = packet[4..16];
          
            eventCode = packet[16..18];
            eventData = packet[..];
            crcSum = packet[..];
            tail = packet[(packet.Length - 1)..packet.Length];


        }
        /// TODO
        // 2. declare properties and save memory;
        //Packetheader
        public byte[] header = new byte[2];

        //PacketLength no more than 1024bytes
        public byte[] length = new byte[2];

        
        //12 byte ASCII character;
        public byte[]  unitCode;

        //Eventcode
        public byte[] eventCode = new byte[2];

        //Eventdata
        public byte[] eventData;
        //CRCSum

        public byte[] crcSum;

        //PacketTail
        byte[] tail = new byte[2];

        public bool istrue;

       bool check_packet(byte[] packet)
        {
            /// TODO

            // 1.   check header and tail #condition 1 

            // 2.   check packet length and packet[length - 2] == tail #condition 2

            // 3. if #condition 1,2 true then check CRC
            



            return true;
        }



    }
}
