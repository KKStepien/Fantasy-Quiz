using System;
using Fantasy.Quiz.Biblioteka;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fantasy.Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menuglowne = new Menu(30, 2, 2);
            menuglowne.DodajElement("      ***FANTASY QUIZ***");
            menuglowne.DodajElement(" ");
            menuglowne.DodajElement("          Logowanie");
            menuglowne.DodajElement("         Rejestracja");
            menuglowne.DodajElement("            Wyjdź");
            menuglowne.DodajElement("");

            Baza baza = new Baza();
            baza.PobierzDane();
           
            Identyfikacja identyfikacja = new Identyfikacja(baza);
            bool koniec = false;
            do
            {
                int zaznaczony = menuglowne.Dzialaj();

                switch (zaznaczony)
                {
                    case 2:
                        identyfikacja.Logowanie();
                        break;
                    case 3:
                        identyfikacja.Rejestracja();
                        break;
                    default:
                        koniec = true;
                        break;
                }
            } while (!koniec);

        }
    }
}
