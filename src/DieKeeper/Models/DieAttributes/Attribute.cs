using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DieKeeper.Models.DieAttributes
{
    public class Attribute : IAttribute
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
    }
}
