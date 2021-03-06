using System;
using System.Collections;
using System.Threading;

namespace TcpEchoServerThread
{
    public class ConsoleLogger : ILogger
    {
        private static Mutex mutex = new Mutex();
        public void Write(ArrayList entry)
        {
            mutex.WaitOne();
            IEnumerator line = entry.GetEnumerator();
            while (line.MoveNext())
                Console.WriteLine(line.Current);
            Console.WriteLine();
            mutex.ReleaseMutex();
        }
        public void Write(string entry)
        {
            mutex.WaitOne();
            Console.WriteLine(entry);
            Console.WriteLine();
            mutex.ReleaseMutex();
        }
    }
}
