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
            int idNumber = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            double unitUsed = double.Parse(Console.ReadLine());

            double pricePerUnit = 0;
            double bill = 0;


            if (unitUsed <= 199)
            {
                pricePerUnit = 1.2;
            }
            else if (unitUsed <= 399)
            {
                pricePerUnit = 1.5;
            }
            else if (pricePerUnit <= 599)
            {
                pricePerUnit = 1.8;
            }
            else
            {
                pricePerUnit = 2.00;
            }


        }
    }
}
