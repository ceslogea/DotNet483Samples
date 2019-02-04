using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncAwaitDemo demo = new AsyncAwaitDemo();
            demo.DoStuff();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Working on the main thread.........................");
            }
        }

        public class AsyncAwaitDemo
        {
            public async Task DoStuff()
            {
                //await Task.Run(() =>
                //{
                    CountToFifty();
                //});
                Console.WriteLine("Counting to 50 completed...");
            }
            private async Task<string> CountToFifty()
            {
                for (int i = 0; i < 51; i++)
                {
                    Console.WriteLine($"BG Thread: {i}");
                }
                return "BG Thread: {i}";
            }
        }
    }
}
