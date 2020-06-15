using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SpinningDiscs
{
        public abstract class BaseDisc: IOpticalDisc
    {

        public double Memory { get; set; }
        public double Speed { get; set; }
        public Boolean IsCircular { get; set; }
        public string Color { get; set; }

        public BaseDisc(string color)
        {
            IsCircular = true;
            Color = color;
        }

        public void ReadDisc()
        {
            Console.WriteLine("Beep Beep Boop Boop: Disc has been read!");
        }
        public void SpinDisc()
        {
            Console.WriteLine("Disc has been Spun with a readspeed of " + Speed + "MBPS");
        }
        public double WriteDisc(double num)
        {
            if(num> Memory)
            {
                Console.WriteLine("Error, too big of a file");
                return Memory;
            }

            Console.WriteLine("Consider it written;" + (Memory - num) + " Mbs remaining");
            return Memory - num;
        }


    }
}
