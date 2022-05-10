/*
 * Name: John Ciulla
 * Email: ciullajn@mail.uc.edu
 * Assignment: Assignment 05
 * Course/Semester: IT 3045C Fall 2021
 * Description: Computes the sum of all the ((a+b)+1, (a+b)-1) 
 * values where a, b,(a+b)+1 and (a+b)-1 are each prime
 * Citations: Bill Nicholson the Wise
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciullajn_Assignment5
{
    class Algorithm
    {
        /// <summary>
        /// Computes the sum of all the ((a+b)+1, (a+b)-1) values where a, b,  
        /// (a+b)+1 and (a+b)-1 are each prime
        /// </summary>
        /// <param name="num1">First Number</param>
        /// <param name="num2">Second Number</param>
        /// <returns>the sum of all the ((a+b)+1, (a+b)-1) values where a, b,  
        /// (a+b)+1 and (a+b)-1 are each prime. </returns>
        public static long ComputePrimeNumbers()
        {
            long total = 0;
            for (int i = 1; i <= 1000; i++)
            {
                for (int j = 1; j <= 1000; j++)
                {
                    if (IsPrimeAlgo.IsPrime(i) && IsPrimeAlgo.IsPrime(j))
                    {   // If ((num1 + num2) - 1) and ((num1 + num2)+1)) is Prime, continue
                        if (IsPrimeAlgo.IsPrime((i + j) - 1) && IsPrimeAlgo.IsPrime((i + j) + 1))
                        {

                            total += ((i + j) - 1) + ((i + j) + 1);


                        }

                    }
                }
            }
            return total;
        }
    }
}
    
