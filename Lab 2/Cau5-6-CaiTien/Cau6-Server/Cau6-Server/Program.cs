using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace Cau6_Server
{
    class Program
    {
        private const int BUFFER_SIZE = 1024;
        private const int PORT_NUMBER = 5000;

        static ASCIIEncoding encoding = new ASCIIEncoding();

        static void Main(string[] args)
        {
            try
            {
                IPAddress address = IPAddress.Parse("127.0.0.1");

                TcpListener listener = new TcpListener(address, PORT_NUMBER);

                // 1. listen
                listener.Start();

                Console.WriteLine("Thong tin client ket noi " + listener.LocalEndpoint);
                Console.WriteLine("Dang cho ket noi toi client...");

                Socket socket = listener.AcceptSocket();
                Console.WriteLine("Ket qua gui len tu client " + socket.RemoteEndPoint);

                // 2. receive
                byte[] data = new byte[BUFFER_SIZE];
                socket.Receive(data);

                string str = encoding.GetString(data);

                // 3. send
                socket.Send(encoding.GetBytes("Hello " + str));

                // 4. close
                socket.Close();
                listener.Stop();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            Console.Read();
        }
    }
}