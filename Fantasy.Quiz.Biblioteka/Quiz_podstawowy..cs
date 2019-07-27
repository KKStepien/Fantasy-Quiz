using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy.Quiz.Biblioteka
{
    public abstract class Quiz_podstawowy
    {
        string nazwa;
        protected int suma_punktow;

        public string Nazwa { get { return nazwa; }}
        
        public Quiz_podstawowy(string nazwa)
        {
            this.nazwa = nazwa;
        }
        
        public virtual int Wyswietl() {
           return suma_punktow;
        }
    }
}
