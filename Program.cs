using System;

namespace vlad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkomen till 21:an!");
            string menyVal = "0";
            while (menyVal != "4")
            {
                // Skriv ut huvudmenyn
                Console.WriteLine("välj ett alternativ");
                Console.WriteLine("1. spela 12:an");
                Console.WriteLine("2. Visa senaste vinaren");
                Console.WriteLine("3. Spelets regler");
                Console.WriteLine("4. Avsluta programet");
                menyVal = Console.ReadLine();

                //Tom rad innan användarens val körs
                Console.WriteLine();

                switch (menyVal)
                {
                    //Spela en omgång av 21:an
                    case "1";
                        break;
                }

            }
        }
    }
}
