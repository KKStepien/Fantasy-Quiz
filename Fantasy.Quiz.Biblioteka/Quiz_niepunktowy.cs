using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy.Quiz.Biblioteka
{
    class Quiz_niepunktowy : Quiz_podstawowy
    {
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;

        List<Pytanie_abcd_bezpkt> pytania;
        public Quiz_niepunktowy(string nazwa) : base(nazwa)
        {
            pytania = new List<Pytanie_abcd_bezpkt>();
        }
        
        public void DodajPytanie(string zapytanie,string a, string b, string c, string d)
        {
            Pytanie_abcd_bezpkt nowy = new Pytanie_abcd_bezpkt(zapytanie, a, b, c, d);
            pytania.Add(nowy);
        }
        public override int Wyswietl()
        {
            for (int i = 0; i < pytania.Count; i++)
            {
                int z = pytania[i].Zapytaj();
                Console.WriteLine();
                if (z == 1) a++;
                else if (z == 2) b++;
                else if (z == 3) c++;
                else if (z == 4) d++;

            }
            if (a >= b && a >= c && a >= d) { return 1; }
            else if (b > a && b >= c && b >= d) { return 2; }
            else if (c > a && c > b && c >= d) { return 3; }
            else if (d > a && d > b && d > c) { return 4; }
            else return 0;
        }
    }
}
