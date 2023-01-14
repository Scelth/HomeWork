using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMag
{
    interface IMagazineable
    {
        public string? Name { get; set; }
        public string? Publishing_house { get; set; }
        public short Year { get; set; }
        public short Pages { get; set; }
    }
}
