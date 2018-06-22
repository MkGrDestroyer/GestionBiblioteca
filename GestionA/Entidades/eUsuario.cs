using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eUsuario
    {
        public int idusuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipodeusuario { get; set; }
        public string u_usuario { get; set; }
        public string u_password { get; set; }
        public override string ToString()
        {
            return nombre + " " + apellido;
        }
    }
}
