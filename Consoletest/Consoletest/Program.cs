using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoletest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tjena viktoria och Cecilia här har jag ändrat koden och skrivit en kommentar %
            Console.WriteLine("Vem är snyggast Pontus eller anton? svara [A] [P]");
            bool answer = true;

            do
            {
                if (Console.ReadLine() == "A")
                {
                    Console.WriteLine("Tror jag inte på att du tycker!");
                    Console.ReadKey();
                    answer = true;
                }
                else
                {
                    Console.WriteLine("HaHa! Jag visste det!");
                Console.WriteLine("Victria- Saknar Pontus... Måste fixa så att han kommer hit snart igen ;)");


                    Console.ReadKey();
                    answer = false;
                }
            } while (true);
        }
    }
}
