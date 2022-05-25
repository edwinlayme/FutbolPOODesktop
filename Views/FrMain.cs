using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using Views.Equipo;

namespace Views
{
    public partial class FrMain : Form
    {
        private int borderSize = 0;
        public FrMain()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
        }
        //Insertar Formulario en un Panel
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.splitContainer1.Panel2.Controls.Count > 0)
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            Form fh = (Form)Formhijo;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(fh);
            this.splitContainer1.Panel2.Tag = fh;
            fh.Show();
        }
        //Mover Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000;
                return cp;
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelSup_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmInicio());
        }

        private void BtnEditEquipo_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Equipo.FrmListEquipos());
        }

        private void BtnListJugadores_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Jugador.FrmListJugadores());
        }

        private void BtnGuia_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Manual.FrmGuiaUsuario());
        }

        private void BtnDesarrollador_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Desarrollador.FrmDesarrollador());
        }

        private void FrMain_Load(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmInicio());
        }

        private void panelSup_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}