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
    public partial class FrmListEquipos : Form
    {
        EquipoController<Equipo> listaEquipos = new EquipoController<Equipo>("equipos.json");
        List<string> listasedes = new List<string>();
        public FrmListEquipos()
        {
            InitializeComponent();
            listaEquipos.Cargar();
            mostrarEquipo(listaEquipos.lista);
            mostrarLista(listaEquipos.lista);
            cmbListado.SelectedIndex = 0;

        }
        public void mostrarEquipo(List<Equipo> listaDataGrid)
        {
            string sedes;
            dgvLista.Rows.Clear();
            foreach (Equipo item in listaDataGrid)
            {
                DataGridViewRow fila = new DataGridViewRow();
                sedes = item.sedes_equipo.FirstOrDefault()+" - ";
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = item.cod_equipo });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = item.nom_equipo });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = item.uniforme });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = item.num_tecnicos });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = sedes});
                dgvLista.Rows.Add(fila);
            }
        }
        public void mostrarLista(List<Equipo> listaDataGrid)
        {
            cmbListado.Items.Clear();
            foreach (Equipo item in listaDataGrid)
            {
                cmbListado.Items.Add(item.cod_equipo);
            }
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

        private void btnEditEquipo_Click(object sender, EventArgs e)
        {
            int indice= cmbListado.SelectedIndex;
            FrmEditEquipo frmEdit = new FrmEditEquipo();
            frmEdit.btMinimizar.Visible = true;
            frmEdit.btSalir.Visible = true;
             // establece el codigo seleccionado para edicion;
            Equipo buscaEquipo = listaEquipos.Buscar(x => x.cod_equipo.ToString() == cmbListado.Items[indice].ToString())[0];
            frmEdit.cmbCodEquipo.Items.Add(cmbListado.Items[indice].ToString());
            frmEdit.cmbCodEquipo.SelectedIndex = 0;
            frmEdit.txtNomEquipo.Text = buscaEquipo.nom_equipo;
            frmEdit.txtUniformEquipo.Text = buscaEquipo.uniforme;
            frmEdit.cmbNumTecnicos.SelectedItem = buscaEquipo.num_tecnicos.ToString();
            frmEdit.txtListaSedes.Text = buscaEquipo.sedes_equipo.FirstOrDefault();
            frmEdit.Show();
        }


        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cmbListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            var buscar = listaEquipos.Buscar(x => x.cod_equipo.ToString() == cmbListado.Text);
            mostrarEquipo(buscar);
        }

        private void FrmListEquipos_Load(object sender, EventArgs e)
        {
            mostrarEquipo(listaEquipos.lista);
        }
    }
}
