using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpLogbook.Model
{
    public class SkydiveJumpAction : JumpAction
    {
        public bool IsCutaway { get; set; }
        public int Altitude { get; set; }

        public Dropzone Dropzone { get; set; }
        public Aircraft Aircraft { get; set; }
        public Gear Gear { get; set; }
    }
}
