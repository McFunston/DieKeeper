using DieKeeper.Models.DieAttributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace DieKeeper.Models
{
    public enum DieType
    {
        PocketFolder,
        Score,
        Perf,
        Box,
        Sleeve,
        Emboss,
        Deboss,
        Other
    }

    public abstract class Die
    {
        public int ID { get; set; }
        public int SheetWidth { get; set; }
        public int SheetHeight { get; set; }
        public string Description { get; set; }
        public DieType SimpleType { get; set; }
        public Image FullDieImage { get; set; }
        public Image AnnotatedDieImage { get; set; }
        public Image SampleImage { get; set; }
        public virtual List<IAttribute> Attributes { get; set; }
    }
}
