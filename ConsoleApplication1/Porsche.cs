using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Porsche : Car
    {
        public override int MPG()
        {
            Console.WriteLine("Who Cares");
            return -1;
        }

        public override void goHome()
        {
            Console.WriteLine("Going home");
        }
    }
}
