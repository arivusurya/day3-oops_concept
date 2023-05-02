using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    public class ValueAndRefferne {
        public int Value (int x , int y){
            return x+y;
        }

        public void Ref(ref int  output ,int x ,int y){  
            output = x+y;
        }
    }
}
