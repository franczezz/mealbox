using Newtonsoft.Json;
using mealbox.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mealbox.Backend
{
  public  class Mealbox
    {
        public List<Ingridient> BazaProduktow { get; set; }
        private void UtworzListeProduktow()
        {
            string sciezkaDoPlikuZProduktami = $"{Directory.GetCurrentDirectory()}\\Ingridients.json";

            string tekstPliku = File.ReadAllText(sciezkaDoPlikuZProduktami);

            
            BazaProduktow = JsonConvert.DeserializeObject<List<Ingridient>>(tekstPliku);
        }
        public List<string> Kategorie { get; set; }
        public int IndeksKategorii { get; set; }
        private void PodzielProduktyNaPosilki()
        {
            Kategorie = new List<string>() { "Śniadanie", "Główne", "Deser" };
        }
        public Ingridient Posiłki()
        {
            List<Ingridient> śniadanie = BazaProduktow.Where(x => x.Type == "Śniadanie").ToList();
            List<Ingridient> główne = BazaProduktow.Where(x => x.Type == "Głowne").ToList();
            List<Ingridient> deser = BazaProduktow.Where(x => x.Type == "Deser").ToList();

           
        }
        public List<Diet> Diets { get; set; }
    }
}