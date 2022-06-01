using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Jugador
{
    public partial class FrmListJugadores : Form
    {
        public FrmListJugadores()
        {
            InitializeComponent();
        }

        private void btnAddJugador_Click(object sender, EventArgs e)
        {
            FrmEditJugador frm = new Jugador.FrmEditJugador();
            frm.btMinimizar.Visible = true;
            frm.btSalir.Visible = true;
            frm.ShowDialog();
         }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro de salir?","SALIR APLICACION", MessageBoxButtons.YesNo);
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
