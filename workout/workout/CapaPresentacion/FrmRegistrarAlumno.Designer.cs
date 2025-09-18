namespace workout.CapaPresentacion
{
    partial class FrmRegistrarAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarAlumno));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRegistrarAlumno = new System.Windows.Forms.Button();
            this.txtNombAlumno = new System.Windows.Forms.TextBox();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.txtDniAlumno = new System.Windows.Forms.TextBox();
            this.ePDniAlumno = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePApeAlumno = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePNomAlumno = new System.Windows.Forms.ErrorProvider(this.components);
            this.picMascota = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApeAlumno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fechaNacAlumno = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetallesAlum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreoAlum = new System.Windows.Forms.TextBox();
            this.lblCorreoAlum = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.AsigEntrenador = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ePDniAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePApeAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePNomAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(160, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(247, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar Alumno ";
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.AutoEllipsis = true;
            this.btnRegistrarAlumno.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegistrarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegistrarAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAlumno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(179, 664);
            this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            this.btnRegistrarAlumno.Size = new System.Drawing.Size(196, 29);
            this.btnRegistrarAlumno.TabIndex = 7;
            this.btnRegistrarAlumno.Text = "REGISTRAR";
            this.btnRegistrarAlumno.UseVisualStyleBackColor = false;
            this.btnRegistrarAlumno.Click += new System.EventHandler(this.btnRegistrarAlumno_Click);
            // 
            // txtNombAlumno
            // 
            this.txtNombAlumno.Location = new System.Drawing.Point(131, 201);
            this.txtNombAlumno.Name = "txtNombAlumno";
            this.txtNombAlumno.Size = new System.Drawing.Size(326, 20);
            this.txtNombAlumno.TabIndex = 11;
            this.txtNombAlumno.Text = "Ej.: Juan";
            this.txtNombAlumno.TextChanged += new System.EventHandler(this.txtNombAlumno_TextChanged);
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Checked = true;
            this.rbHombre.Location = new System.Drawing.Point(145, 548);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(62, 17);
            this.rbHombre.TabIndex = 14;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(228, 548);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(51, 17);
            this.rbMujer.TabIndex = 15;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Location = new System.Drawing.Point(308, 548);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(45, 17);
            this.rbOtro.TabIndex = 16;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            // 
            // txtDniAlumno
            // 
            this.txtDniAlumno.Location = new System.Drawing.Point(131, 141);
            this.txtDniAlumno.Name = "txtDniAlumno";
            this.txtDniAlumno.Size = new System.Drawing.Size(326, 20);
            this.txtDniAlumno.TabIndex = 19;
            this.txtDniAlumno.Text = "Ej.: 12123123";
            this.txtDniAlumno.TextChanged += new System.EventHandler(this.txtDniAlumno_TextChanged);
            this.txtDniAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniAlumno_KeyPress);
            // 
            // ePDniAlumno
            // 
            this.ePDniAlumno.ContainerControl = this;
            // 
            // ePApeAlumno
            // 
            this.ePApeAlumno.ContainerControl = this;
            // 
            // ePNomAlumno
            // 
            this.ePNomAlumno.ContainerControl = this;
            // 
            // picMascota
            // 
            this.picMascota.Image = ((System.Drawing.Image)(resources.GetObject("picMascota.Image")));
            this.picMascota.Location = new System.Drawing.Point(62, 23);
            this.picMascota.Name = "picMascota";
            this.picMascota.Size = new System.Drawing.Size(73, 78);
            this.picMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMascota.TabIndex = 22;
            this.picMascota.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(119, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ingrese sú DNI sin puntos ni espacio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(122, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ingrese sú Nombre completo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(122, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ingrese sú Apellido completo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtApeAlumno
            // 
            this.txtApeAlumno.Location = new System.Drawing.Point(131, 263);
            this.txtApeAlumno.Name = "txtApeAlumno";
            this.txtApeAlumno.Size = new System.Drawing.Size(326, 20);
            this.txtApeAlumno.TabIndex = 26;
            this.txtApeAlumno.Text = "Ej.: Perez";
            this.txtApeAlumno.TextChanged += new System.EventHandler(this.txtApeAlumno_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(125, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ingrese sú Fecha de nacimiento";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fechaNacAlumno
            // 
            this.fechaNacAlumno.Location = new System.Drawing.Point(137, 389);
            this.fechaNacAlumno.MaxDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.fechaNacAlumno.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.fechaNacAlumno.Name = "fechaNacAlumno";
            this.fechaNacAlumno.Size = new System.Drawing.Size(200, 20);
            this.fechaNacAlumno.TabIndex = 30;
            this.fechaNacAlumno.Value = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.fechaNacAlumno.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(125, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 31);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ingrese Detalles adicionales";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDetallesAlum
            // 
            this.txtDetallesAlum.Location = new System.Drawing.Point(137, 455);
            this.txtDetallesAlum.Multiline = true;
            this.txtDetallesAlum.Name = "txtDetallesAlum";
            this.txtDetallesAlum.Size = new System.Drawing.Size(326, 44);
            this.txtDetallesAlum.TabIndex = 32;
            this.txtDetallesAlum.Text = "Ej.: Dolor de rodilla, hernia de disco, etc";
            this.txtDetallesAlum.TextChanged += new System.EventHandler(this.txtDetallesAlum_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(128, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 31);
            this.label6.TabIndex = 33;
            this.label6.Text = "Seleccione Genero correspondiente";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCorreoAlum
            // 
            this.txtCorreoAlum.Location = new System.Drawing.Point(134, 327);
            this.txtCorreoAlum.Name = "txtCorreoAlum";
            this.txtCorreoAlum.Size = new System.Drawing.Size(326, 20);
            this.txtCorreoAlum.TabIndex = 35;
            this.txtCorreoAlum.Text = "Ej.: juanPerez@gmail.com";
            this.txtCorreoAlum.TextChanged += new System.EventHandler(this.txtCorreoAlum_TextChanged);
            // 
            // lblCorreoAlum
            // 
            this.lblCorreoAlum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoAlum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCorreoAlum.Location = new System.Drawing.Point(125, 299);
            this.lblCorreoAlum.Name = "lblCorreoAlum";
            this.lblCorreoAlum.Size = new System.Drawing.Size(206, 25);
            this.lblCorreoAlum.TabIndex = 34;
            this.lblCorreoAlum.Text = "Ingrese sú Correo Electronico";
            this.lblCorreoAlum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnLimpiar.Location = new System.Drawing.Point(179, 699);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(196, 29);
            this.btnLimpiar.TabIndex = 36;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // AsigEntrenador
            // 
            this.AsigEntrenador.FormattingEnabled = true;
            this.AsigEntrenador.Location = new System.Drawing.Point(101, 609);
            this.AsigEntrenador.Name = "AsigEntrenador";
            this.AsigEntrenador.Size = new System.Drawing.Size(391, 21);
            this.AsigEntrenador.TabIndex = 37;
            this.AsigEntrenador.SelectedIndexChanged += new System.EventHandler(this.AsigEntrenador_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(128, 575);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 31);
            this.label7.TabIndex = 38;
            this.label7.Text = "Entrenador";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmRegistrarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 749);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AsigEntrenador);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtCorreoAlum);
            this.Controls.Add(this.lblCorreoAlum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDetallesAlum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fechaNacAlumno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApeAlumno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picMascota);
            this.Controls.Add(this.txtDniAlumno);
            this.Controls.Add(this.rbOtro);
            this.Controls.Add(this.rbMujer);
            this.Controls.Add(this.rbHombre);
            this.Controls.Add(this.txtNombAlumno);
            this.Controls.Add(this.btnRegistrarAlumno);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmRegistrarAlumno";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.ePDniAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePApeAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePNomAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRegistrarAlumno;
        private System.Windows.Forms.TextBox txtNombAlumno;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.TextBox txtDniAlumno;
        private System.Windows.Forms.ErrorProvider ePDniAlumno;
        private System.Windows.Forms.ErrorProvider ePApeAlumno;
        private System.Windows.Forms.ErrorProvider ePNomAlumno;
        private System.Windows.Forms.PictureBox picMascota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApeAlumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaNacAlumno;
        private System.Windows.Forms.TextBox txtDetallesAlum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreoAlum;
        private System.Windows.Forms.Label lblCorreoAlum;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AsigEntrenador;
    }
}