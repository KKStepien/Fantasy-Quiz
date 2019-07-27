using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy.Quiz.Biblioteka
{
    public class Menu
    {
        private List<string> elementy;

        int zaznaczony;
        int szerokosc;
        int poczatek_linii;
        ConsoleColor KolorMenu, KolorPodswietlenia;

        public int LiczbaElementow
        {
            get
            {
                return elementy.Count;
            }
        }

        public Menu(int szerokosc, int poczatek_linii, int zaznaczony, ConsoleColor KolorMenu = ConsoleColor.DarkCyan,
            ConsoleColor KolorPodswietlenia = ConsoleColor.DarkGray)
        {
            elementy = new List<string>();

            this.poczatek_linii = poczatek_linii;
            this.szerokosc = szerokosc;
            this.zaznaczony = zaznaczony;
            this.KolorMenu = KolorMenu;
            this.KolorPodswietlenia = KolorPodswietlenia;
        }

        public void DodajElement(string element)
        {
            elementy.Add(element);
        }

        private void Rysuj()
        {
            Console.Clear();
            for (int i = 0; i < LiczbaElementow; i++)
            {
                if (zaznaczony == i)
                {
                    Console.BackgroundColor = KolorPodswietlenia;
                }
                else
                {
                    Console.BackgroundColor = KolorMenu;
                }
                Console.WriteLine(elementy[i].PadRight(szerokosc));
            }
        }

        public int Dzialaj()
        {
            while (true)
            {
                Rysuj();
                ConsoleKeyInfo k = Console.ReadKey();

                switch (k.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.ResetColor();
                        if (zaznaczony > poczatek_linii) zaznaczony--;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.ResetColor();
                        if (zaznaczony < LiczbaElementow - poczatek_linii) zaznaczony++;
                        break;
                    case ConsoleKey.Enter:
                        Console.ResetColor();
                        return zaznaczony;
                    default:
                        Console.ResetColor();
                        break;

                }
            }
        }
    }
}
