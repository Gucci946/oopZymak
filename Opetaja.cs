using System;
using System.Collections.Generic;
using System.Text;

namespace oopZymak
{
    // Õpetaja pärib klassist Isik (koolon tähistab pärimist)
    public class Õpetaja : Isik, ITööline, IHindaja
    {
        public string Aine { get; set; }

        public double Tunnitasu { get; set; }

        public int Tunnidkuus { get; set; }

        public Töötüüp VäljamakseTüüp { get; set; } = Töötüüp.Palk;

        public void Õpeta()
        {
            Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
        }

        // override kirjutab abstraktse meetodi üle
        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpetaja {Nimi} ja ma õpetan: {Aine}.");
        }

        public virtual double ArvutaPalk()
        {
            return Tunnitasu * Tunnidkuus;
        }
    }
}

