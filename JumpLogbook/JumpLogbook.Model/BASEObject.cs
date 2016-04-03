using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpLogbook.Model
{
    public class BASEObject : NamedItem
    {
        public string Location { get; set; }
        public int Height { get; set; }
        public BASEObjectType Type { get; set; }
    }
}
