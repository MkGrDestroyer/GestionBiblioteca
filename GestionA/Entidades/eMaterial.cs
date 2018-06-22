using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eMaterial
    {
        public int idmaterial { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public string tema { get; set; }
        public int aniopublicacion { get; set; }
        public string editorial_productor { get; set; }
        public string estado { get; set; }
        public int inventario { get; set; }
        public int articulosprestados { get; set; }
        public string tipomaterial { get; set; }
        public override string ToString()
        {
            return titulo;
        }
    }
}
