namespace oopZymak

{
    internal class StartPage
    {
        static void Main(string[] args)
        {
            //Isik
            //Isik inimene1 = new Isik();
            //inimene1.Nimi = "Mati";
            //inimene1.Sünniaasta = 2009;
            //inimene1.Tervita(); // Väljund: Tere! Mina olen Mati...

            //Õpetaja
            Õpetaja õpetaja1 = new Õpetaja();
            õpetaja1.Nimi = "Eve";
            õpetaja1.Sünniaasta = 1980;
            õpetaja1.Aine = "Matemaatika";
            õpetaja1.Tervita();
            õpetaja1.Õpeta();

            //Õpilane
            Console.WriteLine("\n--- Õpilase andmed ---");
            Õpilane õpilane1 = new Õpilane();
            õpilane1.Nimi = "Markus";
            õpilane1.Sünniaasta = 2008;
            õpilane1.Kool = "Kutsehariduskeskus";
            õpilane1.Klass = 10;
            õpilane1.Tervita();
            õpilane1.Õpi();
            Console.ReadLine();

            List<ITööline> palgasaajad = new List<ITööline>();

            Õpilane mati = new Õpilane();
            mati.Nimi = "Mati";
            mati.KeskmineHinne = 4.0;

            Õpilane kadi = new Õpilane { Nimi = "Kadi", Klass = 11, Kool = "Kutsekeskus", KeskmineHinne = 4.1 };
            Õpilane jüri = new Õpilane { Nimi = "Jüri", Klass = 12, Kool = "Kutsekeskus", KeskmineHinne = 3.6 };

            Õpetaja anna = new Õpetaja { Nimi = "Anna", Aine = "Python", Tunnitasu = 20, Tunnidkuus = 80 };
            Õpetaja peeter = new Õpetaja { Nimi = "Peeter", Aine = "C#", Tunnitasu = 25, Tunnidkuus = 60 };

            palgasaajad.AddRange(new ITööline[] { mati, kadi, jüri, anna, peeter });

            Random rnd = new Random();
            string[] nimed = { "Maria", "Kati", "Juhan", "Anna", "Siim" };
            Õppevorm[] vormid = (Õppevorm[])Enum.GetValues(typeof(Õppevorm));
            for (int i = 0; i < nimed.Length; i++)
            {
                Õppevorm juhuslikVorm = vormid[rnd.Next(vormid.Length)];
                Õpilane õpilane = new Õpilane()
                {
                    Nimi = nimed[rnd.Next(nimed.Length)],
                    Klass = rnd.Next(1, 13),
                    Kool = "TTHK",
                    KeskmineHinne = rnd.NextDouble() * 5,
                    Puudumised = rnd.Next(0, 350),
                    kasOnSotsTõend = rnd.Next(0, 2) == 1,
                    Staatus = vormid[rnd.Next(vormid.Length)]
                };
                palgasaajad.Add(õpilane);
            }

            Console.WriteLine("--- Väljamaksed ---");
            foreach (ITööline isik in palgasaajad)
            {
                string tüüp = isik.ValjamakseTüüp.ToString();
                Console.WriteLine($" {tüüp} summa: {isik.ArvutaPalk()} eurot. {((Isik)isik).Nimi}");
            }
            Console.ReadLine();
            Koolihaldus minuKool = new Koolihaldus();

            Õpetaja op = new Õpetaja { Nimi = "Mati", Aine = "Programmeerimine" };
            Õpilane opilane1 = new Õpilane { Nimi = "Mari", Klass = 10, Staatus = Õppevorm.Päevane };

            minuKool.LisaInimene(op);
            minuKool.LisaInimene(opilane1);
            minuKool.LisaInimene(õpetaja1);
            minuKool.LisaInimene(kadi);
            minuKool.LisaInimene(jüri);
            minuKool.LisaInimene(anna);
            minuKool.LisaInimene(peeter);
            foreach (ITööline isik in palgasaajad)
            {
                minuKool.LisaInimene(((Isik)isik));
            }
            minuKool.KuvaKõik();
        }
        Koolihaldus minuKool = new Koolihaldus();

        Õpetaja op = new Õpetaja { Nimi = "Mati", Aine = "Programmeerimine" };
        Õpilane opilane1 = new Õpilane { Nimi = "Mari", Klass = 10, Staatus = Õppevorm.Päevane };

        minuKool.LisaInimene(op);
        minuKool.LisaInimene(opilane1);

        minuKool.KuvaKõik();
    }
}