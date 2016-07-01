using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Hijo : Padres
    {
        public Padres Papa {get;set;}
        public Padres Mama { get; set;}
    }
}
