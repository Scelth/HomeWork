using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiki.Model
{
    public class Country
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime Year { get; set; }

        public string TypeOfBoard { get; set; }

        public string Map { get; set; }

        public int Population { get; set; }

        public int Area { get; set; }

        public int GDP { get; set; }
    }
}
