using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    public  class  Additon {
        public virtual void calcutae(int x1 ,int x2){
            System.Console.WriteLine(x1+x2);
        }

        public virtual void calcutae(int x1 ,int x2,int x3){
            System.Console.WriteLine(x1+x2+x3);
        }
    }
    // method overridding 
    public  class Subraction : Additon {
        public override void calcutae(int x1, int x2)
        {
            System.Console.WriteLine(x1-x2);
        }
        public override void calcutae(int x1, int x2, int x3){
            System.Console.WriteLine(x1-x2-x3);
        }
    }
}
