using System;
using System.Collections.Generic;
using System.Text;

namespace oopZymak
{
    // Õpilane pärib klassist Isik
    public class Õpilane : Isik, ITööline
    {
        public string Kool { get; set; }
        public int Klass { get; set; }
        public double KeskmineHinne { get; set; }
        public int Puudumised { get; set; } = 0;
        public bool kasOnSotsTõend { get; set; } = false;
        public Töötüüp VäljamakseTüüp { get; set; } = Töötüüp.Toetlus;
        public Õppevorm Staatus { get; set; }


        public void Õpi()
        {
            Console.WriteLine($"{Nimi} õpib {Kool} {Klass}. klassis.");

        }

        public override void Kirjelda()
        {
            Console.WriteLine($"{Nimi} õpib {Klass}. klassis. Vorm: {Staatus}");
        }
        public double ArvutaPalk()  
        {
            double põhitoetus = 0;
            double eritoetus = 0;

            if (KeskmineHinne >= 3.8 && Puudumised <= 30)
            {
                põhitoetus += 60;
            }
            if (kasOnSotsTõend)
            {
                eritoetus += 120;
            }
            return põhitoetus + eritoetus;
        }
    }
}
