using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _078_PipeEnC3
{
    public class Persona:ICloneable
    {
        public string? Nombre { get; set; }

        public object Clone()
        {
            return new Persona()
            {
                Nombre = this.Nombre
            };
        }
    }
}
