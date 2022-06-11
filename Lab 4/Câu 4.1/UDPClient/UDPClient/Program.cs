using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpClient = new UdpClient();
            try
            {
                udpClient.Connect("127.0.0.1", 11000);
                string message = string.Empty;
                byte[] bytes;

                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);

                while (true)
                {
                    Console.WriteLine("> Input: ");
                    message = Console.ReadLine();

                    if (message.Equals("exit", StringComparison.InvariantCultureIgnoreCase))
                        break;

                    bytes = Encoding.UTF8.GetBytes(message);

                    udpClient.Send(bytes, bytes.Length);

                    bytes = udpClient.Receive(ref endPoint);
                    message = Encoding.UTF8.GetString(bytes);

                    Console.WriteLine("> Server: " + message);

                }
                udpClient.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ex" + ex);
            }
            Console.ReadKey();
        }
    }
}
