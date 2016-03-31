using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpLogbook.Model
{
    public class JumpAction
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public JumpActionType Type { get; set; }

        public BASEObject BASEObject { get; set; }
    }
}
