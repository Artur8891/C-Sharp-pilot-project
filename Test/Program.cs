using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine(@"Hello World Weeeee");

            HttpClient client = new HttpClient();

            client.GetAsync(@"http://www.google.co.uk", HttpCompletionOption.ResponseContentRead);

            ConsoleKeyInfo key = Console.ReadKey();

            Console.Out.WriteLine(string.Format(@"Key is {0}, Value is {1}", key.KeyChar, 100));

            Console.ReadKey();
        }
    }
}
