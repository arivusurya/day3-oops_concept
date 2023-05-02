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
         MethodTypes meth = new MethodTypes();
         meth.Add(1,2);
         bool equal = meth.compare(2,4);
         System.Console.WriteLine(equal);
        int value =  meth.Multiply(2,3);
        System.Console.WriteLine("value = " +   value);
        }
    }
}