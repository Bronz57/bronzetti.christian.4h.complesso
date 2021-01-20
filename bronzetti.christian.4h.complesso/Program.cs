using System;

namespace bronzetti.christian._4h.complesso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma che calcola le 4 operazioni (+ - * /) tra due numeri complessi \nScritto da C. Bronzetti, 4H");
            
            Complesso z1 = new Complesso(3, 5);
            Complesso z2 = new Complesso(2, 4);
            Complesso zR = new Complesso();


            string scelta="+";
            Console.WriteLine("Inserire l'operazione che vuoi fare");
            scelta = Console.ReadLine();

            if (scelta == "+")
                zR.somma(z1, z2);

            if (scelta == "-")
                zR.diff(z1, z2);

            if (scelta == "*")
                zR.per(z1, z2);

            if (scelta == "/")
                zR.div(z1, z2);

            if(zR.immaginaria>=0)
                Console.WriteLine($"Il risultato e' {zR.reale} + {zR.immaginaria}i");
            else
                Console.WriteLine($"Il risultato e' {zR.reale}{zR.immaginaria}i");
        }
    }

    class Complesso
    {
        public double reale;
        public double immaginaria;

        public Complesso()
        {
            reale = 0;
            immaginaria = 0;
        }

        public Complesso (double a, double b)
        {
            reale = a;
            immaginaria = b;
        }

        public void somma(Complesso w1, Complesso w2)
        {
            reale = w1.reale + w2.reale;
            immaginaria = w1.immaginaria + w2.immaginaria;

        }
        public void diff(Complesso w1, Complesso w2)
        {
            reale = w1.reale - w2.reale;
            immaginaria = w1.immaginaria - w2.immaginaria;
        }

        public void per(Complesso w1, Complesso w2)
        {
            reale = w1.reale * w2.reale - (w1.immaginaria * w2.immaginaria);
            immaginaria = w1.reale * w2.immaginaria + w1.immaginaria * w2.reale;
        }

        public void div(Complesso w1, Complesso w2)
        {
            reale = (w1.reale * w2.reale + w1.immaginaria * w2.immaginaria) / (Math.Pow(w2.reale, 2) + Math.Pow(w2.immaginaria, 2));
            immaginaria = (w1.immaginaria * w2.reale - w1.reale * w2.immaginaria)/(Math.Pow(w2.reale,2) + Math.Pow(w2.immaginaria, 2));
        }
    }
}
