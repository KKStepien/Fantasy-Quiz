using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy.Quiz.Biblioteka
{
    public class Pytanie_abcd_bezpkt : Pytanie
    {
        public override int Punkty { get { return 1; } }
        int odpowiedz_uzytkownika;

        string a;
        string b;
        string c;
        string d;

        public Pytanie_abcd_bezpkt(string zapytanie, string a, string b, string c, string d)
            : base(zapytanie)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override int Zapytaj()
        {
            Console.WriteLine(zapytanie);
            Console.WriteLine("1. " + a);
            Console.WriteLine("2. " + b);
            Console.WriteLine("3. " + c);
            Console.WriteLine("4. " + d);

            bool odpowiedz = false;
            while (!odpowiedz)
            {
                try
                {
                    odpowiedz_uzytkownika = Convert.ToInt32(Console.ReadLine());//dodaj wyj. jesli liera
                    odpowiedz = true;
                }
                catch (Exception blad)
                {
                    Console.WriteLine("Nie liczba.");
                }
            }

            return odpowiedz_uzytkownika;
        }
    }
}
