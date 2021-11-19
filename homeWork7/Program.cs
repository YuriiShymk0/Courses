using System;

namespace Polymorphism
{
    class Program
    {
        /*
         * Create the following hierarchy of classes A, B and C so that the written code is compiled and displays the text "ABC":
         * static void Main (string [] args)
         * {
         *    var b = new B (); var c = new C ();
         *    ((A) c). PrintMessage ();
         *    (A) b) .PrintMessage ();
         *    c.PrintMessage ();
         *   }
        */
        static void Main(string[] args)
        {
            var b = new B(); var c = new C();
            ((A)c).PrintMessage();
            ((A)b).PrintMessage();
            C.PrintMessage();
        }
    }
}
