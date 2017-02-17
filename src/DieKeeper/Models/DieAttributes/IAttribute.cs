using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DieKeeper.Models.DieAttributes
{
    public interface IAttribute
    {
        int ID { get; set; }
        string Name { get; set; }
        int? Height { get; set; }
        int? Width { get; set; }
    }
}
