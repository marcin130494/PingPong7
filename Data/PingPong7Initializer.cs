using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PingPong7.Models;


namespace PingPong7.Data
{
    public class PingPong7Initializer : DropCreateDatabaseAlways<PingPong7Context>
    {


        protected override void Seed(PingPong7Context context)
        {



            var zespol = new List<Zespol>
            {
                new Zespol() { TeamName = "UKS OSiR Brodnica", Klub = "UKS OSiR Brodnica", Ulica = "ul. Królowej Jadwigi 1", Telefon = "+48 567 459 253", Email = "uksosirbrodnica@gmail.com" },
                new Zespol() { TeamName = "Unia Choceń", Klub = "Unia Choceń", Ulica = "ul. Sikorskiego 12", Telefon = "+48 567 342 067", Email = "uniachocen@wp.pl" },
                new Zespol() { TeamName = "KS Gwiazda II Bydgoszcz", Klub = "KS Gwiazda II Bydgoszcz", Ulica = "ul. Bronikowskiego 4", Telefon = "+48 565 391 272", Email = "ksgwiazdabydgoszcz@onet.pl" },
                new Zespol() { TeamName = "Energa Manekin III Toruń", Klub = "Energa Manekin III Toruń", Ulica = "ul. Międzymurze 2", Telefon = "+48 463 576 298", Email = "energamanekintorun@wp.pl" },
                new Zespol() { TeamName = "Piast Kruszwica", Klub = "Piast Kruszwica", Ulica = "ul. Sportowa 1", Telefon = "+48 224 856 367", Email = "piastkruszwica@gmail.com" },
                new Zespol() { TeamName = "LZS Jastrzębie", Klub = "LZS Jastrzębie", Ulica = "Lipno sala Zespół Szkól Karnkowo", Telefon = "+48 765 484 278", Email = "lzsjastrzebie@gmail.com" },
                new Zespol() { TeamName = "KS Gotyk Toruń", Klub = "KS Gotyk Toruń", Ulica = "ul. Trzcinowa 38", Telefon = "+48 567 456 786", Email = "gotyktorun@gmail.com" },
                new Zespol() { TeamName = "Pogoń II Mogilno", Klub = "Pogoń II Mogilno", Ulica = "ul. Piłsudskiego 14", Telefon = "+48 678 432 688", Email = "pogonmogilno@gmail.com" },
                new Zespol() { TeamName = "Olimpia Unia II Grudziądz", Klub = "Olimpia Unia II Grudziądz", Ulica = "ul.Mickiewicza 42", Telefon = "+48 246 567 789", Email = "uniagrudziadz@onet.pl" },
                new Zespol() { TeamName = "Emdek Bydgoszcz", Klub = "Emdek Bydgoszcz", Ulica = "ul. Leszczyńskiego 42", Telefon = "+48 457 456 689", Email = "emdekbydgoszcz@gmail.com" },
                new Zespol() { TeamName = "Emdek II Bydgoszcz", Klub = "Emdek II Bydgoszcz", Ulica = "ul. Leszczyńskiego 4", Telefon = "+48 457 456 689", Email = "emdekbydgoszcz@gmail.com" },
                new Zespol() { TeamName = "Krajna Sępólno Krajeńskie", Klub = "Krajna Sępólno Krajeńskie", Ulica = "ul. Chojnicka 19", Telefon = "+48 579 470 790", Email = "krajnasepolno@gmail.com" }
            };

            zespol.ForEach(s => context.Zespols.Add(s));
            context.SaveChanges();

            var zawod = new List<Zawodnik>
            {           
                new Zawodnik() { Imie="Mateusz", Nazwisko= "Maćkowski", Wygrane=5, Przegrane=2, TeamName="UKS OSiR Brodnica"},
                new Zawodnik() { Imie="Bartek", Nazwisko= "Biegański", Wygrane=3, Przegrane=5, TeamName="UKS OSiR Brodnica"},
                new Zawodnik() { Imie="Marcin", Nazwisko= "Szymański", Wygrane=6, Przegrane=3, TeamName="UKS OSiR Brodnica"},
                new Zawodnik() { Imie="Filip", Nazwisko= "Deja", Wygrane=5, Przegrane=2, TeamName="UKS OSiR Brodnica"},

                new Zawodnik() { Imie="Paweł ", Nazwisko= "Ciołkowski", Wygrane=6, Przegrane=2, TeamName="Olimpia Unia II Grudziądz"},
                new Zawodnik() { Imie="Mariusz ", Nazwisko= "Jędrnal", Wygrane=2, Przegrane=7, TeamName="Olimpia Unia II Grudziądz"},
                new Zawodnik() { Imie="Mateusz ", Nazwisko= "Urbnanowicz", Wygrane=3, Przegrane=4,TeamName="Olimpia Unia II Grudziądz"},
                new Zawodnik() { Imie="Paweł", Nazwisko= "Berent", Wygrane=5, Przegrane=1, TeamName="Olimpia Unia II Grudziądz"},

                new Zawodnik() { Imie="Grzegorz", Nazwisko= "Ziółkowski", Wygrane=5, Przegrane=1, TeamName="LZS Jastrzębie"},
                new Zawodnik() { Imie="Marcin", Nazwisko= "Chojnicki", Wygrane=3, Przegrane=5, TeamName="LZS Jastrzębie"},
                new Zawodnik() { Imie="Adam", Nazwisko= "Kapeliński", Wygrane=1, Przegrane=6, TeamName="LZS Jastrzębie"},
                new Zawodnik() { Imie="Bartosz", Nazwisko= "Słomski", Wygrane=0, Przegrane=8, TeamName="LZS Jastrzębie"},

                new Zawodnik() { Imie="Krzysztof", Nazwisko= "Leszczyński", Wygrane=9, Przegrane=0, TeamName="KS Gwiazda II Bydgoszcz"},
                new Zawodnik() { Imie="Konrad", Nazwisko= "Staszczyk", Wygrane=7, Przegrane=3, TeamName="KS Gwiazda II Bydgoszcz"},
                new Zawodnik() { Imie="Michał", Nazwisko= "Majchrzak", Wygrane=8, Przegrane=1, TeamName="KS Gwiazda II Bydgoszcz"},
                new Zawodnik() { Imie="Zbigniew", Nazwisko= "Leszczyński", Wygrane=5, Przegrane=4, TeamName="KS Gwiazda II Bydgoszcz"},

                new Zawodnik() { Imie="Krzysztof", Nazwisko= "Piotrowski", Wygrane=4, Przegrane=3, TeamName="Energa Manekin III Toruń"},
                new Zawodnik() { Imie="Rafa", Nazwisko= "Utylki", Wygrane=2, Przegrane=5, TeamName="Energa Manekin III Toruń"},
                new Zawodnik() { Imie="Marcin", Nazwisko= "Zgliński", Wygrane=0, Przegrane=8, TeamName="Energa Manekin III Toruń"},
                new Zawodnik() { Imie="Tomasz", Nazwisko= "Kurtyka", Wygrane=3, Przegrane=4, TeamName="Energa Manekin III Toruń"},

                new Zawodnik() { Imie="Mateusz", Nazwisko= "Marcinkowski", Wygrane=2, Przegrane=4,  TeamName="Pogoń II Mogilno"},
                new Zawodnik() { Imie="Bartosz", Nazwisko= "Zyła", Wygrane=3, Przegrane=2, TeamName="Pogoń II Mogilno"},
                new Zawodnik() { Imie="Andrzej", Nazwisko= "Rynecki", Wygrane=6, Przegrane=8, TeamName="Pogoń II Mogilno"},
                new Zawodnik() { Imie="Jan", Nazwisko= "Kilanowski", Wygrane=4, Przegrane=4, TeamName="Pogoń II Mogilno"},

                new Zawodnik() { Imie="Matusz", Nazwisko= "Repke", Wygrane=3, Przegrane=4, TeamName="Emdek Bydgoszcz"},
                new Zawodnik() { Imie="Edward", Nazwisko= "Cieszyński", Wygrane=1, Przegrane=8, TeamName="Emdek Bydgoszcz"},
                new Zawodnik() { Imie="Miłosz", Nazwisko= "Wisniewski", Wygrane=2, Przegrane=5, TeamName="Emdek Bydgoszcz"},
                new Zawodnik() { Imie="Stanisław", Nazwisko= "Kalinowski", Wygrane=5, Przegrane=2, TeamName="Emdek Bydgoszcz"},

                new Zawodnik() { Imie="Karol", Nazwisko= "Kozera", Wygrane=1, Przegrane=6, TeamName="Emdek II Bydgoszcz"},
                new Zawodnik() { Imie="Marika", Nazwisko= "Baczyńska", Wygrane=4, Przegrane=3,TeamName="Emdek II Bydgoszcz"},
                new Zawodnik() { Imie="Marek", Nazwisko= "Zawadziński", Wygrane=3, Przegrane=7, TeamName="Emdek II Bydgoszcz"},
                new Zawodnik() { Imie="Karol", Nazwisko= "Kozera", Wygrane=3, Przegrane=4, TeamName="Emdek II Bydgoszcz"},

                new Zawodnik() { Imie="Stanisław", Nazwisko= "Lemański", Wygrane=4, Przegrane=2, TeamName="Krajna Sępólno Krajeńskie"},
                new Zawodnik() { Imie="Paweł", Nazwisko= "Mojka", Wygrane=6, Przegrane=3, TeamName="Krajna Sępólno Krajeńskie"},
                new Zawodnik() { Imie="Mariusz", Nazwisko= "Lica", Wygrane=8, Przegrane=1, TeamName="Krajna Sępólno Krajeńskie"},
                new Zawodnik() { Imie="Tadeusz", Nazwisko= "Biernacki", Wygrane=7, Przegrane=1, TeamName="Krajna Sępólno Krajeńskie"},

                new Zawodnik() { Imie="Edmund", Nazwisko= "Kałużny", Wygrane=2, Przegrane=6, TeamName="Unia Choceń"},
                new Zawodnik() { Imie="Edward", Nazwisko= "Śmiały", Wygrane=1, Przegrane=3, TeamName="Unia Choceń"},
                new Zawodnik() { Imie="Marek", Nazwisko= "Kubica", Wygrane=0, Przegrane=4, TeamName="Unia Choceń"},
                new Zawodnik() { Imie="Bartłomiej", Nazwisko= "Śniadecki", Wygrane=3, Przegrane=3, TeamName="Unia Choceń"},

                new Zawodnik() { Imie="Paweł", Nazwisko= "Mańkowski", Wygrane=3, Przegrane=2, TeamName="Piast Kruszwica"},
                new Zawodnik() { Imie="Krystian", Nazwisko= "Bończak", Wygrane=5, Przegrane=1, TeamName="Piast Kruszwica"},
                new Zawodnik() { Imie="Krystian", Nazwisko= "Łukaszewski", Wygrane=2, Przegrane=3, TeamName="Piast Kruszwica"},
                new Zawodnik() { Imie="Łukasz", Nazwisko= "Madaj", Wygrane=0, Przegrane=7, TeamName="Piast Kruszwica"}

            };
            zawod.ForEach(p => context.Zawodniks.Add(p));
            context.SaveChanges();



            var term = new List<Terminarz>
            {
                new Terminarz() { TeamName = "Emdek II Bydgoszcz", Wynik="5:8", TeamName1="UKS OSiR Brodnica"},
                new Terminarz() { TeamName = "Emdek Bydgoszcz", Wynik="6:4", TeamName1="Olimpia Unia II Grudziądz"},
                new Terminarz() { TeamName = "Pogoń II Mogilno", Wynik="8:2", TeamName1="KS Gwiazda II Bydgoszcz"},
                new Terminarz() { TeamName = "Krajna Sępólno Krajeńskie", Wynik="8:1", TeamName1="Piast Kruszwica"},
                new Terminarz() { TeamName = "KS Gotyk Toruń", Wynik="8:4", TeamName1="Unia Choceń"},
                new Terminarz() { TeamName = "Energa Manekin III Toruń", Wynik="8:5", TeamName1="LZS Jastrzębie"},

                new Terminarz() { TeamName = "Energa Manekin III Toruń", Wynik="8:6", TeamName1="Emdek II Bydgoszcz"},
                new Terminarz() { TeamName = "KS Gotyk Toruń", Wynik="7:7", TeamName1="LZS Jastrzębie"},
                new Terminarz() { TeamName = "Krajna Sępólno Krajeńskie", Wynik="8:0", TeamName1="Unia Choceń"},
                new Terminarz() { TeamName = "Pogoń II Mogilno", Wynik="8:6", TeamName1="Piast Kruszwica"},
                new Terminarz() { TeamName = "Emdek Bydgoszcz", Wynik="3:8", TeamName1="KS Gwiazda II Bydgoszcz"},
                new Terminarz() { TeamName = "UKS OSiR Brodnica", Wynik="4:8", TeamName1="Olimpia Unia II Grudziądz"},

                new Terminarz() { TeamName = "Emdek II Bydgoszcz", Wynik="3:8", TeamName1="Olimpia Unia II Grudziądz"},
                new Terminarz() { TeamName = "KS Gwiazda II Bydgoszcz", Wynik="8:3", TeamName1="UKS OSiR Brodnica"},
                new Terminarz() { TeamName = "Piast Kruszwica", Wynik="4:8", TeamName1="Emdek Bydgoszcz"},
                new Terminarz() { TeamName = "Unia Choceń", Wynik="4:8", TeamName1="Pogoń II Mogilno"},
                new Terminarz() { TeamName = "LZS Jastrzębie", Wynik="4:8", TeamName1="Krajna Sępólno Krajeńskie"},
                new Terminarz() { TeamName = "Energa Manekin III Toruń", Wynik="8:5", TeamName1="KS Gotyk Toruń"},

                new Terminarz() { TeamName = "KS Gotyk Toruń", Wynik="24.01.2020", TeamName1="Emdek II Bydgoszcz"},
                new Terminarz() { TeamName = "Krajna Sępólno Krajeńskie", Wynik="24.01.2020", TeamName1="Energa Manekin III Toruń"},
                new Terminarz() { TeamName = "Pogoń II Mogilno", Wynik="24.01.2020", TeamName1="LZS Jastrzębie"},
                new Terminarz() { TeamName = "Emdek Bydgoszcz", Wynik="24.01.2020", TeamName1="Unia Choceń"},
                new Terminarz() { TeamName = "UKS OSiR Brodnica", Wynik="24.01.2020", TeamName1="Piast Kruszwica"},
                new Terminarz() { TeamName = "Olimpia Unia II Grudziądz", Wynik="24.01.2020", TeamName1="KS Gwiazda II Bydgoszcz"},

                new Terminarz() { TeamName = "Emdek II Bydgoszcz", Wynik="31.01.2020", TeamName1="KS Gwiazda II Bydgoszcz"},
                new Terminarz() { TeamName = "Piast Kruszwica", Wynik="31.01.2020", TeamName1="Olimpia Unia II Grudziądz"},
                new Terminarz() { TeamName = "Unia Choceń", Wynik="31.01.2020", TeamName1="UKS OSiR Brodnica"},
                new Terminarz() { TeamName = "LZS Jastrzębie", Wynik="31.01.2020", TeamName1="Emdek Bydgoszcz"},
                new Terminarz() { TeamName = "Energa Manekin III Toruń", Wynik="31.01.2020", TeamName1="Pogoń II Mogilno"},
                new Terminarz() { TeamName = "KS Gotyk Toruń", Wynik="31.01.2020", TeamName1="Krajna Sępólno Krajeńskie"},

                new Terminarz() { TeamName = "Emdek II Bydgoszcz", Wynik="08.02.2020", TeamName1="Krajna Sępólno Krajeńskie"},
                new Terminarz() { TeamName = "Pogoń II Mogilno", Wynik="08.02.2020", TeamName1="KS Gotyk Toruń"},
                new Terminarz() { TeamName = "Emdek Bydgoszcz", Wynik="08.02.2020", TeamName1="Energa Manekin III Toruń"},
                new Terminarz() { TeamName = "UKS OSiR Brodnica", Wynik="08.02.2020", TeamName1="LZS Jastrzębie"},
                new Terminarz() { TeamName = "Olimpia Unia II Grudziądz", Wynik="08.02.2020", TeamName1="Unia Choceń"},
                new Terminarz() { TeamName = "KS Gwiazda II Bydgoszcz", Wynik="08.02.2020", TeamName1="Piast Kruszwica"},

                new Terminarz() { TeamName = "Piast Kruszwica", Wynik="15.02.2020", TeamName1="Emdek II Bydgoszcz"},
                new Terminarz() { TeamName = "Unia Choceń", Wynik="15.02.2020", TeamName1="KS Gwiazda II Bydgoszcz"},
                new Terminarz() { TeamName = "Emdek Bydgoszcz", Wynik="15.02.2020", TeamName1="Olimpia Unia II Grudziądz"},
                new Terminarz() { TeamName = "LZS Jastrzębie", Wynik="15.02.2020", TeamName1="UKS OSiR Brodnica"},
                new Terminarz() { TeamName = "KS Gotyk Toruń", Wynik="15.02.2020", TeamName1="Emdek Bydgoszcz"},
                new Terminarz() { TeamName = "Krajna Sępólno Krajeńskie", Wynik="15.02.2020", TeamName1="Pogoń II Mogilno"},

                new Terminarz() { TeamName = "Emdek II Bydgoszcz", Wynik="22.02.2020", TeamName1="Pogoń II Mogilno"},
                new Terminarz() { TeamName = "Emdek Bydgoszcz", Wynik="22.02.2020", TeamName1="Krajna Sępólno Krajeńskie"},
                new Terminarz() { TeamName = "UKS OSiR Brodnica", Wynik="22.02.2020", TeamName1="KS Gotyk Toruń"},
                new Terminarz() { TeamName = "Olimpia Unia II Grudziądz", Wynik="22.02.2020", TeamName1="Energa Manekin III Toruń"},
                new Terminarz() { TeamName = "KS Gwiazda II Bydgoszcz", Wynik="22.02.2020", TeamName1="LZS Jastrzębie"},
                new Terminarz() { TeamName = "Piast Kruszwica", Wynik="22.02.2020", TeamName1="Unia Choceń"},

                new Terminarz() { TeamName = "Unia Choceń", Wynik="29.02.2020", TeamName1="Emdek II Bydgoszcz"},
                new Terminarz() { TeamName = "LZS Jastrzębie", Wynik="29.02.2020", TeamName1="Piast Kruszwica"},
                new Terminarz() { TeamName = "Energa Manekin III Toruń", Wynik="29.02.2020", TeamName1="KS Gwiazda II Bydgoszcz"},
                new Terminarz() { TeamName = "KS Gotyk Toruń", Wynik="29.02.2020", TeamName1="Olimpia Unia II Grudziądz"},
                new Terminarz() { TeamName = "Krajna Sępólno Krajeńskie", Wynik="29.02.2020", TeamName1="UKS OSiR Brodnica"},
                new Terminarz() { TeamName = "Pogoń II Mogilno", Wynik="29.02.2020", TeamName1="Emdek Bydgoszcz"},

                new Terminarz() { TeamName = "Emdek II Bydgoszcz", Wynik="05.03.2020", TeamName1="Emdek Bydgoszcz"},
                new Terminarz() { TeamName = "UKS OSiR Brodnica", Wynik="05.03.2020", TeamName1="Pogoń II Mogilno"},
                new Terminarz() { TeamName = "Olimpia Unia II Grudziądz", Wynik="05.03.2020", TeamName1="Krajna Sępólno Krajeńskie"},
                new Terminarz() { TeamName = "KS Gwiazda II Bydgoszcz", Wynik="05.03.2020", TeamName1="KS Gotyk Toruń"},
                new Terminarz() { TeamName = "Piast Kruszwica", Wynik="05.03.2020", TeamName1="Energa Manekin III Toruń"},
                new Terminarz() { TeamName = "Unia Choceń", Wynik="05.03.2020", TeamName1="LZS Jastrzębie"},

                new Terminarz() { TeamName = "LZS Jastrzębie", Wynik="12.03.2020", TeamName1="Emdek II Bydgoszcz"},
                new Terminarz() { TeamName = "Energa Manekin III Toruń", Wynik="12.03.2020", TeamName1="Unia Choceń"},
                new Terminarz() { TeamName = "Olimpia Unia II Grudziądz", Wynik="12.03.2020", TeamName1="Krajna Sępólno Krajeńskie"},
                new Terminarz() { TeamName = "KS Gotyk Toruń", Wynik="12.03.2020", TeamName1="Piast Kruszwica"},
                new Terminarz() { TeamName = "Pogoń II Mogilno", Wynik="12.03.2020", TeamName1="KS Gwiazda II Bydgoszcz"},
                new Terminarz() { TeamName = "Emdek Bydgoszcz", Wynik="12.03.2020", TeamName1="UKS OSiR Brodnica"},


            };

            term.ForEach(c => context.Terminarzs.Add(c));
            context.SaveChanges();



            var tab = new List<Tabela>
            {
                new Tabela() {Rozegrano = 3, Wygrane = 1, Zremisowane = 1, Przegrane = 1, Punkty=3, TeamName = "Emdek Bydgoszcz"},
                new Tabela() {Rozegrano = 3, Wygrane = 0, Zremisowane = 1, Przegrane = 2, Punkty=1, TeamName = "Emdek II Bydgoszcz"},
                new Tabela() {Rozegrano = 3, Wygrane = 3, Zremisowane = 0, Przegrane = 0, Punkty=6, TeamName = "KS Gwiazda II Bydgoszcz"},
                new Tabela() {Rozegrano = 3, Wygrane = 2, Zremisowane = 0, Przegrane = 1, Punkty=4, TeamName = "LZS Jastrzębie"},
                new Tabela() {Rozegrano = 3, Wygrane = 1, Zremisowane = 0, Przegrane = 2, Punkty=2, TeamName = "Pogoń II Mogilno"},
                new Tabela() {Rozegrano = 3, Wygrane = 0, Zremisowane = 1, Przegrane = 2, Punkty=1, TeamName = "Piast Kruszwica"},
                new Tabela() {Rozegrano = 3, Wygrane = 2, Zremisowane = 0, Przegrane = 1, Punkty=4, TeamName = "UKS OSiR Brodnica"},
                new Tabela() {Rozegrano = 3, Wygrane = 1, Zremisowane = 1, Przegrane = 1, Punkty=3, TeamName = "KS Gotyk Toruń"},
                new Tabela() {Rozegrano = 3, Wygrane = 3, Zremisowane = 0, Przegrane = 0, Punkty=6, TeamName = "Energa Manekin III Toruń"},
                new Tabela() {Rozegrano = 3, Wygrane = 0, Zremisowane = 0, Przegrane = 3, Punkty=0, TeamName = "Unia Choceń"},
                new Tabela() {Rozegrano = 3, Wygrane = 2, Zremisowane = 0, Przegrane = 1, Punkty=4, TeamName = "Olimpia Unia II Grudziądz"},
                new Tabela() {Rozegrano = 3, Wygrane = 3, Zremisowane = 0, Przegrane = 0, Punkty=6, TeamName = "Krajna Sępólno Krajeńskie"},
                };


            tab.ForEach(t => context.Tabelas.Add(t));
            context.SaveChanges();


            var acc = new List<Account>
            {
                new Account() {Name = "admin", Password="1234", Role="Admin"},
                new Account() {Name = "marcin", Password="test", Role="User"},

                };

            acc.ForEach(b => context.Accounts.Add(b));
            context.SaveChanges();




        }

    }

    
}