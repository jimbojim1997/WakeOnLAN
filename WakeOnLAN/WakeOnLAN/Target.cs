using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Xml.Serialization;

namespace WakeOnLAN
{
    /// <summary>
    /// This is used to store the target information of a Wake On LAN (WOL) packet.
    /// WOL is used to wake a computer from a low power state over a LAN connection.
    /// </summary>
    public class Target
    {
        [XmlAttribute]
        public string name;
        [XmlAttribute]
        public string MAC;
        [XmlAttribute]
        public string hostname;

        public Target() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">The user-friendly name for the target.</param>
        /// <param name="MAC">The MAC address (6bytes) of the target machine.</param>
        /// <param name="hostname">The IP address/domain to send the WOL packet to.</param>
        public Target(string name, string MAC, string hostname)
        {
            this.name = name;
            this.MAC = MAC;
            this.hostname = hostname;
        }

        public Target(string name, byte[] MAC, string hostname)
        {
            this.name = name;
            SetMACAsByteArray(MAC);
            this.hostname = hostname;
        }

        #region getters and setters
        public byte[] GetMACKAsByteArray()
        {
            byte[] MACArray = new byte[6];
            try
            {
                string[] octets = MAC.Split(':');

                if (octets.Length < 6)
                {
                    return null;
                }

                for (byte i = 0; i < 6; i++)
                {
                    MACArray[i] = byte.Parse(octets[i], System.Globalization.NumberStyles.HexNumber);
                }
            }
            catch
            {
                MACArray = new byte[6];
            }

            return MACArray;
        }

        public void SetMACAsByteArray(byte[] MACArray)
        {
            string MACString = "";
            for (int i = 0; i < MACArray.Length; i++)
            {
                MACString += MACArray[i].ToString("X") + ":";
            }

            MAC = MACString.TrimEnd(new char[] { ':' });
        }

        public string GetMACAsString()
        {
            return MAC;
        }

        public void SetMACAsString(string MAC)
        {
            this.MAC = MAC;
        }
        #endregion

        /// <summary>
        /// Sends Wake On LAN magic packets.
        /// </summary>
        /// <param name="iterations">Number of packets to send to its target.</param>
        public void WakeTarget(int iterations)
        {
            /* The payload consists of an initial 6 bytes of 0xFF(255)
             * followed bye the MAC address repeated 16 times (6 bytes each).
             * This totals 102 bytes.
             */
            byte[] payload = new byte[102];

            //Initial 6 byte data of 255
            for(byte i = 0; i < 6; i++)
            {
                payload[i] = 0xFF;
            }

            //Adds MAC address 16 times.
            byte[] MACArray = GetMACKAsByteArray();
            for(byte i = 6; i < 102; i+= 6)
            {
                for (byte x = 0; x < 6; x++)
                {
                    payload[i + x] = MACArray[x];
                }
            }

            using(UdpClient udp = new UdpClient())
            {
                //Sends 'iterations' number of WOL packets to target
                for (int i = 0; i < iterations; i++)
                {
                    udp.Send(payload, payload.Length, hostname, 7);
                }
            }
        }

        public override string ToString()
        {
            return $"{name} • {GetMACAsString()} • {hostname}";
        }
    }
}
