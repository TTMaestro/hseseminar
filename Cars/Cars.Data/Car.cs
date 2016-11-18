using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Data
{
    class Car
    {
        public int Id { get; set; }
        public DateTime Year { get; set; }
        public string Color { get; set; }

        public Model Model { get; set; }
       
    }
}
