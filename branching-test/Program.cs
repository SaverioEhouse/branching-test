using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branching_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the master branch. Command one.");
            Console.ReadLine();

            Console.WriteLine("This is the dev branch. Command two.");
            Console.ReadLine();

            Console.WriteLine("This is coming from the Feature-1.");
            Console.ReadLine();

            Console.WriteLine("This is still coming from the Feature-1. Commit 2.");
            Console.ReadLine();

            Console.WriteLine("This change is done in dev branch. No further branch was used.");
            Console.ReadLine();

            Console.WriteLine("This is the second change in dev branch.");
            Console.ReadLine();
        }
    }
}
