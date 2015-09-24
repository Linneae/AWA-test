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
            //Tjena viktoria här har jag ändrat koden och skrivit en kommentar %
            Console.WriteLine("Vem är snyggast Pontus eller anton? svara [A] [P]");
            if (Console.ReadLine() == "A")
                {
                Console.WriteLine("Tror jag inte på att du tycker!");
                Console.ReadKey();
                   }
        }
    }
}
