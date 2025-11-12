using System;

namespace Egzamin._2022_06
{
    internal class Osoba
    {
        private int id;
        private string imie;
        public static int licznik = 0;

        public Osoba()
        {
            this.id = 0;
            this.imie = "";
            licznik++;
        }

        public Osoba(int id, string imie)
        {
            this.id = id;
            this.imie = imie;
            licznik++;
        }

        public Osoba(Osoba other)
        {
            this.id = other.id;
            this.imie = other.imie;
            licznik++;
        }

        public void PrzedstawSie(string argument)
        {
            if (string.IsNullOrEmpty(imie))
            {
                Console.WriteLine("Błąd danych");
            }
            else
            {
                Console.WriteLine($"Cześć {argument}, mam na imię {imie}");
            }
        }
    }

    internal class Task3
    {
        public void Run()
        {
            Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.licznik}");

            Osoba osoba1 = new Osoba();

            Console.Write("Podaj id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj imię: ");
            string imie = Console.ReadLine();

            Osoba osoba2 = new Osoba(id, imie);
            Osoba osoba3 = new Osoba(osoba2);

            Console.WriteLine("\nWyniki metody PrzedstawSie:");
            osoba1.PrzedstawSie("Lari");
            osoba2.PrzedstawSie("Lari");
            osoba3.PrzedstawSie("Lari");

            Console.WriteLine($"\nLiczba zarejestrowanych osób to {Osoba.licznik}");
            Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");

            Console.ReadKey();
        }
    }
}

