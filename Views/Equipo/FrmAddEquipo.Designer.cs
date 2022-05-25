namespace Views.Equipo
{
    partial class FrmAddEquipo
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
            this.btMinimizar = new FontAwesome.Sharp.IconButton();
            this.btSalir = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAddSede = new FontAwesome.Sharp.IconButton();
            this.txtListaSedes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtUniformEquipo = new System.Windows.Forms.TextBox();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmbNumTecnicos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNomEquipo = new System.Windows.Forms.TextBox();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGenerar = new FontAwesome.Sharp.IconButton();
            this.txtCodEquipo = new System.Windows.Forms.TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btMinimizar);
            this.panel1.Controls.Add(this.btSalir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 32);
            this.panel1.TabIndex = 3;
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
            this.btMinimizar.IconSize = 26;
            this.btMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMinimizar.Location = new System.Drawing.Point(475, 7);
            this.btMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(28, 28);
            this.btMinimizar.TabIndex = 7;
            this.btMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMinimizar.UseVisualStyleBackColor = false;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btSalir.FlatAppearance.BorderSize = 0;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btSalir.IconColor = System.Drawing.Color.Tomato;
            this.btSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btSalir.IconSize = 26;
            this.btSalir.Location = new System.Drawing.Point(508, 2);
            this.btSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(28, 28);
            this.btSalir.TabIndex = 6;
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.label2.Location = new System.Drawing.Point(186, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "AGREGAR EQUIPO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 408);
            this.panel2.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancel.IconColor = System.Drawing.Color.Gold;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(347, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 34);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "CERRAR";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnAdd.IconColor = System.Drawing.Color.DarkTurquoise;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 32;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(33, 365);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 34);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "AGREGAR";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel8.Controls.Add(this.btnAddSede);
            this.panel8.Controls.Add(this.txtListaSedes);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(251, 241);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(256, 116);
            this.panel8.TabIndex = 12;
            // 
            // btnAddSede
            // 
            this.btnAddSede.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddSede.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSede.FlatAppearance.BorderSize = 0;
            this.btnAddSede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSede.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddSede.IconColor = System.Drawing.Color.MintCream;
            this.btnAddSede.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddSede.IconSize = 28;
            this.btnAddSede.Location = new System.Drawing.Point(208, 6);
            this.btnAddSede.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddSede.Name = "btnAddSede";
            this.btnAddSede.Size = new System.Drawing.Size(40, 30);
            this.btnAddSede.TabIndex = 9;
            this.btnAddSede.UseVisualStyleBackColor = false;
            this.btnAddSede.Click += new System.EventHandler(this.btnAddSede_Click);
            // 
            // txtListaSedes
            // 
            this.txtListaSedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtListaSedes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtListaSedes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtListaSedes.Location = new System.Drawing.Point(9, 40);
            this.txtListaSedes.Multiline = true;
            this.txtListaSedes.Name = "txtListaSedes";
            this.txtListaSedes.PlaceholderText = "Ingresar Sede (+) para adicionar sig.";
            this.txtListaSedes.Size = new System.Drawing.Size(240, 27);
            this.txtListaSedes.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "SEDES EQUIPO:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.iconButton1);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(33, 241);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(212, 116);
            this.panel7.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 82);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.iconButton1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.Location = new System.Drawing.Point(117, 60);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(92, 52);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.Text = "CARGAR";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(18, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "ESCUDO DE EQUIPO:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel5.Controls.Add(this.txtUniformEquipo);
            this.panel5.Controls.Add(this.guna2Separator3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(33, 174);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(474, 62);
            this.panel5.TabIndex = 10;
            // 
            // txtUniformEquipo
            // 
            this.txtUniformEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtUniformEquipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUniformEquipo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUniformEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.txtUniformEquipo.Location = new System.Drawing.Point(77, 27);
            this.txtUniformEquipo.MaxLength = 30;
            this.txtUniformEquipo.Name = "txtUniformEquipo";
            this.txtUniformEquipo.PlaceholderText = "Uniforme de Equipo...";
            this.txtUniformEquipo.Size = new System.Drawing.Size(274, 24);
            this.txtUniformEquipo.TabIndex = 6;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.guna2Separator3.FillThickness = 2;
            this.guna2Separator3.Location = new System.Drawing.Point(80, 47);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(311, 14);
            this.guna2Separator3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(71, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "UNIFORME EQUIPO:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel6.Controls.Add(this.cmbNumTecnicos);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(269, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(238, 102);
            this.panel6.TabIndex = 9;
            // 
            // cmbNumTecnicos
            // 
            this.cmbNumTecnicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbNumTecnicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumTecnicos.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbNumTecnicos.FormattingEnabled = true;
            this.cmbNumTecnicos.Items.AddRange(new object[] {
            "Ninguno",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbNumTecnicos.Location = new System.Drawing.Point(58, 46);
            this.cmbNumTecnicos.Name = "cmbNumTecnicos";
            this.cmbNumTecnicos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbNumTecnicos.Size = new System.Drawing.Size(121, 29);
            this.cmbNumTecnicos.TabIndex = 8;
            this.cmbNumTecnicos.Tag = "Ninguno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "NÚMERO DE TECNICOS:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel4.Controls.Add(this.txtNomEquipo);
            this.panel4.Controls.Add(this.guna2Separator2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(33, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(474, 57);
            this.panel4.TabIndex = 7;
            // 
            // txtNomEquipo
            // 
            this.txtNomEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtNomEquipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomEquipo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.txtNomEquipo.Location = new System.Drawing.Point(75, 24);
            this.txtNomEquipo.MaxLength = 50;
            this.txtNomEquipo.Name = "txtNomEquipo";
            this.txtNomEquipo.PlaceholderText = "Nombre de Equipo...";
            this.txtNomEquipo.Size = new System.Drawing.Size(312, 24);
            this.txtNomEquipo.TabIndex = 6;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.guna2Separator2.FillThickness = 2;
            this.guna2Separator2.Location = new System.Drawing.Point(77, 46);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(313, 10);
            this.guna2Separator2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(69, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOMBRE DE EQUIPO:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel3.Controls.Add(this.btnGenerar);
            this.panel3.Controls.Add(this.txtCodEquipo);
            this.panel3.Controls.Add(this.guna2Separator1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(33, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 102);
            this.panel3.TabIndex = 6;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Lime;
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnGenerar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerar.IconSize = 32;
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.Location = new System.Drawing.Point(37, 61);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(160, 34);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGenerar.UseVisualStyleBackColor = false;
            // 
            // txtCodEquipo
            // 
            this.txtCodEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtCodEquipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodEquipo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.txtCodEquipo.Location = new System.Drawing.Point(35, 25);
            this.txtCodEquipo.MaxLength = 10;
            this.txtCodEquipo.Name = "txtCodEquipo";
            this.txtCodEquipo.PlaceholderText = "Ingrese Código";
            this.txtCodEquipo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCodEquipo.Size = new System.Drawing.Size(160, 24);
            this.txtCodEquipo.TabIndex = 6;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(37, 50);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(160, 10);
            this.guna2Separator1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "CODIGO DE EQUIPO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAddEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(540, 440);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddEquipo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private TextBox txtCodEquipo;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnGenerar;
        private Panel panel4;
        private TextBox txtNomEquipo;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Label label3;
        private Panel panel6;
        private Label label5;
        private ComboBox cmbNumTecnicos;
        private Panel panel5;
        private TextBox txtUniformEquipo;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Label label4;
        private Panel panel7;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label6;
        private PictureBox pictureBox1;
        private Panel panel8;
        private Label label7;
        private TextBox txtListaSedes;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btMinimizar;
        private FontAwesome.Sharp.IconButton btSalir;
        private FontAwesome.Sharp.IconButton btnAddSede;
    }
}