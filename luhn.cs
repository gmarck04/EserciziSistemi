using System;
using System.Linq;

namespace luhn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci codice PAN\n");
            string PAN = Console.ReadLine();

            if(AlgoritmoDiLuhn(PAN) == true)
            {
                Console.WriteLine("Codice valido");
            }
            else
            {
                Console.WriteLine("Codice non valido");
            }
            Console.ReadKey();
        }
        static bool AlgoritmoDiLuhn(string PAN) 
        {
            bool posizionePari = false;
            char[] numeri = PAN.ToArray(); 
            int risultato = 0, contatore = numeri.Length -1;           
            while (contatore >= 0)
            {             
                int numeroParziale = int.Parse(numeri[contatore].ToString());
                if (posizionePari)
                {
                    numeroParziale *= 2;
                }
                risultato += numeroParziale;                
                contatore--;
                posizionePari = !posizionePari;
            }

            if (risultato % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}