using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Car
    {
        public abstract int MPG();


        public abstract void goHome();

        static void Main(string[] args)
        {
           

            List<int> numList= new List<int> {5,10,15,20,25};

            List<int> evenNums = numList.Where(n => n % 2 == 0).ToList();

            foreach (int num in evenNums)
            {
                Console.WriteLine(num + ",");
            }
    }
    }


}
