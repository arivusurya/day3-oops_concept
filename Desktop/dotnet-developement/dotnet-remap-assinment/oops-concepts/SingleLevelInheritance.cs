using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    public class Person{
        public  virtual void whoyouare(){
            System.Console.WriteLine("I am a person");
        }
    }
    public class Student: Person{

        public int id { get; set; }
        public override void whoyouare(){
            System.Console.WriteLine("I am a student");
        }

        public void ShowId(){
            System.Console.WriteLine("my id is " + id);
        }

        
    }
}
