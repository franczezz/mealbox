using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mealbox.Backend
{
   public class Diet
    {
        public List<Meal> Meals { get; set; }
        public bool IsWegan { get; set; }
      
    }
}
