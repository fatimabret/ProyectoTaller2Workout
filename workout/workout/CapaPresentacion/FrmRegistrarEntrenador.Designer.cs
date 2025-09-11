namespace workout.CapaPresentacion
{
    partial class FrmRegistrarEntrenador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarEntrenador));
            this.btnRegistrarEntrenador = new System.Windows.Forms.Button();
            this.txtApeEntrenador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picMascota = new System.Windows.Forms.PictureBox();
            this.txtDniEntrenador = new System.Windows.Forms.TextBox();
            this.txtNomEntrenador = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbHorarioDisponible = new System.Windows.Forms.ComboBox();
            this.cmbDiasDisponibles = new System.Windows.Forms.ComboBox();
            this.cmbEspecializacion = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarEntrenador
            // 
            this.btnRegistrarEntrenador.AutoEllipsis = true;
            this.btnRegistrarEntrenador.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegistrarEntrenador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegistrarEntrenador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEntrenador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarEntrenador.Location = new System.Drawing.Point(194, 514);
            this.btnRegistrarEntrenador.Name = "btnRegistrarEntrenador";
            this.btnRegistrarEntrenador.Size = new System.Drawing.Size(196, 29);
            this.btnRegistrarEntrenador.TabIndex = 27;
            this.btnRegistrarEntrenador.Text = "REGISTRAR";
            this.btnRegistrarEntrenador.UseVisualStyleBackColor = false;
            this.btnRegistrarEntrenador.Click += new System.EventHandler(this.btnRegistrarEntrenador_Click);
            // 
            // txtApeEntrenador
            // 
            this.txtApeEntrenador.Location = new System.Drawing.Point(127, 264);
            this.txtApeEntrenador.Name = "txtApeEntrenador";
            this.txtApeEntrenador.Size = new System.Drawing.Size(326, 20);
            this.txtApeEntrenador.TabIndex = 38;
            this.txtApeEntrenador.Text = "Ej.: Perez";
            this.txtApeEntrenador.TextChanged += new System.EventHandler(this.txtApeEntrenador_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(118, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Ingrese sú Apellido completo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(118, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Ingrese sú Nombre completo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(115, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ingrese sú DNI sin puntos ni espacio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picMascota
            // 
            this.picMascota.Image = ((System.Drawing.Image)(resources.GetObject("picMascota.Image")));
            this.picMascota.Location = new System.Drawing.Point(58, 24);
            this.picMascota.Name = "picMascota";
            this.picMascota.Size = new System.Drawing.Size(73, 78);
            this.picMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMascota.TabIndex = 34;
            this.picMascota.TabStop = false;
            // 
            // txtDniEntrenador
            // 
            this.txtDniEntrenador.Location = new System.Drawing.Point(127, 142);
            this.txtDniEntrenador.Name = "txtDniEntrenador";
            this.txtDniEntrenador.Size = new System.Drawing.Size(326, 20);
            this.txtDniEntrenador.TabIndex = 33;
            this.txtDniEntrenador.Text = "Ej.: 12123123";
            this.txtDniEntrenador.TextChanged += new System.EventHandler(this.txtDniEntrenador_TextChanged);
            this.txtDniEntrenador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniEntrenador_KeyPress);
            // 
            // txtNomEntrenador
            // 
            this.txtNomEntrenador.Location = new System.Drawing.Point(127, 202);
            this.txtNomEntrenador.Name = "txtNomEntrenador";
            this.txtNomEntrenador.Size = new System.Drawing.Size(326, 20);
            this.txtNomEntrenador.TabIndex = 32;
            this.txtNomEntrenador.Text = "Ej.: Juan";
            this.txtNomEntrenador.TextChanged += new System.EventHandler(this.txtNomEntrenador_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(137, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(286, 31);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "Registrar Entrenador";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(121, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "Ingrese sú Horario disponible";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(118, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "Ingrese sus Días disponibles";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(118, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 31);
            this.label7.TabIndex = 48;
            this.label7.Text = "Ingrese Especialización";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbHorarioDisponible
            // 
            this.cmbHorarioDisponible.FormattingEnabled = true;
            this.cmbHorarioDisponible.Location = new System.Drawing.Point(127, 333);
            this.cmbHorarioDisponible.Name = "cmbHorarioDisponible";
            this.cmbHorarioDisponible.Size = new System.Drawing.Size(326, 21);
            this.cmbHorarioDisponible.TabIndex = 49;
            this.cmbHorarioDisponible.SelectedIndexChanged += new System.EventHandler(this.cmbHorarioDisponible_SelectedIndexChanged);
            // 
            // cmbDiasDisponibles
            // 
            this.cmbDiasDisponibles.FormattingEnabled = true;
            this.cmbDiasDisponibles.Location = new System.Drawing.Point(127, 388);
            this.cmbDiasDisponibles.Name = "cmbDiasDisponibles";
            this.cmbDiasDisponibles.Size = new System.Drawing.Size(326, 21);
            this.cmbDiasDisponibles.TabIndex = 50;
            // 
            // cmbEspecializacion
            // 
            this.cmbEspecializacion.FormattingEnabled = true;
            this.cmbEspecializacion.Location = new System.Drawing.Point(127, 457);
            this.cmbEspecializacion.Name = "cmbEspecializacion";
            this.cmbEspecializacion.Size = new System.Drawing.Size(326, 21);
            this.cmbEspecializacion.TabIndex = 51;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.btnLimpiar.Location = new System.Drawing.Point(194, 549);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(196, 29);
            this.btnLimpiar.TabIndex = 52;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmRegistrarEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 597);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbEspecializacion);
            this.Controls.Add(this.cmbDiasDisponibles);
            this.Controls.Add(this.cmbHorarioDisponible);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApeEntrenador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picMascota);
            this.Controls.Add(this.txtDniEntrenador);
            this.Controls.Add(this.txtNomEntrenador);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnRegistrarEntrenador);
            this.Name = "FrmRegistrarEntrenador";
            this.Text = "Registrar Entrenador";
            this.Load += new System.EventHandler(this.FrmRegistrarEntrenador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrarEntrenador;
        private System.Windows.Forms.TextBox txtApeEntrenador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picMascota;
        private System.Windows.Forms.TextBox txtDniEntrenador;
        private System.Windows.Forms.TextBox txtNomEntrenador;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbHorarioDisponible;
        private System.Windows.Forms.ComboBox cmbDiasDisponibles;
        private System.Windows.Forms.ComboBox cmbEspecializacion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}