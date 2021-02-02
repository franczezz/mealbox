using mealbox.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mealbox
{
    public  class Program
    {
        
        static void Main(string[] args)
        {

            Mealbox mealbox = new Mealbox();

            WP("Mealbox-Dieta Pudełkowa");
            WP("Co chcesz zrobić? Wpisz a lub b");
            WP("a- zamówić dietę");
            WP("b- wyświetlić dostępne składniki");

            string OdpowiedzUzytkownika = Console.ReadLine();
            if (OdpowiedzUzytkownika == "a")
            {
                WP("Prosze podać wartość kaloryczną diety:");
                WP("a- 1000cal");
                WP("b- 1500cal");
                WP("c- 2000cal");
                WP("d- 2500cal");
                WP("e- 3000cal");
                string OdpowiedzUzytkownikaKalorie = Console.ReadLine();

                WP("Prosze podać czy dieta ma być wegetariańska: tak(T) nie(N)");

                string CzyWegetarianska = Console.ReadLine();

                
            }
            else
            {
                WP("Lista dostępnych składników:");
                
            }
    }

         static void WP(string tekst)
        {
            Console.WriteLine();
            Console.WriteLine(tekst);
        }
    }

   
    
}
