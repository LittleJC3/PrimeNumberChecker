/*
 * Name: John Ciulla
 * Email: ciullajn@mail.uc.edu
 * Assignment: Assignment 05
 * Course/Semester: IT 3045C Fall 2021
 * Description: Does prime number checking
 * Citations: Bill Nicholson the Wise & https://www.c-sharpcorner.com/blogs/check-a-number-is-prime-number-or-not-in-c-sharp1
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciullajn_Assignment5
{
    class IsPrimeAlgo
    {
        /// <summary>
        /// Checks a number for primeness
        /// </summary>
        /// <param name="num">The number to be checked</param>
        /// <returns>True if num is prime, false otherwise</returns>
        public static Boolean IsPrime(long num)
        {
            int i;
            if (num == 1)
            {
                return true;
            }
            for (i = 2; i <= num - 1; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            if (i == num)
            {
                return true;
            }
            return false;

        }
    }
}
