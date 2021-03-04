using System;
using System.Net.Http;

namespace SEDC.ConsoleApplication
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Performance check started...");
            Console.WriteLine(new string('-', 30));
            CheckOrderPerformance();
            Console.ReadLine();
        }

        static void CheckOrderPerformance()
        {
            HttpClient client = new HttpClient();
            string apiURL = "https://localhost:44315/api/external/performance/getorder";

            int limit = 100;


            HttpResponseMessage response = client.GetAsync(apiURL).Result;
            string responseBody = response.Content.ReadAsStringAsync().Result;

            if (int.Parse(responseBody) > limit)
                Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"Performance: {responseBody}ms [Limit: {limit}]ms");

            Console.ResetColor();
        }
    }
}
