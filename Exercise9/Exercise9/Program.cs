﻿//use for IC08
//Lydia's code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* * * * * * * * * * * *
 * Warren Peterson * * *
 * This is my own work *
 * CST-117 4/30/2021 * *
 * Exercise 9  * * * * *
 * Code Checking * * * *
 * * * * * * * * * * * */

// Corrected by <Warren Peterson>

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                //Due to checking against duplicates in Set, there should never be more than four elements, we want to iterate through this ten times.
 //original     A.addElement(r.Next(4));

                //Updated to 10 to get a max of ten elements.
                A.addElement(r.Next(10));
                B.addElement(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.union(B));

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.ReadKey();  // Added This method keep the console from closing on its own
        }
    }
}