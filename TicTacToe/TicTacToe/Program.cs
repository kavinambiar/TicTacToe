using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace TicTacToe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        //public static IWebHost BuildWebHost(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>()
        //        .Build();

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .CaptureStartupErrors(true) //Capture errors during server startup. Displays error page.
            .UseStartup<Startup>()
            .PreferHostingUrls(true) //Indicates that the host should listen on specific URLs you have provided
            .UseUrls("http://localhost:5000")
            .UseApplicationInsights()
            .Build();
    }
}
