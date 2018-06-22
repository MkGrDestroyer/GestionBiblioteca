using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eDetalleRegistro
    {
        public eRegistro registro { get; set; }
        public eMaterial material { get; set; }
        public DateTime fechadevolucion { get; set; }
    }
}
