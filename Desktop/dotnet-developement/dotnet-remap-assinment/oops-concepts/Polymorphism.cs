using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    public class Human
    {
        public void PrintName()
        {
            Console.WriteLine("Human");
        }
    }
    public class Ares : Human
    {
        public void PrintName()
        {
            Console.WriteLine("Ares");
        }
    }
}
