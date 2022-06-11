using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPListener
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = null;
            string data = string.Empty;
            byte[] bytes;

            try
            {
                IPAddress address = IPAddress.Parse("127.0.0.1");

                server = new TcpListener(address, 5000);
                server.Start();

                bytes = new byte[1024];

                Console.WriteLine("Waiting for a connection...");
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Connected successfully");
                Console.WriteLine("Found client at {0}", client.Client.RemoteEndPoint.ToString());

                NetworkStream stream = client.GetStream();

                while (true)
                {
                    data = null;
                    int i;
                    while((i = stream.Read(bytes,0,bytes.Length)) != 0)
                    {
                        data = Encoding.UTF8.GetString(bytes, 0, i);
                        if (data.Equals("exit all", StringComparison.InvariantCultureIgnoreCase))
                            break;
                        Console.WriteLine("> Client: " + data);

                        Console.WriteLine("> Input: ");
                        data = Console.ReadLine();
                        byte[] message = Encoding.UTF8.GetBytes(data);

                        stream.Write(message, 0, message.Length);
                    }
                }
                client.Close();
            }
            catch (SocketException ex)
            {
                Console.WriteLine("SocketException: " + ex);
            }
            finally
            {
                server.Stop();
            }
        }
    }
}
