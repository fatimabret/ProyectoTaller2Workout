namespace workout.CapaPresentacion
{
    partial class FrmInicioAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioAdm));
            this.btnListaEntrenadores = new System.Windows.Forms.Button();
            this.btnRegistrarRecepcionista = new System.Windows.Forms.Button();
            this.btnConsultarPago = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnEntrenadores = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnListaAlumnos = new System.Windows.Forms.Button();
            this.btnListaRecepcionista = new System.Windows.Forms.Button();
            this.btnListaPagos = new System.Windows.Forms.Button();
            this.picMascota = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListaEntrenadores
            // 
            this.btnListaEntrenadores.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnListaEntrenadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaEntrenadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaEntrenadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaEntrenadores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListaEntrenadores.Location = new System.Drawing.Point(402, 374);
            this.btnListaEntrenadores.Name = "btnListaEntrenadores";
            this.btnListaEntrenadores.Size = new System.Drawing.Size(195, 29);
            this.btnListaEntrenadores.TabIndex = 30;
            this.btnListaEntrenadores.Text = "LISTA ENTRENADORES";
            this.btnListaEntrenadores.UseVisualStyleBackColor = false;
            this.btnListaEntrenadores.Click += new System.EventHandler(this.btnListaEntrenadores_Click);
            // 
            // btnRegistrarRecepcionista
            // 
            this.btnRegistrarRecepcionista.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegistrarRecepcionista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarRecepcionista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarRecepcionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarRecepcionista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarRecepcionista.Location = new System.Drawing.Point(201, 409);
            this.btnRegistrarRecepcionista.Name = "btnRegistrarRecepcionista";
            this.btnRegistrarRecepcionista.Size = new System.Drawing.Size(195, 29);
            this.btnRegistrarRecepcionista.TabIndex = 29;
            this.btnRegistrarRecepcionista.Text = "REGISTRAR RECEPCIONISTA";
            this.btnRegistrarRecepcionista.UseVisualStyleBackColor = false;
            this.btnRegistrarRecepcionista.Click += new System.EventHandler(this.btnRegistrarRecepcionista_Click);
            // 
            // btnConsultarPago
            // 
            this.btnConsultarPago.AutoEllipsis = true;
            this.btnConsultarPago.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConsultarPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsultarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultarPago.Location = new System.Drawing.Point(300, 268);
            this.btnConsultarPago.Name = "btnConsultarPago";
            this.btnConsultarPago.Size = new System.Drawing.Size(196, 29);
            this.btnConsultarPago.TabIndex = 28;
            this.btnConsultarPago.Text = "CONSULTAR PAGO";
            this.btnConsultarPago.UseVisualStyleBackColor = false;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(242, 225);
            this.txtDni.Margin = new System.Windows.Forms.Padding(3, 10, 3, 15);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(301, 25);
            this.txtDni.TabIndex = 27;
            this.txtDni.Text = "Ingrese su DNI";
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(236, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 34);
            this.label1.TabIndex = 26;
            this.label1.Text = "Consulte Membresia del Alumno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlumnos.Location = new System.Drawing.Point(201, 339);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(195, 29);
            this.btnAlumnos.TabIndex = 25;
            this.btnAlumnos.Text = "REGISTRAR ALUMNO";
            this.btnAlumnos.UseVisualStyleBackColor = false;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnEntrenadores
            // 
            this.btnEntrenadores.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEntrenadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrenadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrenadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrenadores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEntrenadores.Location = new System.Drawing.Point(201, 374);
            this.btnEntrenadores.Name = "btnEntrenadores";
            this.btnEntrenadores.Size = new System.Drawing.Size(195, 29);
            this.btnEntrenadores.TabIndex = 24;
            this.btnEntrenadores.Text = "REGISTRAR ENTRENADOR";
            this.btnEntrenadores.UseVisualStyleBackColor = false;
            this.btnEntrenadores.Click += new System.EventHandler(this.btnEntrenadores_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.SystemColors.Info;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrarSesion.Location = new System.Drawing.Point(630, 102);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(111, 26);
            this.btnCerrarSesion.TabIndex = 23;
            this.btnCerrarSesion.Text = "CERRAR SESION";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBienvenida.Location = new System.Drawing.Point(230, 102);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(318, 78);
            this.lblBienvenida.TabIndex = 22;
            this.lblBienvenida.Text = "¡Bienvenido a Workout!\r\nAdministrador";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListaAlumnos
            // 
            this.btnListaAlumnos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnListaAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaAlumnos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListaAlumnos.Location = new System.Drawing.Point(402, 339);
            this.btnListaAlumnos.Name = "btnListaAlumnos";
            this.btnListaAlumnos.Size = new System.Drawing.Size(195, 29);
            this.btnListaAlumnos.TabIndex = 33;
            this.btnListaAlumnos.Text = "LISTA ALUMNO";
            this.btnListaAlumnos.UseVisualStyleBackColor = false;
            this.btnListaAlumnos.Click += new System.EventHandler(this.btnListaAlumnos_Click);
            // 
            // btnListaRecepcionista
            // 
            this.btnListaRecepcionista.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnListaRecepcionista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaRecepcionista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaRecepcionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaRecepcionista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListaRecepcionista.Location = new System.Drawing.Point(402, 409);
            this.btnListaRecepcionista.Name = "btnListaRecepcionista";
            this.btnListaRecepcionista.Size = new System.Drawing.Size(195, 29);
            this.btnListaRecepcionista.TabIndex = 34;
            this.btnListaRecepcionista.Text = "LISTA RECEPCIONISTA";
            this.btnListaRecepcionista.UseVisualStyleBackColor = false;
            // 
            // btnListaPagos
            // 
            this.btnListaPagos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnListaPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaPagos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListaPagos.Location = new System.Drawing.Point(301, 444);
            this.btnListaPagos.Name = "btnListaPagos";
            this.btnListaPagos.Size = new System.Drawing.Size(195, 29);
            this.btnListaPagos.TabIndex = 35;
            this.btnListaPagos.Text = "LISTA PAGOS";
            this.btnListaPagos.UseVisualStyleBackColor = false;
            // 
            // picMascota
            // 
            this.picMascota.Image = ((System.Drawing.Image)(resources.GetObject("picMascota.Image")));
            this.picMascota.Location = new System.Drawing.Point(59, 35);
            this.picMascota.Name = "picMascota";
            this.picMascota.Size = new System.Drawing.Size(73, 78);
            this.picMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMascota.TabIndex = 32;
            this.picMascota.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(661, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmInicioAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.btnListaPagos);
            this.Controls.Add(this.btnListaRecepcionista);
            this.Controls.Add(this.btnListaAlumnos);
            this.Controls.Add(this.picMascota);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnListaEntrenadores);
            this.Controls.Add(this.btnRegistrarRecepcionista);
            this.Controls.Add(this.btnConsultarPago);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlumnos);
            this.Controls.Add(this.btnEntrenadores);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "FrmInicioAdm";
            this.Text = "Workout Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMascota;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnListaEntrenadores;
        private System.Windows.Forms.Button btnRegistrarRecepcionista;
        private System.Windows.Forms.Button btnConsultarPago;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnEntrenadores;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnListaAlumnos;
        private System.Windows.Forms.Button btnListaRecepcionista;
        private System.Windows.Forms.Button btnListaPagos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}