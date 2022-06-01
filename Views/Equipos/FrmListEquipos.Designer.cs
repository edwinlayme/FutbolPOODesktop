namespace Views.Equipos
{
    partial class FrmListEquipos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmbListado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.IdEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uniform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumTecnicos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sedes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnEditEquipo = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 29);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.label2.Location = new System.Drawing.Point(171, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "LISTA DE EQUIPOS";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel6.Controls.Add(this.cmbListado);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(9, 35);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(521, 44);
            this.panel6.TabIndex = 10;
            // 
            // cmbListado
            // 
            this.cmbListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbListado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbListado.FormattingEnabled = true;
            this.cmbListado.Location = new System.Drawing.Point(242, 7);
            this.cmbListado.Name = "cmbListado";
            this.cmbListado.Size = new System.Drawing.Size(165, 29);
            this.cmbListado.TabIndex = 8;
            this.cmbListado.SelectedIndexChanged += new System.EventHandler(this.cmbListado_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(117, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "COD EQUIPO:";
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEquipo,
            this.NomEquipo,
            this.Uniform,
            this.NumTecnicos,
            this.Sedes});
            this.dgvLista.Location = new System.Drawing.Point(9, 100);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowTemplate.Height = 25;
            this.dgvLista.Size = new System.Drawing.Size(521, 271);
            this.dgvLista.TabIndex = 11;
            this.dgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellClick);
            // 
            // IdEquipo
            // 
            this.IdEquipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdEquipo.HeaderText = "Cod_Equipo";
            this.IdEquipo.Name = "IdEquipo";
            // 
            // NomEquipo
            // 
            this.NomEquipo.HeaderText = "Equipo";
            this.NomEquipo.Name = "NomEquipo";
            // 
            // Uniform
            // 
            this.Uniform.HeaderText = "Uniforme Equipo";
            this.Uniform.Name = "Uniform";
            // 
            // NumTecnicos
            // 
            this.NumTecnicos.HeaderText = "Número Técnicos";
            this.NumTecnicos.Name = "NumTecnicos";
            // 
            // Sedes
            // 
            this.Sedes.HeaderText = "Sedes";
            this.Sedes.Name = "Sedes";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Tomato;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnSalir.IconColor = System.Drawing.Color.Gold;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(368, 389);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(160, 34);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditEquipo
            // 
            this.btnEditEquipo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditEquipo.FlatAppearance.BorderSize = 0;
            this.btnEditEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEquipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditEquipo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditEquipo.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditEquipo.IconColor = System.Drawing.Color.Azure;
            this.btnEditEquipo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditEquipo.IconSize = 32;
            this.btnEditEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditEquipo.Location = new System.Drawing.Point(9, 389);
            this.btnEditEquipo.Name = "btnEditEquipo";
            this.btnEditEquipo.Size = new System.Drawing.Size(173, 34);
            this.btnEditEquipo.TabIndex = 18;
            this.btnEditEquipo.Text = "EDITAR EQUIPO";
            this.btnEditEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditEquipo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditEquipo.UseVisualStyleBackColor = false;
            this.btnEditEquipo.Click += new System.EventHandler(this.btnEditEquipo_Click);
            // 
            // FrmListEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(540, 435);
            this.Controls.Add(this.btnEditEquipo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListEquipos";
            this.Text = "FrmListEquipos";
            this.Load += new System.EventHandler(this.FrmListEquipos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Panel panel1;
        public Label label2;
        public Panel panel6;
        public Label label5;
        public ComboBox cmbListado;
        public DataGridView dgvLista;
        public FontAwesome.Sharp.IconButton btnSalir;
        public FontAwesome.Sharp.IconButton btnEditEquipo;
        private DataGridViewTextBoxColumn IdEquipo;
        private DataGridViewTextBoxColumn NomEquipo;
        private DataGridViewTextBoxColumn Uniform;
        private DataGridViewTextBoxColumn NumTecnicos;
        private DataGridViewTextBoxColumn Sedes;
    }
}