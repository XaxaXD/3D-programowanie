using System;

namespace Egzamin._2023_06_01
{
    /// <summary>
    /// **********************************************
    /// nazwa klasy: Film
    /// pola:
    ///     tytul – przechowuje tytuł filmu (maks. 20 znaków)
    ///     liczbaWypozyczen – przechowuje liczbę wypożyczeń
    /// metody:
    ///     SetTytul(string nowyTytul) – ustawia tytuł filmu
    ///     GetTytul() – zwraca tytuł filmu
    ///     GetLiczbaWypozyczen() – zwraca liczbę wypożyczeń
    ///     Inkrementuj() – zwiększa liczbę wypożyczeń o 1
    /// informacje:
    ///     Klasa reprezentuje pojedynczy film w wirtualnej wypożyczalni.
    /// autor:
    ///     <tu wpisz swoje imię i nazwisko>
    /// **********************************************
    /// </summary>
    internal class Film
    {
        protected string tytul;
        protected int liczbaWypozyczen;

        public Film()
        {
            tytul = string.Empty;
            liczbaWypozyczen = 0;
        }

        public Film(string tytul, int liczbaWypozyczen)
        {
            SetTytul(tytul);
            this.liczbaWypozyczen = liczbaWypozyczen;
        }

        public void SetTytul(string nowyTytul)
        {
            if (string.IsNullOrWhiteSpace(nowyTytul))
            {
                tytul = "Nieznany";
                return;
            }

            if (nowyTytul.Length > 20)
                tytul = nowyTytul.Substring(0, 20);
            else
                tytul = nowyTytul;
        }

        public string GetTytul()
        {
            return tytul;
        }

        public int GetLiczbaWypozyczen()
        {
            return liczbaWypozyczen;
        }

        public void Inkrementuj()
        {
            liczbaWypozyczen++;
        }
    }

    internal static class Task2
    {

        public static void WykonajZadanieFilmu()
        {
            Console.WriteLine("=== Zadanie 2: Klasa Film ===\n");

            Film film = new Film("Matrix", 5);

            Console.WriteLine($"Tytuł filmu: {film.GetTytul()}");
            Console.WriteLine($"Liczba wypożyczeń: {film.GetLiczbaWypozyczen()}");

            Console.WriteLine("\nZwiększanie liczby wypożyczeń...");
            film.Inkrementuj();

            Console.WriteLine($"Nowa liczba wypożyczeń: {film.GetLiczbaWypozyczen()}");

            Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}

