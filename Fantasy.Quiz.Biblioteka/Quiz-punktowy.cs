using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy.Quiz.Biblioteka
{
    public class Quiz_punktowy: Quiz_podstawowy
    {
        List<Pytanie> pytania;
        public Quiz_punktowy(string nazwa):base(nazwa)
        {
            pytania = new List<Pytanie>();
        }
        public void DodajPytanie(string zapytanie, string odpowiedz, string a, string b, string c, string d)
        {
            Pytanie nowy = new Pytanie_abcd(zapytanie, odpowiedz, a, b, c, d);
            pytania.Add(nowy);
        }
        public void DodajPytanie(string zapytanie, string odpowiedz)
        {
            Pytanie nowy = new Pytanie_luka(zapytanie, odpowiedz);
            pytania.Add(nowy);
        }

        public override int Wyswietl()
        {
            for (int i = 0; i < pytania.Count; i++)
            {
                int z = pytania[i].Zapytaj();
                Console.WriteLine();
                if (z == 1)
                {
                    suma_punktow = suma_punktow + pytania[i].Punkty;
                }
            }
            Console.WriteLine("Liczba uzyskanych punktów: " + suma_punktow);
            return suma_punktow;
        }
    }
}

