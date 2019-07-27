using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy.Quiz.Biblioteka
{
    class Menu_po_zalogowaniu
    {
        public Menu_po_zalogowaniu()
        {
        }

        public void WyswietlMenu(User user, Baza baza)
        {
            Console.Clear();
            Menu menu = new Menu(30, 2, 2);
            menu.DodajElement("      ***FANTASY QUIZ***");
            menu.DodajElement(" ");
            menu.DodajElement("            Quiz");
            menu.DodajElement("           Ranking");
            menu.DodajElement("           Wyloguj");
            menu.DodajElement("");
            bool koniec = false;
            Baza_quizow baza_quizow = new Baza_quizow();
            do
            {
                int zaznaczony = menu.Dzialaj();

                switch (zaznaczony)
                {
                    case 2:
                        baza_quizow.Menu(user, baza);
                        break;
                    case 3:
                        baza.WyswietlRanking();
                        break;
                    default:
                        koniec = true;
                        break;
                }
            } while (!koniec);
        }

        
    }
}
