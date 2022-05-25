namespace Views.Equipo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uniform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumTecnicos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnAddEquipo = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel6.Size = new System.Drawing.Size(521, 40);
            this.panel6.TabIndex = 10;
            // 
            // cmbListado
            // 
            this.cmbListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbListado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbListado.FormattingEnabled = true;
            this.cmbListado.Location = new System.Drawing.Point(245, 6);
            this.cmbListado.Name = "cmbListado";
            this.cmbListado.Size = new System.Drawing.Size(165, 29);
            this.cmbListado.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(162, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "EQUIPO:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEquipo,
            this.NomEquipo,
            this.Uniform,
            this.NumTecnicos});
            this.dataGridView1.Location = new System.Drawing.Point(9, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(521, 283);
            this.dataGridView1.TabIndex = 11;
            // 
            // IdEquipo
            // 
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
            this.btnSalir.Location = new System.Drawing.Point(349, 372);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(160, 34);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAddEquipo
            // 
            this.btnAddEquipo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEquipo.FlatAppearance.BorderSize = 0;
            this.btnAddEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEquipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddEquipo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddEquipo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddEquipo.IconColor = System.Drawing.Color.Azure;
            this.btnAddEquipo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddEquipo.IconSize = 32;
            this.btnAddEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddEquipo.Location = new System.Drawing.Point(12, 375);
            this.btnAddEquipo.Name = "btnAddEquipo";
            this.btnAddEquipo.Size = new System.Drawing.Size(205, 34);
            this.btnAddEquipo.TabIndex = 18;
            this.btnAddEquipo.Text = "ADICIONAR EQUIPO";
            this.btnAddEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEquipo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddEquipo.UseVisualStyleBackColor = false;
            this.btnAddEquipo.Click += new System.EventHandler(this.btnAddEquipo_Click);
            // 
            // FrmListEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(540, 421);
            this.Controls.Add(this.btnAddEquipo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListEquipos";
            this.Text = "FrmListEquipos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel6;
        private Label label5;
        private ComboBox cmbListado;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdEquipo;
        private DataGridViewTextBoxColumn NomEquipo;
        private DataGridViewTextBoxColumn Uniform;
        private DataGridViewTextBoxColumn NumTecnicos;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnAddEquipo;
    }
}