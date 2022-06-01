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
using Models;
using Controllers;
using Newtonsoft.Json;

namespace Views.Equipos
{
    public partial class FrmAddEquipo : Form
    {
        // Declarar Controllador de Equipo
        EquipoController<Equipo> listaEquipos = new EquipoController<Equipo>("equipos.json");
        List<string> listasedes = new List<string>();
        int cod;
         public FrmAddEquipo()
        {
            InitializeComponent();
            cmbNumTecnicos.SelectedIndex = 0;
            listaEquipos.Cargar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Equipo nuevo = new Equipo(int.Parse(txtCodEquipo.Text), txtNomEquipo.Text,
                                      txtUniformEquipo.Text,int.Parse(cmbNumTecnicos.Text),"escudo",listasedes);
            if (nuevo != null)
            {
                listaEquipos.Adicionar(nuevo);
                MessageBox.Show("DATOS ALMACENADOS EXITOSAMENTE¡", "Cuadro de Dialogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("REVISA TUS DATOS¡", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAddSede_Click(object sender, EventArgs e)
        {
          if(txtListaSedes.Text=="")
                MessageBox.Show("No Ingreso Sede", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            { 
              listasedes.Add(txtListaSedes.Text);
                MessageBox.Show("SEDE ADICIONADO EXITOSAMENTE¡", "Informacion Adicionado",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtListaSedes.Text = "";
            }
          }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            cod = new Random().Next(100000, 999999);
            txtCodEquipo.Text = cod.ToString();
        }
    }
}
