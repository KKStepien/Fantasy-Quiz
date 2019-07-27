using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy.Quiz.Biblioteka
{
    public class User
    {
        string login;
        string haslo;
        string premium;

        public string Premium
        {
            get { return this.premium; }
            set { this.premium = value; }
        }
        public string Login
        {
            get { return this.login; }
            set
            {
                if (value.Length < 40 && value.Length >= 4)
                {
                    this.login = value;
                }
            }
        }
        public string Haslo
        {
            get { return this.haslo; }
            set
            {
                if (value.Length >= 4)
                {
                    this.haslo = value;
                }
            }
        }

        public User()
        {
        }
        public User(string Login, string Haslo, string Premium)
        {
            this.Login = Login;
            this.Haslo = Haslo;
            this.Premium = Premium;
        }

        ~User()
        {
            Console.WriteLine("Użytkownik został usunięty.");
        }
        
    }
}

