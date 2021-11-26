using System;

namespace uppgift2_Avrundaren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej! Var vänlig och skriv in ett tal med minst fem decimaler!"); //Ber användaren skriva in ett tal med minst 5 decimaler.
            double x = Convert.ToDouble(Console.ReadLine()); // Konverterar string till en double.
            Console.WriteLine("Hur många decimaler vill du ha?"); //Ber användaren skriva in hur många decimaler hen vill ha. (notera att den kommer avrundas)
            int y = Convert.ToInt32(Console.ReadLine()); // konverterar string till ett heltal innehåller antal decimaler.
            Console.WriteLine(Math.Round(x,y));//Avrundar och skriver ut talet.
            Console.ReadKey();// så programmet inte stängs ner.
        }
    }
}
