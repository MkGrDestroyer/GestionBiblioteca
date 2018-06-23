using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    class dRegistro
    {
    Database db = new Database();
    public string Insertar(eRegistro obj)
    {
        try
        {
            SqlConnection conn = db.ConectaDb();
            string insert = string.Format("INSERT INTO Registro(fecha, idusuario) VALUES('{0}',{1})", obj.fecha, obj.usuario.idusuario);
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();
            return "Inserto";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
        finally
        {
            db.DesconectaDb();
        }
    }
    public eRegistro BuscarRegistroxID(int id)
    {
        try
        {
            eRegistro registro = null;
            DateTime d;
            eUsuario usuario = null;
            SqlConnection conn = db.ConectaDb();
            string select = string.Format("SELECT re.idregistro, re.fecha, usu.idusuario as Usuario, usu.idusuario from Usuario as usu, Registro as re WHERE usu.idusuario=re.idusuario and re.idusuario={0}", id);
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                registro = new eRegistro();
                usuario = new eUsuario();
                registro.idregistro = (int)reader["idregistro"];
                d = (DateTime)reader["fecha"];
                registro.fecha = d.ToShortDateString();
                usuario.idusuario = (int)reader["Usuario"];
                registro.usuario = usuario;
            }
            reader.Close();
            return registro;
        }
        catch (Exception ex)
        {
            return null;
        }
        finally
        {
            db.DesconectaDb();
        }
    }
    public List<eRegistro> ListarRegistros()
    {
        try
        {
            List<eRegistro> registros = new List<eRegistro>();
            eRegistro registro = null;
            DateTime d;
            eUsuario usuario = null;
            SqlConnection conn = db.ConectaDb();
            string select = string.Format("SELECT re.idregistro, re.fecha, usu.idusuario as Usuario, usu.idusuario from Usuario as usu, Registro as re WHERE usu.idusuario=re.idusuario");
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                registro = new eRegistro();
                usuario = new eUsuario();
                registro.idregistro = (int)reader["idregistro"];
                d = (DateTime)reader["fecha"];
                registro.fecha = d.ToShortDateString();
                usuario.idusuario = (int)reader["Usuario"];
                registro.usuario = usuario;
                registros.Add(registro);
            }
            reader.Close();
            return registros;
        }
        catch (Exception ex)
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
