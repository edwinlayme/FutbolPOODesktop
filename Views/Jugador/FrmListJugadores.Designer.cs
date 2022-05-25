namespace Views.Jugador
{
    partial class FrmListJugadores
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
            this.cmbListEquipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumCamiseta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnAddJugador = new FontAwesome.Sharp.IconButton();
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
            this.panel1.Size = new System.Drawing.Size(540, 32);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.label2.Location = new System.Drawing.Point(157, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "GESTIONAR JUGADORES";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel6.Controls.Add(this.cmbListEquipo);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(12, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(521, 40);
            this.panel6.TabIndex = 11;
            // 
            // cmbListEquipo
            // 
            this.cmbListEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbListEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbListEquipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbListEquipo.FormattingEnabled = true;
            this.cmbListEquipo.Location = new System.Drawing.Point(281, 6);
            this.cmbListEquipo.Name = "cmbListEquipo";
            this.cmbListEquipo.Size = new System.Drawing.Size(165, 29);
            this.cmbListEquipo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(72, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "SELECCIONAR EQUIPO:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodJugador,
            this.CIJugador,
            this.NomJugador,
            this.NumCamiseta});
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(521, 278);
            this.dataGridView1.TabIndex = 12;
            // 
            // CodJugador
            // 
            this.CodJugador.HeaderText = "Cod_Jugador";
            this.CodJugador.Name = "CodJugador";
            // 
            // CIJugador
            // 
            this.CIJugador.HeaderText = "CI. JUGADOR";
            this.CIJugador.Name = "CIJugador";
            // 
            // NomJugador
            // 
            this.NomJugador.HeaderText = "JUGADOR";
            this.NomJugador.Name = "NomJugador";
            // 
            // NumCamiseta
            // 
            this.NumCamiseta.HeaderText = "Camiseta Número";
            this.NumCamiseta.Name = "NumCamiseta";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnCancel.IconColor = System.Drawing.Color.Gold;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(392, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 34);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "SALIR";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddJugador
            // 
            this.btnAddJugador.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddJugador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddJugador.FlatAppearance.BorderSize = 0;
            this.btnAddJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddJugador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddJugador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddJugador.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddJugador.IconColor = System.Drawing.Color.Azure;
            this.btnAddJugador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddJugador.IconSize = 32;
            this.btnAddJugador.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddJugador.Location = new System.Drawing.Point(12, 368);
            this.btnAddJugador.Name = "btnAddJugador";
            this.btnAddJugador.Size = new System.Drawing.Size(186, 34);
            this.btnAddJugador.TabIndex = 17;
            this.btnAddJugador.Text = "NUEVO JUGADOR";
            this.btnAddJugador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddJugador.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddJugador.UseVisualStyleBackColor = false;
            this.btnAddJugador.Click += new System.EventHandler(this.btnAddJugador_Click);
            // 
            // FrmListJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(540, 435);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddJugador);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListJugadores";
            this.Text = "FrmListJugadores";
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
        private ComboBox cmbListEquipo;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CodJugador;
        private DataGridViewTextBoxColumn CIJugador;
        private DataGridViewTextBoxColumn NomJugador;
        private DataGridViewTextBoxColumn NumCamiseta;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnAddJugador;
    }
}