using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    public abstract class Shape{
        public abstract void showshape();

    }

    public class Rectange : Shape{
        public override void showshape(){
            System.Console.WriteLine("Rectange");
        }
    }
}
