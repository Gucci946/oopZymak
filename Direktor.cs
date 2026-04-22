using System;

public class Direktor
{
    public class Direktor : Opetaja
    {
        public double Lisatasu { get; set; }

        public override double ArvutaPalk()
        {
            return base.ArvutaPalk() + Lisatasu;
        }
    }
}
