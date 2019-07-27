using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy.Quiz.Biblioteka
{
    public class Pytanie_abcd : Pytanie
    {

        public override int Punkty { get { return 1; } }
        string odpowiedz_uzytkownika;

        string a;
        string b;
        string c;
        string d;

        public Pytanie_abcd(string zapytanie, string odpowiedz, string a, string b, string c, string d)
            : base(zapytanie, odpowiedz)
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
            odpowiedz_uzytkownika = Console.ReadLine();
            if (odpowiedz_uzytkownika == odpowiedz)
            {
                Console.WriteLine("Odpowiedz poprawna.");
                return 1;
            }
            else
            {
                Console.WriteLine("Odpowiedz błędna.");
                return 0;
            }
        }
    }
}
