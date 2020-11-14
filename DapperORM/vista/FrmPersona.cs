using System;
using System.Windows.Forms;

namespace PruebaRedsisCorp.vista
{
    public partial class FrmPersona : Form
    {
        public FrmPersona()
        {
            InitializeComponent();
        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrirFrmRol_Click(object sender, EventArgs e)
        {
            FrmRol frmRol = new FrmRol();
            frmRol.ShowDialog();

        }
    }
}
