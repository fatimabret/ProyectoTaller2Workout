namespace workout.CapaPresentacion
{
    partial class FrmRegistrarRutina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarRutina));
            this.label8 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrarRutina = new System.Windows.Forms.Button();
            this.picMascota = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvRutina = new System.Windows.Forms.DataGridView();
            this.colEjercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbDias = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutina)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(81, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(374, 21);
            this.label8.TabIndex = 64;
            this.label8.Text = "Seleccione Ejercicios";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoEllipsis = true;
            this.btnLimpiar.BackColor = System.Drawing.Color.Red;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(280, 590);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(196, 29);
            this.btnLimpiar.TabIndex = 62;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrarRutina
            // 
            this.btnRegistrarRutina.AutoEllipsis = true;
            this.btnRegistrarRutina.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegistrarRutina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegistrarRutina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarRutina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarRutina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarRutina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarRutina.Location = new System.Drawing.Point(280, 555);
            this.btnRegistrarRutina.Name = "btnRegistrarRutina";
            this.btnRegistrarRutina.Size = new System.Drawing.Size(196, 29);
            this.btnRegistrarRutina.TabIndex = 57;
            this.btnRegistrarRutina.Text = "REGISTRAR";
            this.btnRegistrarRutina.UseVisualStyleBackColor = false;
            this.btnRegistrarRutina.Click += new System.EventHandler(this.btnRegistrarRutina_Click);
            // 
            // picMascota
            // 
            this.picMascota.Image = ((System.Drawing.Image)(resources.GetObject("picMascota.Image")));
            this.picMascota.Location = new System.Drawing.Point(57, 23);
            this.picMascota.Name = "picMascota";
            this.picMascota.Size = new System.Drawing.Size(73, 78);
            this.picMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMascota.TabIndex = 68;
            this.picMascota.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(136, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(227, 31);
            this.lblTitulo.TabIndex = 67;
            this.lblTitulo.Text = "Registrar Rutina";
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label25.Location = new System.Drawing.Point(349, 78);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(46, 25);
            this.label25.TabIndex = 115;
            this.label25.Text = "Día:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(41, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 30);
            this.button1.TabIndex = 117;
            this.button1.Text = "NUEVO EJERCICIO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRutina
            // 
            this.dgvRutina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRutina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEjercicio});
            this.dgvRutina.Location = new System.Drawing.Point(84, 198);
            this.dgvRutina.Name = "dgvRutina";
            this.dgvRutina.Size = new System.Drawing.Size(371, 176);
            this.dgvRutina.TabIndex = 130;
            this.dgvRutina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRutina_CellContentClick);
            // 
            // colEjercicio
            // 
            this.colEjercicio.HeaderText = "Ejercicio";
            this.colEjercicio.Name = "colEjercicio";
            // 
            // cmbDias
            // 
            this.cmbDias.FormattingEnabled = true;
            this.cmbDias.Location = new System.Drawing.Point(387, 82);
            this.cmbDias.Name = "cmbDias";
            this.cmbDias.Size = new System.Drawing.Size(101, 21);
            this.cmbDias.TabIndex = 131;
            this.cmbDias.SelectedIndexChanged += new System.EventHandler(this.cmbDias_SelectedIndexChanged);
            // 
            // FrmRegistrarRutina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 652);
            this.Controls.Add(this.cmbDias);
            this.Controls.Add(this.dgvRutina);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.picMascota);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrarRutina);
            this.Name = "FrmRegistrarRutina";
            this.Text = "Registrar Rutina";
            this.Load += new System.EventHandler(this.FrmRegistrarRutina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrarRutina;
        private System.Windows.Forms.PictureBox picMascota;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEjercicio;
        private System.Windows.Forms.DataGridView dgvRutina;
        private System.Windows.Forms.ComboBox cmbDias;
    }
}