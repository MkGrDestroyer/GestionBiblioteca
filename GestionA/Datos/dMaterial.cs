using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
namespace Datos
{
    public class dMaterial
    {
        Database db = new Database();
        public string Insertar(eMaterial objmaterial)
        {
            SqlConnection con = db.ConectaDb();
            string insert = string.Format("INSERT INTO Material ")
        }
    }
}
