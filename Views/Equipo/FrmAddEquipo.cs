using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views;
using Controllers;

namespace Views.Equipo
{
    public partial class FrmAddEquipo : Form
    {
        public EquipoController equipo;
        List<string> listasedes = new List<string>();
        public FrmAddEquipo()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro de salir?",
                                 "Cuadro de Dialogo", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    this.Close();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int sedeEquipo = Convert.ToInt32(cmbNumTecnicos.SelectedItem);
            equipo = new EquipoController();
            bool resp = equipo.AgregarEquipo(txtCodEquipo.Text, txtNomEquipo.Text, txtUniformEquipo.Text, sedeEquipo, "escudo_equipo", listasedes);

            if (resp == true)
                try
                {
                    MessageBox.Show("DATOS ALMACENADOS EXITOSAMENTE¡", "Cuadro de Dialogo", MessageBoxButtons.OK);
                }catch
                {
                    MessageBox.Show("REVISA TUS DATOS¡", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           else
                MessageBox.Show("REVISA TUS DATOS¡", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSede_Click(object sender, EventArgs e)
        {
            if(txtListaSedes.Text=="")
                MessageBox.Show("Ingresar No Ingreso sede", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            { 
              listasedes.Add(txtListaSedes.Text);
              ///txtListaSedes.Text = "";
            }
        }
    }
}
