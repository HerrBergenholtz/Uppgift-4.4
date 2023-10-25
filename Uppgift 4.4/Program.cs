using System;

namespace Uppgift_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fortsätt = true;

            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. Subtrahera ett tal med ett annat tal");
            Console.WriteLine("2. Dividera ett tal med ett annat tal");
            Console.WriteLine("3. Avsluta");
            string input = Console.ReadLine();


            while (fortsätt == true)
            {
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Skriv in två tal");
                        string[] numberSub = Console.ReadLine().Split(" ");
                        int numberSub1 = Convert.ToInt32(numberSub[0]);
                        int numberSub2 = Convert.ToInt32(numberSub[1]);
                        Console.WriteLine($"Resultatet blir {numberSub1 - numberSub2}");
                        fortsätt = false;
                        break;

                    case "2":
                        Console.WriteLine("Skriv in två tal");
                        string[] numberDiv = Console.ReadLine().Split(" ");
                        int numberDiv1 = Convert.ToInt32(numberDiv[0]);
                        int numberDiv2 = Convert.ToInt32(numberDiv[1]);
                        Console.WriteLine($"Resultatet blir {numberDiv1 / numberDiv2}");
                        fortsätt = false;
                        break;

                    case "3":
                        fortsätt = false;
                        break;
                    
                    default:
                        Console.WriteLine($"{input} är inte giltigt.");
                        break;
                }
            } 
        }
    }
}
