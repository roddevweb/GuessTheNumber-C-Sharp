using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int secretNumber = random.Next(1, 101);

            while (true)
            {

            Console.WriteLine("Devinez le nombre mystère entre 1 e 100 :");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess == secretNumber)
            {
                Console.WriteLine("Bravo! Vous avez deviné le nombre mystère.");
                break; //Sortir de la boucle si le nombre est trouvé
            }
            
            else if (guess < secretNumber)
            {
                Console.WriteLine("Le nombre mystère est plus grand.");
            }
            
            else
            {
                Console.WriteLine("Le nombre mystère est plus petit.");   

                Console.ReadLine();             
            }
        }
        }
    }
}

        


    
    
