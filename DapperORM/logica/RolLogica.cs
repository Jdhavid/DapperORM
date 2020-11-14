using PruebaRedsisCorp.datos;
using PruebaRedsisCorp.modelo;
using System;
using System.Collections.Generic;

namespace PruebaRedsisCorp.logica
{
    public class RolLogica
    {

        RolDatos rolDatos = new RolDatos();

        public bool Crar(RolModelo rolModelo)
        {

            if (string.IsNullOrEmpty(rolModelo.descripcion))
            {
                return false;
            }

            return rolDatos.Crear(rolModelo);
        }

        public bool Buscar(RolModelo rolModelo)
        {

            throw new NotImplementedException();
        }


        public bool Modificar(RolModelo rolModelo)
        {

            throw new NotImplementedException();
        }

        public List<RolModelo> ListarTodos()
        {

            try
            {
                return rolDatos.ListarTodos();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

}
