using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy.Quiz.Biblioteka
{
    public class Baza_quizow
    {
        public Baza_quizow()
        {
        }

        public void Menu(User user, Baza baza)
        {
            Console.Clear();
            Menu menuglowne = new Menu(30, 2, 2);
            menuglowne.DodajElement("      ***FANTASY QUIZ***");
            menuglowne.DodajElement("");
            menuglowne.DodajElement("         Harry Potter");
            menuglowne.DodajElement("           Wiedźmin");
            menuglowne.DodajElement("     Trylogia czarnego maga");
            menuglowne.DodajElement("        Siedem Królestw");
            menuglowne.DodajElement("       Władca Pierścienia");
            menuglowne.DodajElement("");
            menuglowne.DodajElement("TYLKO DLA UŻYTKOWNIKÓW PREMIUM");
            menuglowne.DodajElement("       Tiara Przydziału");
            menuglowne.DodajElement("            Powrót");
            menuglowne.DodajElement("");

            bool koniec = false;
            do
            {
                int zaznaczony = menuglowne.Dzialaj();
                WynikQuizu wynik = new WynikQuizu();
                wynik.Login_uzytkownika = user.Login;
                switch (zaznaczony)
                {
                    case 2:
                        Console.Clear();
                        Quiz_punktowy quiz_1 = new Quiz_punktowy("HP");
                        quiz_1.DodajPytanie("Ile lat trwa nauka w szkole Hogwart?", "7");
                        quiz_1.DodajPytanie("Kim jest Hedwiga", "1", "Sową", "Szczurem", "Skrzatem", "Smokiem");
                        quiz_1.DodajPytanie("Ile sióstr ma Ron Weasley?", "1");
                        quiz_1.DodajPytanie("Jak nazywa się magiczne wiezienie w świecie HP?", "2",
                            "Azarban", "Azkaban", "Azkazan", "Arkazan");
                        quiz_1.DodajPytanie("Kim są rodzice Hermiony Granger?", "4",
                            "Malarzami", "Pracownikami Ministerstwa Magii", "Nauczycielami", "Dentystami");
                        wynik.Nazwa_quizu = quiz_1.Nazwa;
                        wynik.Punkty = wyswietlQuiz(quiz_1);

                        baza.ZapiszWynikQuizu(wynik);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Quiz_punktowy quiz_2 = new Quiz_punktowy("Wiedźmin");
                        quiz_2.DodajPytanie("Kim z zawodu jest przyjaciel Geralta z Rivii, Jaskier?", "2",
                            "Kucharzem", "Trubadurem", "Wiedźminem", "Czarodziejem");
                        quiz_2.DodajPytanie("Kto jest matką Ciri?", "3", "Calanthe", "Triss Merigold",
                            "Pavetta", "Yennefer");
                        quiz_2.DodajPytanie("Jaki jest kolor włosów Geralta?", "biały");
                        quiz_2.DodajPytanie("Gdzie urodziła się Yennefer?", "1", "W Belleteyn", "W Rivii",
                            "W Cintrze", "W Temerii");
                        quiz_2.DodajPytanie("Ile gier powstała na podstawie Sagi o Wiedźminie?", "3");
                        
                        wynik.Nazwa_quizu = quiz_2.Nazwa;
                        wynik.Punkty = wyswietlQuiz(quiz_2);
                        baza.ZapiszWynikQuizu(wynik);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Quiz_punktowy quiz_3 = new Quiz_punktowy("Trylogia czarnego maga");
                        quiz_3.DodajPytanie("Jak nazywa się najlepszy przyjaciel Sonei?", "2", "Akkarin", "Cery",
                            "Rothen", "Dannyl");
                        quiz_3.DodajPytanie("Czy Sonea pochodzi z bogatego rodu?", "nie");
                        quiz_3.DodajPytanie("Jaki kolor szat w Gilidii Magów noszą Alchemicy?", "fioletowe");
                        quiz_3.DodajPytanie("Który ze studentów jest zacietym wrogiem Sonei?", "3", "Cery", "Dorrien",
                         "Regin", "Savara");
                        quiz_3.DodajPytanie("Za co wygnano Sonę z Gildii?", "4", "Za niezdanie egzaminów",
                            "Ze względu na ukrywane przez nią niskie pochodzenie", "Za błąd popełniony podczas zajeć " +
                            "alchemciznych, który kosztował życie jednego ze studentów.",
                            "Za naukę i praktykowanie czarnej magii");
                        wynik.Nazwa_quizu = quiz_3.Nazwa;
                        wynik.Punkty = wyswietlQuiz(quiz_3); ;

                        baza.ZapiszWynikQuizu(wynik);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Quiz_punktowy quiz_4 = new Quiz_punktowy("Siedem Królestw");
                        quiz_4.DodajPytanie("Co Han Alister posiada od dziecka i czego nie może się pozbyć?",
                            "4", "Bliznę na czole w kształcie błyskawicy", "Magiczny pierścień powracający do niego" +
                            " niczym bumerang", "Cząstkę duszy zmarłego przodka", "Grube srebrne bransolety na rękach");
                        quiz_4.DodajPytanie("Czy Han Aliste ma rodzeństwo?", "tak");
                        quiz_4.DodajPytanie("Jakim imieniem księżniczka Raisa ana'Marianna przedstawia się Hanowi?",
                            "1", "Rebeka Morley", "Hanalea Bayar", "Rose von Chima", "Amona Fells");
                        quiz_4.DodajPytanie("Co było powodem ucieszki księżniczki Raisy ana'Marianny?", "3",
                            "Rodzina Bayarów czychająca na jej życie", "Chęć odszukania zaginionego podczas " +
                            "polowania ojca", "Perspektywa małżeństwa z przymusu", "Młodzieńczy bunt");
                        quiz_4.DodajPytanie("Co Han zabiera Micahowi Bayarowi synowi Wielkiego Maga?", "amulet");
                        wynik.Nazwa_quizu = quiz_4.Nazwa;
                        wynik.Punkty = wyswietlQuiz(quiz_4);

                        baza.ZapiszWynikQuizu(wynik);
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Quiz_punktowy quiz_5 = new Quiz_punktowy("Władca pierścienia");
                        quiz_5.DodajPytanie("Kim jest Froda?", "2", "Elfem", "Hobbitem", "Krasnoludem", "Smokiem");
                        quiz_5.DodajPytanie("Ile pierwotnie było Pierścieni Władzy?", "19");
                        quiz_5.DodajPytanie("Kim są Nazgule?", "3", "Potężnymi Elfami", "Krasnoludami",
                            "Ludźmi, którzy otrzymali dziewięć pierścieni i ulegli potędze Jedynego", "Orkami u władzy");
                        quiz_5.DodajPytanie("Kto przed Bibo Bagginsem był właścicielem pierścienia?", "1", "Gollum",
                            "Gandalf", "Sam", "Sauron");
                        quiz_5.DodajPytanie("Czy elfy i krasnoludy darzą się sympatią?", "nie");
                        wynik.Nazwa_quizu = quiz_5.Nazwa;
                        wynik.Punkty = wyswietlQuiz(quiz_5);

                        baza.ZapiszWynikQuizu(wynik);
                        Console.ReadKey();
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        Console.Clear();
                        if (user.Premium == "tak")
                        {
                            Console.Clear();
                            Console.WriteLine("Czy wiesz do jakiego domu przydzieliłaby Cię Tiara Przydziału? Sprawdź!");
                            Console.WriteLine("");
                            Quiz_niepunktowy pierwszy = new Quiz_niepunktowy("Kim jesteś w świecie HP?");
                            pierwszy.DodajPytanie("Co powiesz na nielegalny wypad do Hogsmeade?", "'To będzie przygoda!'",
                                "'Jestem na tak.'", "'Wolę zostać w Hogwarcie i zrobić coś pożytecznego.'", "'Nielegalny?! Co to-to nie.'");
                            pierwszy.DodajPytanie("Które zwierzę z wymienionych lubisz najbardziej?", "Lwa", "Węża",
                                "Orła", "Borsuka");
                            pierwszy.DodajPytanie("Co jest Twoim marzeniem?", "Wejść na Mount Everest", "Być bogaczem",
                                "Dostać nobla", "Przysłużyć się społeczeństwu");
                            pierwszy.DodajPytanie("Jaki kolor jest Twoim ulubionym?", "Czerwony", "Zielony",
                                "Błękitny","Żółty");
                            pierwszy.DodajPytanie("Którą z cech cenisz sobie najbardziej?", "Odwagę", "Ambicję",
                                "Inteligencję", "Wierność");
                            pierwszy.DodajPytanie("Jaki byłby Twój ulubiony przedmiot w Hogwarcie?", "Obrona przed czarną " +
                                "magią", "Eliksiry", "Zaklęcia", "Hisotoria magii");
                            pierwszy.DodajPytanie("Która z postaci jest Ci najbliższa?", "Hermiona Granger",
                                "Draco Malfoy", "Luna Lovegood", "Cedrik Diggory");
                            pierwszy.DodajPytanie("Co lubisz robić w wolnym czasie?", "Wspinać się w górach", 
                                "Imprezować", "Czytać książki", "Pomagać w schronisku dla zwirząt");
                            pierwszy.DodajPytanie("Widzsz kolegę który płacze na środku skzolnego korytarza. Co robisz?",
                                "Każesz mu wziąć się w garść i bierzesz go na piwo", "Śmiejesz się z niego",
                                "Starasz się racjonalnie rozwiązać jego problem", "Pocieszasz go");
                            pierwszy.DodajPytanie("Tak szczerze, gdzie chciałbyś/chciałabyś trafić?", "Do Gryffindoru", 
                                "Do Slytherinu", "Do Ravenclawu", "Do Hufflepuffu");
                            int odp = wyswietlQuiz(pierwszy);
                            Console.WriteLine("GRATULACJE! Tiara Przydziału przedziela Cię do... ");
                            if (odp == 1) { Console.WriteLine("Gryffindoru!!!"); }
                            else if (odp == 2) { Console.WriteLine("Slytherinu!!!"); }
                            else if (odp == 3) { Console.WriteLine("Ravenclawu!!!"); }
                            else if (odp == 3) { Console.WriteLine("Hufflepuffu!!!"); }
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Nie masz konta premium. Brak dostępu.");
                        }
                        Console.ReadKey();
                        break;
                    default:
                        koniec = true;
                        break;
                   
                }
            } while (!koniec);
        }

        private int wyswietlQuiz(Quiz_podstawowy quiz)
        {
            return quiz.Wyswietl();
        }
    }
}
