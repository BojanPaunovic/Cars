using System;

namespace automobil
{
    class Automobil
    {
        public string proizvodjac;
        public string model;
        public int godiste;
        public string boja;
        public string gorivo;
        public int broj_sedista;
        public double cena;
        public bool sluzbeni;

        public void Ispis()
        {
            Console.WriteLine("Proizvodjac auta je: " + proizvodjac);
            Console.WriteLine("Model auta je: " + model);
            Console.WriteLine("Godiste auta je: " + godiste);
            Console.WriteLine("Boja auta je: " + boja);
            Console.WriteLine("Gorivo je: " + gorivo);
            Console.WriteLine("Broj sedista je: " + broj_sedista);
            Console.WriteLine("Cena je: " + cena+ "Eura");
            if (sluzbeni == true)
            {
                Console.WriteLine("Auto je sluzbeni.");
            }
            else if (sluzbeni == false)
            {
                Console.WriteLine("Auto nije sluzbeni.");
            }


        }
        public void Popust(double p)
        {

            cena -= cena * p / 100;

        }
        public void Farbanje(string novaBoja)
        {
            boja = novaBoja;
        }

    }
    class Program
    {
       
       static void Main()
        {
            Automobil auto1 = new Automobil();
            auto1.proizvodjac = "Audi";
            auto1.model = "A6";
            auto1.godiste = 2017;
            auto1.boja = "CRNA";
            auto1.gorivo = "DIZEL";
            auto1.broj_sedista = 5;
            auto1.cena=17885.95;
            auto1.sluzbeni = false;

            Automobil auto2 = new Automobil();
            auto2.proizvodjac = "Mercedes";
            auto2.model = "GLK 3000";
            auto2.godiste = 2010;
            auto2.boja = "SIVA";
            auto2.gorivo = "BENZIN";
            auto2.broj_sedista = 5;
            auto2.cena = 12000;
            auto2.sluzbeni = true;

            Console.WriteLine("Informacije o prvom autu sa popustom od 20% na cenu: \n");
            auto1.Popust(20);
            auto1.Ispis();
            Console.WriteLine("Da li zelite da farbate auto? da/ne");
            string a = Console.ReadLine();
            string b = a.ToUpper();
            if(b=="DA")
            {
                Console.WriteLine("U koju boju biste zeleli da ofarbate auto?");
                string c = Console.ReadLine();
                auto1.Farbanje(c);
                Console.WriteLine("U redu, ucinicemo to za vas uz dodatnih 20E.");
            }
            else if(b=="NE")
            {
                Console.WriteLine("U redu, nastavite na transakciju.");
            }
            
           

            Console.WriteLine("Informacije o drugom autu sa popustom na cenu od 10%:\n");
            auto2.Popust(10);
            auto2.Ispis();
            Console.WriteLine("Da li zelite da farbate auto? da/ne");
            string x = Console.ReadLine();
            string y = x.ToUpper();
            if (y == "DA")
            {
                Console.WriteLine("U koju boju biste zeleli da ofarbate auto?");
                string c = Console.ReadLine();
                auto1.Farbanje(c);
                Console.WriteLine("U redu, ucinicemo to za vas uz dodatnih 20E.");
            }
            else if (y == "NE")
            {
                Console.WriteLine("U redu, nastavite na transakciju.");
            }





        }
       

        


    }
}
