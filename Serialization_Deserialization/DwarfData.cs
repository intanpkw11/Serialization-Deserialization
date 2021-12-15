using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DawrfD
{
    [Serializable]
    class Dwarf
    {
        public string Color { get; set; }
        public string Name { get; set; }
    }
}
