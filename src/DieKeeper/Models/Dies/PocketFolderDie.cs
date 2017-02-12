using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DieKeeper.Models
{
    public class PocketFolderDie : Die
    {
        public PocketFolderDie()
        {
            Type = DieType.PocketFolder;
        }

        public int MyProperty { get; set; }

    }
}
