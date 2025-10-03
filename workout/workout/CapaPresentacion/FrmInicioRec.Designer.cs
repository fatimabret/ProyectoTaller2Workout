namespace workout.CapaPresentacion
{
    partial class FrmInicioRec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioRec));
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.btnRegistrarAlumno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnConsultarMembresia = new System.Windows.Forms.Button();
            this.btnListarAlumnos = new System.Windows.Forms.Button();
            this.btnListarEntrenadores = new System.Windows.Forms.Button();
            this.picMascota = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRenovarMembresia = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBienvenida.Location = new System.Drawing.Point(238, 90);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(318, 78);
            this.lblBienvenida.TabIndex = 2;
            this.lblBienvenida.Text = "¡Bienvenido a Workout!\r\nRecepcionista";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBienvenida.Click += new System.EventHandler(this.lblBienvenida_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.SystemColors.Info;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrarSesion.Location = new System.Drawing.Point(638, 90);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(111, 26);
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.Text = "CERRAR SESION";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(424, 328);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(179, 29);
            this.btnRegistrarUsuario.TabIndex = 13;
            this.btnRegistrarUsuario.Text = "REGISTRAR USUARIO";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = false;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegistrarAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAlumno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(225, 328);
            this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            this.btnRegistrarAlumno.Size = new System.Drawing.Size(179, 29);
            this.btnRegistrarAlumno.TabIndex = 14;
            this.btnRegistrarAlumno.Text = "REGISTRAR ALUMNO";
            this.btnRegistrarAlumno.UseVisualStyleBackColor = false;
            this.btnRegistrarAlumno.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(244, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ingrese DNI del Alumno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(250, 213);
            this.txtDni.Margin = new System.Windows.Forms.Padding(3, 10, 3, 15);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(301, 25);
            this.txtDni.TabIndex = 16;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // btnConsultarMembresia
            // 
            this.btnConsultarMembresia.AutoEllipsis = true;
            this.btnConsultarMembresia.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConsultarMembresia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsultarMembresia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarMembresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarMembresia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultarMembresia.Location = new System.Drawing.Point(225, 256);
            this.btnConsultarMembresia.Name = "btnConsultarMembresia";
            this.btnConsultarMembresia.Size = new System.Drawing.Size(179, 29);
            this.btnConsultarMembresia.TabIndex = 17;
            this.btnConsultarMembresia.Text = "CONSULTAR MEMBRESIA";
            this.btnConsultarMembresia.UseVisualStyleBackColor = false;
            this.btnConsultarMembresia.Click += new System.EventHandler(this.btnConsultarMembresia_Click);
            // 
            // btnListarAlumnos
            // 
            this.btnListarAlumnos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnListarAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarAlumnos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListarAlumnos.Location = new System.Drawing.Point(225, 363);
            this.btnListarAlumnos.Name = "btnListarAlumnos";
            this.btnListarAlumnos.Size = new System.Drawing.Size(179, 29);
            this.btnListarAlumnos.TabIndex = 18;
            this.btnListarAlumnos.Text = "LISTA ALUMNOS";
            this.btnListarAlumnos.UseVisualStyleBackColor = false;
            this.btnListarAlumnos.Click += new System.EventHandler(this.btnListarAlumnos_Click);
            // 
            // btnListarEntrenadores
            // 
            this.btnListarEntrenadores.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnListarEntrenadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarEntrenadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarEntrenadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarEntrenadores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListarEntrenadores.Location = new System.Drawing.Point(424, 363);
            this.btnListarEntrenadores.Name = "btnListarEntrenadores";
            this.btnListarEntrenadores.Size = new System.Drawing.Size(179, 29);
            this.btnListarEntrenadores.TabIndex = 19;
            this.btnListarEntrenadores.Text = "LISTA ENTRENADORES";
            this.btnListarEntrenadores.UseVisualStyleBackColor = false;
            this.btnListarEntrenadores.Click += new System.EventHandler(this.btnListarEntrenadores_Click);
            // 
            // picMascota
            // 
            this.picMascota.Image = ((System.Drawing.Image)(resources.GetObject("picMascota.Image")));
            this.picMascota.Location = new System.Drawing.Point(67, 23);
            this.picMascota.Name = "picMascota";
            this.picMascota.Size = new System.Drawing.Size(73, 78);
            this.picMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMascota.TabIndex = 21;
            this.picMascota.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(669, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnRenovarMembresia
            // 
            this.btnRenovarMembresia.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRenovarMembresia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenovarMembresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenovarMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenovarMembresia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRenovarMembresia.Location = new System.Drawing.Point(424, 256);
            this.btnRenovarMembresia.Name = "btnRenovarMembresia";
            this.btnRenovarMembresia.Size = new System.Drawing.Size(179, 29);
            this.btnRenovarMembresia.TabIndex = 22;
            this.btnRenovarMembresia.Text = "RENOVAR MEMBRESIA";
            this.btnRenovarMembresia.UseVisualStyleBackColor = false;
            this.btnRenovarMembresia.Click += new System.EventHandler(this.btnRenovarMembresia_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmInicioRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.btnRenovarMembresia);
            this.Controls.Add(this.picMascota);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnListarEntrenadores);
            this.Controls.Add(this.btnListarAlumnos);
            this.Controls.Add(this.btnConsultarMembresia);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarAlumno);
            this.Controls.Add(this.btnRegistrarUsuario);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "FrmInicioRec";
            this.Text = "Workout Recepcionista";
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.Button btnRegistrarAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnConsultarMembresia;
        private System.Windows.Forms.Button btnListarAlumnos;
        private System.Windows.Forms.Button btnListarEntrenadores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picMascota;
        private System.Windows.Forms.Button btnRenovarMembresia;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}