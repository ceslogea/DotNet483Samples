using System;
using System.Threading;
using System.Threading.Tasks;

namespace ForegroundAndBackgroundThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Count);
            t.Start();

            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 12; i++)
                {
                    Thread.Sleep(500);
                    Console.Write("BG ");
                }

            });
        }

        private static void Count()
        {
            for (int i = 0; i < 2; i++)
            {
                Thread.Sleep(500);
                Console.Write("FG ");
            }
        }
    }
}
