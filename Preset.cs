using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCOPresets
{
    public class Preset
    {
        public required string Name { get; set; }
        public required double X { get; set; }
        public required double Y { get; set; }
        public required double Z { get; set; }
    }
}
