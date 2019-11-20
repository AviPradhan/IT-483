using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            //char s, f;
            bool spicy, fancy;
            Console.Write("Do you like Spicy food? (y | n): ");
            response = Console.ReadLine();
            if (response.ToCharArray()[0] == 'y' || response.ToCharArray()[0] == 'y')
            {
                Console.Write("Do you want to go to a fancy restaurant? (y | n): ");
                response = Console.ReadLine();
                if (response.ToCharArray()[0] == 'y' || response.ToCharArray()[0] == 'Y')
                {
                    Console.WriteLine("Plese visit Indain palace.");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("please visit himalayan resturant.");
                    Console.Read();
                }
            }
            else
            {
                Console.Write("Do you want to go to a fancy restaurant? (y | n): ");
                response = Console.ReadLine();
                String ans = (response.ToCharArray()[0] == 'y' || response.ToCharArray()[0] == 'Y') ? "Plese visit Indain palace" : "please visit himalayan resturant";
                Console.WriteLine(ans);
                Console.Read();
            }
        }
    }
}
