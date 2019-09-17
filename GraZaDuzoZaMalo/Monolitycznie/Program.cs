using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
            Console.WriteLine("Wyosowałem liczbę z zakresu od 1 do 100. Odgadnij ją!");

            Stopwatch czas = Stopwatch.StartNew();


            //powtarzaj wielokrotnie az odgadnie 
            bool odgadniete = false;
            int licznik = 0; 
            do
            {
                licznik++;

                //2. człowiek proponuje (odgaduje)
                Console.WriteLine("Podaj swoją propozycję: ");
                string napis = Console.ReadLine();
                if (napis == "koniec")
                {
                    Console.WriteLine("Szkoda, że mnie opuszczasz.");
                    return;
                }

                int propozycja = 0;
                try
                {
                    propozycja = int.Parse(napis);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Nie podano liczby. /n Spróbuj jeszcze raz.");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Przesadziłes!");
                    continue;
                }
               catch (Exception)
                {
                    Console.WriteLine("Niezydentyfikowny wyjątek. Awaria");
                    Environment.Exit(1);
                }
                //3. komputer ocenia poropozycję

                if (propozycja < wylosowana)
                {
                    Console.WriteLine("Za mało");
                }

                else if (propozycja > wylosowana)
                {
                    Console.WriteLine("Za dużo");
                }
                else
                {
                    Console.WriteLine("Trafiłes");
                    //odgadniete = true;
                    break;
                }
            }
            //while (!odgadniete); //while (propozycja != wysolowana)
            while (true);
            //koniec powtarzaj
            czas.Stop();

            //4. wypisz statystyki gry 
            Console.WriteLine($"-Liczba ruchów:  {licznik} ");
            Console.WriteLine($"-czas gry: {czas.Elapsed}");

        }
    }
}
