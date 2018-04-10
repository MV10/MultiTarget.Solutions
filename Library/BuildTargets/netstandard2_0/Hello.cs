// .NET Standard 2.0 implementation
using System.Reflection;
using System.Runtime.Versioning;
namespace Library
{
    public class Hello : IHello
    {
        string ver = Assembly.GetEntryAssembly()?.GetCustomAttribute<TargetFrameworkAttribute>()?.FrameworkName;
        public string SayHello() => $"Hello from netstandard2_0 ({ver})";
    }
}
