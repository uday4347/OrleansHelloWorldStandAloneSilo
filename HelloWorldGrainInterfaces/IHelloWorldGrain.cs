using System.Threading.Tasks;
using Orleans;

namespace HelloWorldGrainInterfaces
{
    /// <summary>
    /// Grain interface IHelloWorldGrain
    /// </summary>
    public interface IHelloWorldGrain : IGrainWithGuidKey
    {
        Task<string> SayHello();
    }
}
