using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Specialized;

namespace Fantasy.Quiz.Biblioteka
{
    public class Baza
    {
        private List<User> uzytkownicy;

        public Baza()
        {
            uzytkownicy = new List<User>();
        }
        public void DodajUzytkwonika(User nowy)
        {
            uzytkownicy.Add(nowy);
        }

        public void PobierzDane()
        {
            string plik = @"plik.txt";
            string[] lines2 = File.ReadAllLines(plik);
            for (int i = 0; i < lines2.Length; i = i + 3)
            {
                User nowy = new User();

                nowy.Login = lines2[i];
                nowy.Haslo = lines2[i + 1];
                nowy.Premium = lines2[i + 2];

                uzytkownicy.Add(nowy);
            }
        }


        public User ZnajdzPoLoginie(string login)
        {
            User user = null;
            for (int i = 0; i < uzytkownicy.Count; i++)
            {
                if (login == uzytkownicy[i].Login)
                {
                    user = uzytkownicy[i];
                }
            }
            return user;
        }
        public void WyswietlRanking()
        {
            Console.Clear();
            Dictionary<String, int> ranking = new Dictionary<string, int>();
            List<WynikQuizu> wyniki = PobierzWynikiQuizu();
            
            for (int i = 0; i < uzytkownicy.Count; i++)
            {
                ranking.Add(uzytkownicy[i].Login, 0);
            }
            
            for (int i = 0; i < wyniki.Count; i++)
            {
                string login = wyniki[i].Login_uzytkownika;
                int suma = ranking[login];
                suma = suma + wyniki[i].Punkty;

                ranking.Remove(login);
                ranking.Add(login, suma);
            }
            
            int licznik = 1;
            foreach (KeyValuePair<string, int> wpis in ranking.OrderByDescending(wpis => wpis.Value))
            {
                Console.WriteLine(licznik + ". " + wpis.Key + ": " + wpis.Value);
                licznik++;
            }
            Console.ReadKey();
        }


        public void ZapiszWynikQuizu(WynikQuizu wynik)
        {
            List<WynikQuizu> wyniki = PobierzWynikiQuizu();
            for (int i = 0; i < wyniki.Count; i++)
            {
                if (wynik.Login_uzytkownika == wyniki[i].Login_uzytkownika &&
                    wynik.Nazwa_quizu == wyniki[i].Nazwa_quizu)
                {
                    wyniki.Remove(wyniki[i]);
                }
            }
            wyniki.Add(wynik);

            ZapiszWynikiQuizu(wyniki);
        }

        private void ZapiszWynikiQuizu(List<WynikQuizu> wyniki)
        {
            string plik = @"wyniki.txt";
            List<string> lines = new List<string>();
            for (int i = 0; i < wyniki.Count; i++)
            {
                lines.Add(wyniki[i].Login_uzytkownika);
                lines.Add(wyniki[i].Nazwa_quizu);
                lines.Add(Convert.ToString(wyniki[i].Punkty));
            }
            File.WriteAllLines(plik, lines);
        }

        public List<WynikQuizu> PobierzWynikiQuizu()
        {
            string plik = @"wyniki.txt";
            List<WynikQuizu> wyniki = new List<WynikQuizu>();

            if (File.Exists(plik))
            {
                string[] lines2 = File.ReadAllLines(plik);
                for (int i = 0; i < lines2.Length; i = i + 3)
                {
                    WynikQuizu wynik = new WynikQuizu();
                    wynik.Login_uzytkownika = lines2[i];
                    wynik.Nazwa_quizu = lines2[i + 1];
                    wynik.Punkty = Convert.ToInt32(lines2[i + 2]);

                    wyniki.Add(wynik);
                }
            }
            return wyniki;
        }
    }
}
