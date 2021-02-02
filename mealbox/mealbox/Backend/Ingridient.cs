using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mealbox.Backend
{
    public class Ingridient
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public decimal Price { get; set; }
        public bool IsWegan { get; set; }
        public string Type { get; set; }
    }
}
