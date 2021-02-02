using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mealbox.Backend
{
    public class Meal
    {
        public Meal()
        {
            Ingridients = new List<Ingridient>();
        }

        public string Type { get; set; }

        public int Calories { get; set; }
        public List<Ingridient> Ingridients { get; set; }
        
        public int MealCalories
        {
            get
            {
                return Ingridients.Sum(x => x.Calories);
            }
        }
    
    }
}
