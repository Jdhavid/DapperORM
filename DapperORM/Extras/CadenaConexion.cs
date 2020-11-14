using System.Configuration;

namespace PruebaRedsisCorp.Extras
{
    public class CadenaConexion
    {

        public static string ObtenerCadenaConexion { get { return ConfigurationManager.ConnectionStrings["pruebaRedsiscorp"].ConnectionString; } }

    }
}
