using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instituto_Terciario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        internal string? rol;
        internal string? usuario;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario + " (" + rol + ")";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cierra todas las ventanas de la app
            Application.Exit();
        }

        private void inscripcion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnInscribirP_Click(object sender, EventArgs e)
        {
            frmInscripcion inscripcion = new frmInscripcion();  
            inscripcion.Show();
            inscripcion.FormClosed += inscripcion_FormClosed;
            this.Hide();
        }
    }
}
