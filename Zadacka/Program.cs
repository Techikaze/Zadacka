﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacka
{
    class Program
    {

        //Write a C# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more.

        public static void Main()
        {
            Console.WriteLine("\nInput an integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            Console.WriteLine((nums[0] == x) || (nums[nums.Length - 1] == x));
        }

    }
}
