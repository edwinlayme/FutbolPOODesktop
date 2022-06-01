using Controllers;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Equipos
{
    public partial class FrmEditEquipo : Form
    {
        EquipoController<Equipo> listaEquipos = new EquipoController<Equipo>("equipos.json");
        List<string> listasedes = new List<string>();
        public FrmEditEquipo()
        {
            InitializeComponent(); 
            listaEquipos.Cargar();         
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int indice = cmbCodEquipo.SelectedIndex;
            int CodEdit = int.Parse(cmbCodEquipo.Text);
            Equipo buscaEquipo = new Equipo(CodEdit, txtNomEquipo.Text, txtUniformEquipo.Text, int.Parse(cmbNumTecnicos.Text), "escudo", listasedes);
            if (buscaEquipo != null)
            {
                listaEquipos.Actualizar(x => x.cod_equipo == CodEdit, buscaEquipo);
                MessageBox.Show("DATOS ALMACENADOS EXITOSAMENTE¡", "Cuadro de Dialogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("REVISA TUS DATOS¡", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           // mostrar(listaEquipos.lista);
        }

        private void btnAddSede_Click(object sender, EventArgs e)
        {
            if (txtListaSedes.Text == "")
                MessageBox.Show("No Ingreso Sede", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                listasedes.Add(txtListaSedes.Text);
                MessageBox.Show("SEDE ADICIONADO EXITOSAMENTE¡", "Informacion Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtListaSedes.Text = "";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(cmbCodEquipo.Text);
            listaEquipos.Eliminar(x=>x.cod_equipo == cod);
        }
    }
}
