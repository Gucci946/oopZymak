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
        }
    }
}
    