using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezbaW3Nested
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * this is a simple excercise where we calculate and print electricity bill of a customer
            */

            //input ID, name and units consumed
            int idNumber = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            double unitUsed = double.Parse(Console.ReadLine());

            //declare variables
            double pricePerUnit = 0;
            double bill = 0;
            double surcharge = 0;
            double billFinal = 0;

            if (unitUsed < 200)
            {
                pricePerUnit = 1.2;
                
            }
            else if (unitUsed < 400)
            {
                pricePerUnit = 1.5;
            }
            else if (unitUsed < 600)
            {
                pricePerUnit = 1.8;
            }
            else 
            {
                pricePerUnit = 2.00;
            }

            bill = pricePerUnit * unitUsed;

            if (bill > 400)
            {
                surcharge = bill * 0.15;
                
                billFinal = bill + surcharge;
            }

            Console.WriteLine($"Customer IDNO {idNumber}");
            Console.WriteLine($"Customer Name {name}");
            Console.WriteLine($"Units consumed {unitUsed}");
            Console.WriteLine($"Amount charges {pricePerUnit:F2} per unit: {bill:F2}");
            Console.WriteLine($"Surcharge amount: {surcharge:F2}");
            Console.WriteLine($"Net amount paid by the custromer: {billFinal:F2}");
            Console.ReadKey();

        }
    }
}
