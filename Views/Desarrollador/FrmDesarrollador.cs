using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Desarrollador
{
    public partial class FrmDesarrollador : Form
    {
        public FrmDesarrollador()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (PbDev.Visible == false) { 
                PbDev.Visible = true;
                btnMostrar.Text = "Ocultar";
                btnMostrar.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                 }
            else { 
                 PbDev.Visible = false;
                 btnMostrar.Text = "Mostrar";
                 btnMostrar.IconChar = FontAwesome.Sharp.IconChar.Eye;
                }
        }
    }
}
