using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> persone = new List<Persona>();
            int n;
            Console.WriteLine("quante persone? ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("inserisci nome ed eta della persona {0}", i + 1);
                string nome = Console.ReadLine();
                int eta = int.Parse(Console.ReadLine());
                persone.Add(new Persona(nome, eta)); //aggiungi persone alla lista
            }

            foreach(Persona persona in persone)
            {
                if (persona.Eta > 17)
                    Console.WriteLine(persona);
                Console.ReadLine();
            }
        }
    }
}
