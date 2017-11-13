using System.Threading.Tasks;
using Orleans;

using HelloWorldGrainInterfaces;

namespace HelloWorldGrains
{
    /// <summary>
    /// Grain implementation class HelloWorldGrain.
    /// </summary>
    public class HelloWorldGrain : Grain, IHelloWorldGrain
    {
        public Task<string> SayHello()
        {
            return Task.FromResult("Hello World!");
        }
    }
}
