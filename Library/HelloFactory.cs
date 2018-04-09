using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public static class HelloFactory
    {
        public static IHello GetThisPartyStarted() => new Hello();
    }
}
