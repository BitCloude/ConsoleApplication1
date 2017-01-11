using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{


    class Animal
    {
        static void Main(string[] args)
        {
            Animal an = new Animal();

            List<int> numList= new List<int> {5,10,15,20,25};

            List<int> oddNums = numList.Where(n => n % 2 == 1).ToList();

            foreach (int num in oddNums)
            {
                Console.WriteLine(num + ",");
            }
    }
    }


}
