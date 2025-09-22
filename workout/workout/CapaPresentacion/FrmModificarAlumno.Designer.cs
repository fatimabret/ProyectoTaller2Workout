namespace workout.CapaPresentacion
{
    partial class FrmModificarAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarAlumno));
            this.picMascota = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreoAlum = new System.Windows.Forms.Label();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEntrenador = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // picMascota
            // 
            this.picMascota.Image = ((System.Drawing.Image)(resources.GetObject("picMascota.Image")));
            this.picMascota.Location = new System.Drawing.Point(41, 12);
            this.picMascota.Name = "picMascota";
            this.picMascota.Size = new System.Drawing.Size(73, 78);
            this.picMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMascota.TabIndex = 83;
            this.picMascota.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(172, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(225, 25);
            this.lblTitulo.TabIndex = 82;
            this.lblTitulo.Text = "Modificacion de Datos";
            // 
            // btnModificar
            // 
            this.btnModificar.AutoEllipsis = true;
            this.btnModificar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(177, 695);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(196, 29);
            this.btnModificar.TabIndex = 84;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(117, 289);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(326, 20);
            this.txtCorreo.TabIndex = 96;
            // 
            // lblCorreoAlum
            // 
            this.lblCorreoAlum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoAlum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCorreoAlum.Location = new System.Drawing.Point(117, 261);
            this.lblCorreoAlum.Name = "lblCorreoAlum";
            this.lblCorreoAlum.Size = new System.Drawing.Size(323, 25);
            this.lblCorreoAlum.TabIndex = 95;
            this.lblCorreoAlum.Text = "Correo Electronico";
            this.lblCorreoAlum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(120, 417);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(326, 44);
            this.txtDetalles.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(117, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(329, 31);
            this.label5.TabIndex = 93;
            this.label5.Text = "Detalles adicionales";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(117, 351);
            this.dtpFechaNac.MaxDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNac.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(203, 20);
            this.dtpFechaNac.TabIndex = 92;
            this.dtpFechaNac.Value = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(117, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 25);
            this.label4.TabIndex = 91;
            this.label4.Text = "Fecha de nacimiento";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(114, 225);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(326, 20);
            this.txtApellido.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(114, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 25);
            this.label3.TabIndex = 89;
            this.label3.Text = "Apellido completo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(114, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 21);
            this.label2.TabIndex = 88;
            this.label2.Text = "Nombre completo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(114, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 24);
            this.label1.TabIndex = 87;
            this.label1.Text = "DNI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(114, 103);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(326, 20);
            this.txtDni.TabIndex = 86;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 163);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(326, 20);
            this.txtNombre.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(123, 537);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 31);
            this.label7.TabIndex = 102;
            this.label7.Text = "Entrenador";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbEntrenador
            // 
            this.cmbEntrenador.FormattingEnabled = true;
            this.cmbEntrenador.Location = new System.Drawing.Point(99, 571);
            this.cmbEntrenador.Name = "cmbEntrenador";
            this.cmbEntrenador.Size = new System.Drawing.Size(374, 21);
            this.cmbEntrenador.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(123, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(323, 31);
            this.label6.TabIndex = 100;
            this.label6.Text = "Genero correspondiente";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Location = new System.Drawing.Point(339, 510);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(45, 17);
            this.rbOtro.TabIndex = 99;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(259, 510);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(51, 17);
            this.rbMujer.TabIndex = 98;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(176, 510);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(62, 17);
            this.rbHombre.TabIndex = 97;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(117, 610);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(323, 31);
            this.label8.TabIndex = 106;
            this.label8.Text = "Estado";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Location = new System.Drawing.Point(294, 644);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(55, 17);
            this.rbActivo.TabIndex = 104;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(211, 644);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbInactivo.TabIndex = 103;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            // 
            // FrmModificarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 749);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbActivo);
            this.Controls.Add(this.rbInactivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbEntrenador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbOtro);
            this.Controls.Add(this.rbMujer);
            this.Controls.Add(this.rbHombre);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreoAlum);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.picMascota);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmModificarAlumno";
            this.Text = "Modificar Datos Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMascota;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreoAlum;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEntrenador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.RadioButton rbInactivo;
    }
}