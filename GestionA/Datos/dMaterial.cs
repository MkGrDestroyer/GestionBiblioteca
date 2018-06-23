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
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("INSERT INTO Material (titulo, autor, tema, aniopublicacion, editorial_productor, estado, inventario, articulosprestados, tipomaterial) VALUES " +
                    "('{0}', '{1}', '{2}', {3}, '{4}', '{5}', {6}, {7}, '{8}' )", objmaterial.titulo, objmaterial.autor);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "inserto";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public string Modificar(eMaterial objmaterial)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = string.Format("UPDATE Material ")
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
    }
}
