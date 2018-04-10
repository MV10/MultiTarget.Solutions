// .NET Framework 4.5.1 implementation
using System;
namespace Library
{
    public class Hello : IHello
    {
        string ver = AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName;
        public string SayHello() => $"Hello from net451 ({ver})";
    }
}
