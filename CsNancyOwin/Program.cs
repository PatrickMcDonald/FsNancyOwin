namespace CsNancyOwin
{
    using System;
    using System.Diagnostics;
    using Microsoft.Owin.Hosting;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var url = "http://localhost:12345/";

            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("Listening on {0}", url);

                Process.Start(url);

                Console.Write("Press any key to exit . . . ");
                Console.ReadKey(true);
            }
        }
    }
}