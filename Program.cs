using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TimeWaitDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting connections");

            for (int i = 0; i < 10; i++)
            {
                using (var client = new HttpClient())
                {
                    var result = await client.GetAsync("https://www.stevejgordon.co.uk");
                    Console.WriteLine(result.StatusCode);
                }
            }

            Console.WriteLine("Finished connections");
        }
    }
}
