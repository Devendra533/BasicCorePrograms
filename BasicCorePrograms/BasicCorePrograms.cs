﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class BasicCorePrograms
    {
        public void PercentageOfCoinFlip()
        {
            int HEADS = 0;
            int TAILS = 0;
            int Count = 0;
            int PercentageOfHeads = 0;
            int PercentageOfTails = 0;
            Random flip = new Random();
            while (Count < 100)
            {


                int flipCheck = flip.Next(0, 2);
                if (flipCheck < 0.5)
                {
                    Console.WriteLine("HEADS");
                    HEADS++;
                    Count++;
                }
                else
                    Console.WriteLine("TAILS");
                TAILS++;
                Count++;
            }
            PercentageOfHeads = HEADS * (Count / 100);
            PercentageOfTails = TAILS * (Count / 100);
            Console.WriteLine("PERCENTAGE OF HEADS " + PercentageOfHeads);
            Console.WriteLine("PERCENTAGE OF TAILS " + PercentageOfTails);

        }

        
        
       
        

        public void LeapYear()
        {
            int year = 0;
            do
            {
                Console.WriteLine("Enter Year in YYYY : ");
                year = Convert.ToInt32(Console.ReadLine());
            }
            while (year % 1000 == 0);
            if (year % 4 == 0)
                Console.WriteLine("YEAR IS A LEAP YEAR ");
            else
                Console.WriteLine("YEAR IS NOT A LEAP YEAR ");

            Console.ReadLine();

        }

        public void PowerOf2(int n)
        {
            int power = 0;
           
            while (n < 0 )
               n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i <= n; i++)
            {
                power = Convert.ToInt32(Math.Pow(2, i));
                Console.WriteLine("2^" + i + " = " + power);
            }

        }

        public void HarmonicNumber() 
        { 
            int n = 0;
            float H = 0;
            do
            {


                Console.WriteLine("Enter any positive number = ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);
            {
                for (int i = 1; i <= n; i++)
                    H += (float)1 / (float)i;
                Console.WriteLine("HARMONIC SERIES IS :-" + H);
            }

        }
        public void Factors()
        {
            int N, i;
            Console.WriteLine("Enter Positive Number Greater Than One :");
            N = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}    
