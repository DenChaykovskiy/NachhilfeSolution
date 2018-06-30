using System;

namespace CSharp
{
    public class Ueberladen
    {
        public Ueberladen()
        {
            Console.WriteLine("Ueberladen EMPTY");           
        }
        
        public Ueberladen(int param)
        {
            Console.WriteLine("Ueberladen INT");
        }

        public Ueberladen(long param)
        {
            // the comment for testing (from VS)
            Console.WriteLine("Ueberladen LONG");
        }

        public Ueberladen(double param)
        {
            Console.WriteLine("Ueberladen DOUBLE");
        }

        public Ueberladen(string param)
        {
            Console.WriteLine("Ueberladen STRING");

        }
    }


    public class UeberladenUseCase
    {
        public UeberladenUseCase()
        {
            new Ueberladen();
            new Ueberladen(-12);
            new Ueberladen(254);

            Console.WriteLine();

            new Ueberladen(256);
            new Ueberladen(2 + 1);
            new Ueberladen(3 + 1.0);

            Console.WriteLine();

            new Ueberladen(3 + '1');
            new Ueberladen(3 + 0xAF);
            new Ueberladen(3 + "ss");


            Console.WriteLine();
        }
    }
}
