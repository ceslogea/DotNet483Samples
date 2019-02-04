using System;
using System.Security.Cryptography;
using System.Text;

namespace HashDemo
{
    class Program
    {
        /// <summary>
        /// If you try to hide a front end content, make sure the content is Hashed before the HTTP transamission level.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter de password to be hashed:");
            var pw = Console.ReadLine();
            Console.WriteLine();

            HashDataDemo hd = new HashDataDemo();
            string pwh = hd.CreateHash(pw);

            Console.WriteLine($"The hash value for {pw} is");
            Console.WriteLine($"{pwh}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Compare it to the previous hash");

            Console.WriteLine("Enter the original password: ");
            string pw2 = Console.ReadLine();
            string pwh2 = hd.CreateHash(pw2);

            Console.WriteLine();
            Console.WriteLine($"First hash: {pwh}");
            Console.WriteLine($"Sencond hash: {pwh2}");

            if(pwh == pwh2)
                Console.WriteLine("Match");
            else
                Console.WriteLine("No Match");

        }

        public class HashDataDemo
        {
            public string CreateHash(string input)
            {
                HashAlgorithm sha = SHA256.Create();
                byte[] hashData = sha.ComputeHash(Encoding.Default.GetBytes(input));
                return Convert.ToBase64String(hashData);
            }
        }
    }
}
