using System;
using System.Net;
using System.Net.NetFlow;
using System.Net.Sockets;

namespace NetFlowPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Templates _templates = new Templates();
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 13000);

            sock.Bind(iep);
            EndPoint ep = (EndPoint)iep;
            byte[] data = new byte[2048];

            int cnt = 0;
            while (true)
            {
                int recv = sock.ReceiveFrom(data, ref ep);
                byte[] bytes = new byte[recv];

                for (int i = 0; i < recv; i++)
                    bytes[i] = data[i];

                Packet packet = new Packet(bytes, _templates);
                Console.ForegroundColor = ConsoleColor.Yellow;

                //raw data write to text file
                //string rawData = packet.ToString();
                //Console.WriteLine(rawData);
                //System.IO.File.AppendAllText("C:\\CodeFiles\\NetflowOutput.txt", rawData);

                cnt++;
                Console.WriteLine(string.Format("Writing received packet #{0} to the DB", cnt.ToString()));
                packet.WriteToDB();
            }
        }
    }
}
