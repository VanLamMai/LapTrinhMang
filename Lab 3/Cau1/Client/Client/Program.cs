using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint serverEndpoint = new IPEndPoint(IPAddress.Loopback, 5000);
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            string str = "Hello Server";
            byte[] data = Encoding.ASCII.GetBytes(str);

            Console.WriteLine("Dang gui cau chao len Server...");
            serverSocket.SendTo(data, data.Length, SocketFlags.None, serverEndpoint);
            Console.WriteLine("Da gui cau chao len Server");

            Console.ReadLine();
        }
    }
}
