using Dapper;
using MySql.Data.MySqlClient;
using PruebaRedsisCorp.Extras;
using PruebaRedsisCorp.modelo;
using System.Collections.Generic;
using System.Linq;

namespace PruebaRedsisCorp.datos
{

    public class RolDatos
    {
        private string cadenaConexion = CadenaConexion.ObtenerCadenaConexion;

        public bool Crear(RolModelo rolModelo)
        {
            try
            {
                using (var connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();
                    var affectedRows = connection.Execute("Insert into rol (descripcion, es_activo) values (@descripcion, @es_activo)", new { descripcion = rolModelo.descripcion, es_activo = rolModelo.esActivo });
                    connection.Close();
                    return (affectedRows > 0);
                }

            }
            catch (System.Exception)
            {
                throw new System.Exception("Error al Crear ROL.");
            }
        }

        public List<RolModelo> ListarTodos()
        {
            List<RolModelo> roles = new List<RolModelo>();
            try
            {
                using (var connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();
                    roles = connection.Query<RolModelo>("SELECT descripcion, es_activo esActivo FROM rol;").ToList();
                    connection.Close();
                }
            }
            catch (System.Exception)
            {
                throw new System.Exception("Error al Listar ROL.");
            }
            return roles;
        }


    }

}
