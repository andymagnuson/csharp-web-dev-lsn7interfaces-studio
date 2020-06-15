using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD cD = new CD("blue");
            DVD dVD = new DVD("red");
            Console.WriteLine(cD.Memory);
            Console.WriteLine(cD.WriteDisc(30));
            cD.SpinDisc();
            cD.ReadDisc();
            Console.WriteLine("********************************");
            Console.WriteLine(dVD.Memory);
            Console.WriteLine(dVD.WriteDisc(30));
            dVD.SpinDisc();
            dVD.ReadDisc();

            // TODO: Call each CD and DVD method to verify that they work as expected.
        }
    }
}
