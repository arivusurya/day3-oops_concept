using System;
using System.Collections;
using System.Text;
using System.Threading;
using OOPS_Concept;


namespace Program {
    
    class Program
    {
        public static void Main(string[] args)
        {
            int x = 4;
            int y =8;
            int output = 0;
           ValueAndRefferne obj = new ValueAndRefferne();
            System.Console.WriteLine( obj.Value(4,5));
            obj.Ref(ref output , x, y);
           System.Console.WriteLine(output);

        }
    }
}