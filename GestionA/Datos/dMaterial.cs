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
                    "('{0}', '{1}', '{2}', {3}, '{4}', '{5}', {6}, {7}, '{8}' )", objmaterial.titulo, objmaterial.autor,objmaterial.tema, objmaterial.aniopublicacion,
                    objmaterial.editorial_productor, objmaterial.estado, objmaterial.inventario, objmaterial.articulosprestados, objmaterial.tipomaterial);
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
                string update = string.Format("UPDATE Material SET titulo='{0}', autor='{1}', tema='{2}', aniopublicacion={3}, " +
                    "editorial_productor='{4}', estado='{5}', inventario={6}, articulosprestados={7}, tipomaterial={8} Where idmaterial={9}",
                    objmaterial.titulo, objmaterial.autor, objmaterial.tema, objmaterial.aniopublicacion, objmaterial.editorial_productor,
                    objmaterial.estado, objmaterial.inventario, objmaterial.articulosprestados, objmaterial.tipomaterial, objmaterial.idmaterial);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "modifico";
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
        public List<eMaterial> ListarTodo()
        {
            try
            {
                List<eMaterial> ls_material = new List<eMaterial>();
                eMaterial objmaterial = null;
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("SELECT idmaterial, titulo, autor, tema, aniopublicacion, editorial_productor, estado, inventario, articulosprestados, tipomaterial from Material", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    objmaterial = new eMaterial();
                    objmaterial.idmaterial = (int)reader["idmaterial"];
                    objmaterial.titulo = (string)reader["titulo"];
                    objmaterial.autor = (string)reader["autor"];
                    objmaterial.tema = (string)reader["tema"];
                    objmaterial.aniopublicacion = (int)reader["aniopublicacion"];
                    objmaterial.editorial_productor = (string)reader["editorial_productor"];
                    objmaterial.estado = (string)reader["estado"];
                    objmaterial.inventario = (int)reader["inventario"];
                    objmaterial.articulosprestados = (int)reader["articulosprestados"];
                    objmaterial.tipomaterial = (string)reader["tipomaterial"];
                    ls_material.Add(objmaterial);
                }
                reader.Close();
                return ls_material;
            }
            catch(Exception ex)
            {
                return null;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
    }
}
