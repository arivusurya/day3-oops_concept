using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    public class MethodTypes{
        public void Add(int x ,int y){
            System.Console.WriteLine(x+y);
        }

        public bool compare(int x ,int y){
            return x.Equals(y);
        }

        public int Multiply(int x ,int y){
            return x*y;
        }
    }
}
