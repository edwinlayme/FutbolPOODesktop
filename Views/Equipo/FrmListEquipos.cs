using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Equipo
{
    public partial class FrmListEquipos : Form
    {
        public FrmListEquipos()
        {
            InitializeComponent();
        }

        private void btnAddEquipo_Click(object sender, EventArgs e)
        {
            FrmAddEquipo frmAdd = new FrmAddEquipo();
            frmAdd.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
          DialogResult dr = MessageBox.Show("¿Esta seguro de salir?",
         "SALIR APLICACION", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
