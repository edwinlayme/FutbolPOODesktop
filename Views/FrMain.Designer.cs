namespace Views
{
    partial class FrMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrMain));
            this.panelSup = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btMinimizar = new FontAwesome.Sharp.IconButton();
            this.btSalir = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnDesarrollador = new FontAwesome.Sharp.IconButton();
            this.BtnGuia = new FontAwesome.Sharp.IconButton();
            this.BtnListJugadores = new FontAwesome.Sharp.IconButton();
            this.BtnEditEquipo = new FontAwesome.Sharp.IconButton();
            this.BtnInicio = new FontAwesome.Sharp.IconButton();
            this.lbMain = new System.Windows.Forms.Label();
            this.panelSup.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSup
            // 
            this.panelSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panelSup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSup.Controls.Add(this.label1);
            this.panelSup.Controls.Add(this.btMinimizar);
            this.panelSup.Controls.Add(this.btSalir);
            this.panelSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSup.Location = new System.Drawing.Point(0, 0);
            this.panelSup.Margin = new System.Windows.Forms.Padding(0);
            this.panelSup.Name = "panelSup";
            this.panelSup.Size = new System.Drawing.Size(720, 40);
            this.panelSup.TabIndex = 0;
            this.panelSup.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSup_Paint);
            this.panelSup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSup_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Sigmar One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(269, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "APP FUTBOL - POO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btMinimizar
            // 
            this.btMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btMinimizar.FlatAppearance.BorderSize = 0;
            this.btMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btMinimizar.IconColor = System.Drawing.Color.Azure;
            this.btMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btMinimizar.IconSize = 32;
            this.btMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMinimizar.Location = new System.Drawing.Point(641, 9);
            this.btMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(40, 29);
            this.btMinimizar.TabIndex = 1;
            this.btMinimizar.UseVisualStyleBackColor = false;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btSalir.FlatAppearance.BorderSize = 0;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btSalir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.btSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btSalir.IconSize = 32;
            this.btSalir.Location = new System.Drawing.Point(682, 6);
            this.btSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(32, 30);
            this.btSalir.TabIndex = 0;
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 440);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(190)))), ((int)(((byte)(237)))));
            this.splitContainer1.Panel1.Controls.Add(this.BtnDesarrollador);
            this.splitContainer1.Panel1.Controls.Add(this.BtnGuia);
            this.splitContainer1.Panel1.Controls.Add(this.BtnListJugadores);
            this.splitContainer1.Panel1.Controls.Add(this.BtnEditEquipo);
            this.splitContainer1.Panel1.Controls.Add(this.BtnInicio);
            this.splitContainer1.Panel1.Controls.Add(this.lbMain);
            this.splitContainer1.Panel1MinSize = 180;
            this.splitContainer1.Size = new System.Drawing.Size(720, 440);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // BtnDesarrollador
            // 
            this.BtnDesarrollador.AutoEllipsis = true;
            this.BtnDesarrollador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(190)))), ((int)(((byte)(237)))));
            this.BtnDesarrollador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDesarrollador.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDesarrollador.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnDesarrollador.FlatAppearance.BorderSize = 0;
            this.BtnDesarrollador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesarrollador.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDesarrollador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDesarrollador.IconChar = FontAwesome.Sharp.IconChar.Desktop;
            this.BtnDesarrollador.IconColor = System.Drawing.Color.Black;
            this.BtnDesarrollador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDesarrollador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDesarrollador.Location = new System.Drawing.Point(0, 225);
            this.BtnDesarrollador.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDesarrollador.Name = "BtnDesarrollador";
            this.BtnDesarrollador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnDesarrollador.Size = new System.Drawing.Size(180, 50);
            this.BtnDesarrollador.TabIndex = 10;
            this.BtnDesarrollador.Text = "ACERCA DE...";
            this.BtnDesarrollador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDesarrollador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDesarrollador.UseVisualStyleBackColor = false;
            this.BtnDesarrollador.Click += new System.EventHandler(this.BtnDesarrollador_Click);
            // 
            // BtnGuia
            // 
            this.BtnGuia.AutoEllipsis = true;
            this.BtnGuia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(190)))), ((int)(((byte)(237)))));
            this.BtnGuia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuia.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGuia.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnGuia.FlatAppearance.BorderSize = 0;
            this.BtnGuia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuia.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuia.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.BtnGuia.IconColor = System.Drawing.Color.Black;
            this.BtnGuia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuia.Location = new System.Drawing.Point(0, 175);
            this.BtnGuia.Margin = new System.Windows.Forms.Padding(0);
            this.BtnGuia.Name = "BtnGuia";
            this.BtnGuia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnGuia.Size = new System.Drawing.Size(180, 50);
            this.BtnGuia.TabIndex = 9;
            this.BtnGuia.Text = "GUIA DE USUARIO";
            this.BtnGuia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuia.UseVisualStyleBackColor = false;
            this.BtnGuia.Click += new System.EventHandler(this.BtnGuia_Click);
            // 
            // BtnListJugadores
            // 
            this.BtnListJugadores.AutoEllipsis = true;
            this.BtnListJugadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(190)))), ((int)(((byte)(237)))));
            this.BtnListJugadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnListJugadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnListJugadores.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnListJugadores.FlatAppearance.BorderSize = 0;
            this.BtnListJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListJugadores.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnListJugadores.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnListJugadores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnListJugadores.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.BtnListJugadores.IconColor = System.Drawing.Color.Black;
            this.BtnListJugadores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnListJugadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListJugadores.Location = new System.Drawing.Point(0, 125);
            this.BtnListJugadores.Margin = new System.Windows.Forms.Padding(0);
            this.BtnListJugadores.Name = "BtnListJugadores";
            this.BtnListJugadores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnListJugadores.Size = new System.Drawing.Size(180, 50);
            this.BtnListJugadores.TabIndex = 8;
            this.BtnListJugadores.Text = "LISTA JUGADORES";
            this.BtnListJugadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListJugadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnListJugadores.UseVisualStyleBackColor = false;
            this.BtnListJugadores.Click += new System.EventHandler(this.BtnListJugadores_Click);
            // 
            // BtnEditEquipo
            // 
            this.BtnEditEquipo.AutoEllipsis = true;
            this.BtnEditEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(190)))), ((int)(((byte)(237)))));
            this.BtnEditEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditEquipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEditEquipo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnEditEquipo.FlatAppearance.BorderSize = 0;
            this.BtnEditEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditEquipo.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnEditEquipo.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditEquipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditEquipo.IconChar = FontAwesome.Sharp.IconChar.Futbol;
            this.BtnEditEquipo.IconColor = System.Drawing.Color.Black;
            this.BtnEditEquipo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditEquipo.Location = new System.Drawing.Point(0, 75);
            this.BtnEditEquipo.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEditEquipo.Name = "BtnEditEquipo";
            this.BtnEditEquipo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnEditEquipo.Size = new System.Drawing.Size(180, 50);
            this.BtnEditEquipo.TabIndex = 7;
            this.BtnEditEquipo.Text = "GESTION EQUIPOS";
            this.BtnEditEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditEquipo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditEquipo.UseVisualStyleBackColor = false;
            this.BtnEditEquipo.Click += new System.EventHandler(this.BtnEditEquipo_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(237)))));
            this.BtnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.BtnInicio.IconColor = System.Drawing.Color.Black;
            this.BtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.Location = new System.Drawing.Point(0, 29);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(180, 46);
            this.BtnInicio.TabIndex = 1;
            this.BtnInicio.Text = "INICIO";
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // lbMain
            // 
            this.lbMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lbMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbMain.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMain.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbMain.Location = new System.Drawing.Point(0, 0);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(180, 29);
            this.lbMain.TabIndex = 0;
            this.lbMain.Text = "MENU";
            this.lbMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(720, 480);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "FrMain";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROYECTO-FUTBOL";
            this.Load += new System.EventHandler(this.FrMain_Load);
            this.panelSup.ResumeLayout(false);
            this.panelSup.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSup;
        private FontAwesome.Sharp.IconButton btSalir;
        private FontAwesome.Sharp.IconButton btMinimizar;
        private Label label1;
        private Panel panel2;
        public SplitContainer splitContainer1;
        private FontAwesome.Sharp.IconButton BtnDesarrollador;
        private FontAwesome.Sharp.IconButton BtnGuia;
        private FontAwesome.Sharp.IconButton BtnListJugadores;
        private FontAwesome.Sharp.IconButton BtnEditEquipo;
        private FontAwesome.Sharp.IconButton BtnInicio;
        private Label lbMain;
    }
}