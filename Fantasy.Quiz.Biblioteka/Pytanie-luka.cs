using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy.Quiz.Biblioteka
{
    class Pytanie_luka : Pytanie
    {
        public override int Punkty { get { return 2; } }
        string odpowiedz_uzytkownika;

        public Pytanie_luka(string zapytanie, string odpowiedz) : base(zapytanie, odpowiedz)
        {
        }
        public override int Zapytaj()
        {
            Console.WriteLine(zapytanie);
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
