using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Bai1
{
    class Program
    {
        static void GetHostInfo(string host)
        {
            try
            {
                IPHostEntry hostInfo = Dns.GetHostEntry(host);

                Console.WriteLine("Ten mien: " + hostInfo.HostName);

                Console.WriteLine("Dia chi IP: ");

                foreach (IPAddress iPAddress in hostInfo.AddressList)
                {
                    Console.WriteLine(iPAddress.ToString());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Khong phan giai duoc ten mien: " + host + "\n");
            }
        }
        static void Main(string[] args)
        {
            foreach(String arg in args)
            {
                Console.WriteLine("Phan giai ten mien:" + arg);
                GetHostInfo(arg);
            }
            Console.ReadKey();
        }
    }
}
