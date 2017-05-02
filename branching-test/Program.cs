using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branching_test
{
    class Program
    {
        static void feature1()
        {
            Console.WriteLine("This is the feature1.");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("This is the master branch. Command one.");
            Console.ReadLine();

            feature1();
        }
    }
}
