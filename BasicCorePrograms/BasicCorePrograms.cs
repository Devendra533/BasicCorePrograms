using System;
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
            PercentageOfHeads = HEADS *( Count / 100);
            PercentageOfTails = TAILS * (Count / 100);
            Console.WriteLine("PERCENTAGE OF HEADS " + PercentageOfHeads);
            Console.WriteLine("PERCENTAGE OF TAILS " + PercentageOfTails);

        }

       
    }
}
