using System;
using System.Threading.Tasks;

namespace Egzamin._2023_01_01
{
    internal class Task1
    {
        /******************************************************
        nazwa funkcji:   
        **********************************************
        ObliczNWD
        opis funkcji:    
        Funkcja oblicza największy wspólny dzielnik (NWD)
        dwóch liczb całkowitych dodatnich przy użyciu
        algorytmu Euklidesa (wersja iteracyjna).

        parametry:       
        a – pierwsza liczba całkowita dodatnia
        b – druga liczba całkowita dodatnia

        zwracany typ i opis: 
        int – największy wspólny dzielnik (NWD) podanych liczb

        autor:                
        123456  // <--- tu wpisz swój numer zdającego
        **********************************************/

        public static int ObliczNWD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static async Task WykonajZadanieEuklidesa()
        {
            try
            {
                Console.WriteLine("Algorytm Euklidesa - obliczanie NWD dwóch liczb");
                Console.WriteLine("=============");

                Console.Write("Podaj pierwszą liczbę całkowitą dodatnią: ");
                string inputA = Console.ReadLine();

                Console.Write("Podaj drugą liczbę całkowitą dodatnią: ");
                string inputB = Console.ReadLine();

                if (!int.TryParse(inputA, out int liczbaA) || !int.TryParse(inputB, out int liczbaB))
                {
                    Console.WriteLine("Błąd: Obie wartości muszą być liczbami całkowitymi");
                    return;
                }

                if (liczbaA <= 0 || liczbaB <= 0)
                {
                    Console.WriteLine("Błąd: Obie liczby muszą być dodatnie!");
                    return;
                }

                int nwd = ObliczNWD(liczbaA, liczbaB);

                Console.WriteLine($"\nNWD({liczbaA}, {liczbaB}) = {nwd}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            }
        }
    }
}

