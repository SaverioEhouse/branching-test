﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branching_test
{
    class Program
    {
        static void Feature2()
        {
            Console.WriteLine("This is the feature2. This is going live....And here is amended after test.");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("This is the master branch. Command one.");
            Console.ReadLine();

            Console.WriteLine("This is the dev branch. Dev is progressing.");
            Console.ReadLine();

            Console.WriteLine("Bugfix-1");
            Console.ReadLine();

            Console.WriteLine("Dev merged with feature-x coming from elsewhere.");
            Console.ReadLine();
        }
    }
}
