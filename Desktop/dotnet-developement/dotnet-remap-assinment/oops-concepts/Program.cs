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
           Employee emp = new Employee();
           emp.name = "Ares";
           emp.salary = 2000000;
           Console.WriteLine("Employee Name: " + emp.name + " Salary: " + emp.salary);
        }
    }
}