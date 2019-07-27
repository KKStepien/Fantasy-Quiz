using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fantasy.Quiz.Biblioteka
{
    public class Identyfikacja
    {
        private Baza baza;
        public Identyfikacja(Baza baza)
        {
            this.baza = baza;
        }
        public void Rejestracja()
        {
            Console.Clear();
            Menu rejestracja = new Menu(30, 2, 1);
            rejestracja.DodajElement("      ***FANTASY QUIZ***");
            rejestracja.DodajElement("         Rejestracja");
            rejestracja.DodajElement("");
            rejestracja.Dzialaj();

            string login = "a", haslo = "a", haslo2 = "b", czypremium = "c";
            bool unikatowy = false;
            Console.WriteLine("Login i hasło muszą zawierać minimum po 4 znaki.");

            while (login.Length < 4 || !unikatowy)
            {
                User user = null;
                Console.Write("Podaj login: ");
                login = Console.ReadLine();
                if (login.Length < 4)
                {
                    Console.WriteLine("Podany login jest za krótki!!!");
                }
                else
                {
                    user = baza.ZnajdzPoLoginie(login);
                    if (user != null)
                    {
                        Console.WriteLine("Podany login już istnieje!!!");
                        unikatowy = false;
                    }
                    else
                    {
                        unikatowy = true;
                    }

                }
            }

            while (haslo != haslo2)
            {
                Console.Write("Podaj hasło: ");
                haslo = Console.ReadLine();
                Console.Write("Powtórz hasło: ");
                haslo2 = Console.ReadLine();
                if (haslo != haslo2)
                {
                    Console.WriteLine("Hasła nie są takie same!!!");
                    Console.WriteLine("Wprowadź hasło ponownie!!!");
                }
            }
            while (czypremium != "t" && czypremium != "n")
            {
                Console.WriteLine("Czy kupujesz konto premium (t/n)? ");
                czypremium = Console.ReadLine();
                if (czypremium == "t")
                {
                    User nowy = new User(login, haslo, "tak");
                    baza.DodajUzytkwonika(nowy);
                }
                else if (czypremium == "n")
                {
                    User nowy = new User(login, haslo, "nie");
                    baza.DodajUzytkwonika(nowy);
                }
                else
                {
                    Console.WriteLine("Zła odpowiedz.");
                }
            }
            string plik = @"plik.txt";
            List<string> lines = new List<string>();
            lines.Add(login);
            lines.Add(haslo);
            if (czypremium == "t")
            { lines.Add("tak"); }
            else
            { lines.Add("nie"); }
            File.AppendAllLines(plik, lines);

        }

        public void Logowanie()
        {
            Console.Clear();
            Menu rejestracja = new Menu(30, 2, 1);
            rejestracja.DodajElement("      ***FANTASY QUIZ***");
            rejestracja.DodajElement("           Logowanie");
            rejestracja.DodajElement("");
            rejestracja.Dzialaj();

            string login, haslo;
            User user = null;
            bool czy_haslo = false;
            while (user == null)
            {
                Console.Write("Podaj login: ");
                login = Console.ReadLine();
                user = baza.ZnajdzPoLoginie(login);

                if (user == null)
                {
                    Console.WriteLine("Podany login nie istnieje.");
                }
            }

            while (!czy_haslo)
            {
                Console.Write("Podaj haslo: ");
                haslo = Console.ReadLine();

                if (haslo == user.Haslo)
                {
                    czy_haslo = true;
                    Console.WriteLine("Hało prawidłowe.");
                }
                else
                {
                    Console.WriteLine("Podane hasło jest nieprawidłowe.");
                }
            }

            if(czy_haslo == true)
            {
                Menu_po_zalogowaniu po_zalogowaniu = new Menu_po_zalogowaniu();
                po_zalogowaniu.WyswietlMenu(user, baza);
            }
        }
    }
}

