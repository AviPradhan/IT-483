using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
                double PairSinglePrescriptionCost = 40.00;

                double PairNONPRESCRIPTIONCOST = 25.00;

                double AntiGlareCoating = 12.50;

                double BrownTintCoating = 9.99;

                Console.WriteLine("What kind of glasses would you like:");

                Console.WriteLine("1 -> prescription, 2 -> non-prescription : ");

                int select = Int32.Parse(Console.ReadLine());

                while (select < 1 || select > 2)
                {
                    Console.WriteLine("1 -> prescription, 2 -> non-prescription : ");

                    select = Int32.Parse(Console.ReadLine());
                }
                double total = 0.0;

                if (select == 2)

                     total = PairNONPRESCRIPTIONCOST;

                else
                     total = PairSinglePrescriptionCost;


                Console.WriteLine("What kind of coating would you like: ");

                Console.WriteLine("1 -> anti-glare, 2 -> brown tint : ");

                select = Int32.Parse(Console.ReadLine());

                while (select < 1 || select > 2)
                {
                    Console.WriteLine("1 -> anti-glare, 2 -> brown tint : ");

                    select = Int32.Parse(Console.ReadLine());

                }
                if (select == 2)

                    total = total + BrownTintCoating;
                   
                else

                    total = total + AntiGlareCoating;


            Console.WriteLine(" Your total cost is $" + total);

                Console.ReadLine();
            }
        }
    }


