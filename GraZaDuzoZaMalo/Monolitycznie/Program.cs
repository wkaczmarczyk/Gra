using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monolitycznie
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. komputer losuje liczbę z podanego zakresu
            Random los = new Random();
            int wylosowana = los.Next(1, 101);
#if DEBUG
            Console.WriteLine(wylosowana); //do usuniecia w Relase
#endif

            //powtarzaj wielokrotnie az odgadnie 
            //2. człowiek proponuje (odgaduje)
            
            //3. komputer ocenia poropozycję
            //koniec powtarzaj
            
            //4. wypisz statystyki gry 
        }
    }
}
