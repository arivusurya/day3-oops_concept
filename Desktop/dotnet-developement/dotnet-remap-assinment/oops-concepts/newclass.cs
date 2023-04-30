using System;
namespace oops_concepts
{
    // class that blueprint of an real world entities 
    // it also have the properties{variable for that perticular class} and methods to manipulate data;
    public class Vechile
    {   
        public string Name ;
       public Vechile(string brand){
            Name = brand;
       }

       public void Turnon(){
            Console.WriteLine("Vechile Turned On");
       }
    }
}