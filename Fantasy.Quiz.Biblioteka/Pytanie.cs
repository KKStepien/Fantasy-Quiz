using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy.Quiz.Biblioteka
{
    public abstract class Pytanie
    {
        protected string zapytanie;
        protected string odpowiedz;
        public abstract int Punkty { get; }

        public Pytanie(string zapytanie)
        {
            this.zapytanie = zapytanie;
        }
        public Pytanie(string zapytanie, string odpowiedz):this(zapytanie)
        {
            this.odpowiedz = odpowiedz;
        }

        public abstract int Zapytaj();

    }
}
