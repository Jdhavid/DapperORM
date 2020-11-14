using Org.BouncyCastle.Bcpg.OpenPgp;
using PruebaRedsisCorp.logica;
using PruebaRedsisCorp.modelo;
using System;
using System.Windows.Forms;

namespace PruebaRedsisCorp.vista
{
    public partial class FrmRol : Form
    {
        public FrmRol()
        {
            InitializeComponent();
        }

        private void FrmRol_Load(object sender, EventArgs e)
        {
            ListarRoles();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CrearRol();
            ListarRoles();
        }

        private void CrearRol()
        {
            string mensaje = string.Empty;
            try
            {
                RolModelo rolModelo = new RolModelo();
                rolModelo.descripcion = txtNombreRol.Text;
                rolModelo.esActivo = cbxEsActivo.Checked;
                RolLogica rolLogica = new RolLogica();
               mensaje  = rolLogica.Crar(rolModelo) ? "Rol fue Creado con Exito." : "Rol NO fue Creado.";

            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            MessageBox.Show(mensaje);
        }

        private void ListarRoles()
        {
            try
            {
                RolLogica rolLogica = new RolLogica();
                var roles = rolLogica.ListarTodos();
                dgvRoles.Rows.Clear();
                foreach (var rol in roles)
                {
                    dgvRoles.Rows.Add(rol.descripcion, rol.esActivo);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
