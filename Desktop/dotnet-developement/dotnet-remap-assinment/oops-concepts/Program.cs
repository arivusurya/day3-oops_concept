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
           Car mycar = new Car();
           mycar.Start();
           Jaguar xe = new Jaguar();
           xe.ShowBrand();
           Bentley gt = new Bentley();
           gt.ShowBrand();
           gt.showEngineType();


        }
    }
}