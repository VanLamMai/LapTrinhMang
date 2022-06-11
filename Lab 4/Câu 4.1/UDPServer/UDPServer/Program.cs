using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpClient = new UdpClient(11000);
            IPEndPoint remote = new IPEndPoint(IPAddress.Any, 0);
            Console.WriteLine("Waiting for a connection...");

            while (true)
            {
                byte[] bytes = udpClient.Receive(ref remote);
                string message = Encoding.UTF8.GetString(bytes);
                if (message.Equals("exit all", StringComparison.InvariantCultureIgnoreCase))
                    break;

                Console.WriteLine("> Client :" + message);

                Console.WriteLine("> Input :");
                message = Console.ReadLine();
                bytes = Encoding.UTF8.GetBytes(message);
                udpClient.Send(bytes, bytes.Length, remote);
            }
            udpClient.Close();
        }
    }
}