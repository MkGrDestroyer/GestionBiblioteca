using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eRegistro
    {
        public int idregistro { get; set; }
        public DateTime fecha { get; set; }
        public eUsuario usuario { get; set; }
    }
}
