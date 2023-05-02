using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    public class Car {
        public void Start(){
            System.Console.WriteLine("Engine started");
        }
    }
    public class Jaguar:Car{
        private  string brand = "Jaguar" ;
        public virtual void ShowBrand(){
            System.Console.WriteLine(brand);
        }
    }
    public class Bentley : Jaguar{
        string brand = "Bentley" ;
        string enginetype = "W12";
        public override void ShowBrand(){
            System.Console.WriteLine(brand);
        }
        public void showEngineType(){
            System.Console.WriteLine("Engine type is " + enginetype);
        }

    }
}
