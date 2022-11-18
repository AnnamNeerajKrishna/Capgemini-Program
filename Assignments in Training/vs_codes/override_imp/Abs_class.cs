using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Abs_class
    {
        public abstract void A();
    }

    public class Zx_class : Abs_class
    {
        public override void A()
        {
            Console.WriteLine("Some");
        }
    }
    public class CX_class : Abs_class
    {
        public override void A()
        {
            Console.WriteLine("thing");
        }
    }
}
