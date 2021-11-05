using System;

namespace homeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new B(); var c = new C();
            ((A)c).PrintMessage();
            ((A)b).PrintMessage();
            C.PrintMessage();
        }
    }
}
