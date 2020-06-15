using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticalDisc
    {

        void SpinDisc();

        double WriteDisc(double num);

        void ReadDisc();

    }
}
