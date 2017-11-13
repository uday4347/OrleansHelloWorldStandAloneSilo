using System;

using Orleans;
using Orleans.Runtime.Configuration;
using Orleans.Runtime.Host;

using HelloWorldGrainInterfaces;

namespace OrleansHelloWorld
{
    /// <summary>
    /// Orleans test silo host
    /// </summary>
    public class Program
    {

        static void Main(string[] args)
        {
            /*
                Tutorial URL : https://dotnet.github.io/orleans/Tutorials/Running-in-a-Stand-alone-Silo.html
             */
            Console.WriteLine("Waiting for Orleans Silo to start. Press Enter to proceed...");
            Console.ReadLine();

            // Orleans comes with a rich XML and programmatic configuration. Here we're just going to set up with basic programmatic config
            var config = Orleans.Runtime.Configuration.ClientConfiguration.LocalhostSilo(30000);

            GrainClient.Initialize(config);
        }
    }
}
