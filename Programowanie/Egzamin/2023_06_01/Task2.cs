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
        // Pola chronione – umożliwiają dostęp klasom potomnym.
        protected string tytul;
        protected int liczbaWypozyczen;

        /// <summary>
        /// Konstruktor bezparametrowy – inicjalizuje pola wartościami domyślnymi.
        /// </summary>
        public Film()
        {
            tytul = string.Empty;
            liczbaWypozyczen = 0;
        }

        /// <summary>
        /// Konstruktor parametrowy – ustawia wartości pól na podstawie argumentów.
        /// </summary>
        public Film(string tytul, int liczbaWypozyczen)
        {
            SetTytul(tytul);
            this.liczbaWypozyczen = liczbaWypozyczen;
        }

        /// <summary>
        /// Metoda ustawiająca tytuł filmu (setter).
        /// </summary>
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

        /// <summary>
        /// Metoda pobierająca tytuł filmu (getter).
        /// </summary>
        public string GetTytul()
        {
            return tytul;
        }

        /// <summary>
        /// Metoda pobierająca liczbę wypożyczeń filmu (getter).
        /// </summary>
        public int GetLiczbaWypozyczen()
        {
            return liczbaWypozyczen;
        }

        /// <summary>
        /// Metoda inkrementująca liczbę wypożyczeń o 1.
        /// </summary>
        public void Inkrementuj()
        {
            liczbaWypozyczen++;
        }
    }

    /// <summary>
    /// Klasa testująca działanie klasy Film.
    /// </summary>
    internal static class Task2
    {
        /// <summary>
        /// Metoda wykonująca zadanie egzaminacyjne nr 2.
        /// </summary>
        public static void WykonajZadanieFilmu()
        {
            Console.WriteLine("=== Zadanie 2: Klasa Film ===\n");

            // Utworzenie obiektu klasy Film
            Film film = new Film("Matrix", 5);

            Console.WriteLine($"Tytuł filmu: {film.GetTytul()}");
            Console.WriteLine($"Liczba wypożyczeń: {film.GetLiczbaWypozyczen()}");

            // Test inkrementacji liczby wypożyczeń
            Console.WriteLine("\nZwiększanie liczby wypożyczeń...");
            film.Inkrementuj();

            Console.WriteLine($"Nowa liczba wypożyczeń: {film.GetLiczbaWypozyczen()}");

            Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}

