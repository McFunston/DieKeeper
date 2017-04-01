using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DieKeeper.Models.DieAttributes
{
    /// <summary>
    /// Physical attributes of a given die (gussets, glue flaps, scores, etc)
    /// </summary>
    public class Attribute : IAttribute
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
    }
}
