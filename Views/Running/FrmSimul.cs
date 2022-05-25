using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Running
{
    public partial class FrmSimul : Form
    {
        public FrmSimul()
        {
            InitializeComponent();
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
        private void PaintPixel(Bitmap bmp, int x, int y, Color color)
        {
            int scale = 30;
            for (int j = 0; j < scale; j++)
                for (int i = 0; i < scale; i++)
                    bmp.SetPixel(i + (x * scale), j + (y * scale), color);

        }
        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(PbCancha.Width, PbCancha.Height);
            //PaintPixel(bmp,30,30,Color.Black);
            bmp.SetPixel(30,30, Color.Black);
            PbCancha.Image = bmp;
        }
    }
}
