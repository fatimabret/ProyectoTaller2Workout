namespace workout.CapaPresentacion
{
    partial class FrmInicioEntr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioEntr));
            this.btnConslRutina = new System.Windows.Forms.Button();
            this.btnAlumnosList = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRutina = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.picMascota = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConslRutina
            // 
            this.btnConslRutina.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConslRutina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConslRutina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConslRutina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConslRutina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConslRutina.Location = new System.Drawing.Point(205, 270);
            this.btnConslRutina.Name = "btnConslRutina";
            this.btnConslRutina.Size = new System.Drawing.Size(179, 29);
            this.btnConslRutina.TabIndex = 41;
            this.btnConslRutina.Text = "CONSULTAR RUTINA";
            this.btnConslRutina.UseVisualStyleBackColor = false;
            this.btnConslRutina.Click += new System.EventHandler(this.ConslRutina_Click);
            // 
            // btnAlumnosList
            // 
            this.btnAlumnosList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAlumnosList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlumnosList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnosList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnosList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlumnosList.Location = new System.Drawing.Point(205, 351);
            this.btnAlumnosList.Name = "btnAlumnosList";
            this.btnAlumnosList.Size = new System.Drawing.Size(375, 29);
            this.btnAlumnosList.TabIndex = 40;
            this.btnAlumnosList.Text = "LISTA ALUMNOS";
            this.btnAlumnosList.UseVisualStyleBackColor = false;
            this.btnAlumnosList.Click += new System.EventHandler(this.AlumnosList_Click);
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(237, 227);
            this.txtDni.Margin = new System.Windows.Forms.Padding(3, 10, 3, 15);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(301, 25);
            this.txtDni.TabIndex = 38;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(231, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 34);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ingrese DNI del Alumno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRutina
            // 
            this.btnRutina.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRutina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRutina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRutina.Location = new System.Drawing.Point(401, 270);
            this.btnRutina.Name = "btnRutina";
            this.btnRutina.Size = new System.Drawing.Size(179, 29);
            this.btnRutina.TabIndex = 35;
            this.btnRutina.Text = "REGISTRAR RUTINA";
            this.btnRutina.UseVisualStyleBackColor = false;
            this.btnRutina.Click += new System.EventHandler(this.btnRutinas_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.SystemColors.Info;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrarSesion.Location = new System.Drawing.Point(629, 104);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(111, 26);
            this.btnCerrarSesion.TabIndex = 34;
            this.btnCerrarSesion.Text = "CERRAR SESION";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBienvenida.Location = new System.Drawing.Point(225, 104);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(318, 78);
            this.lblBienvenida.TabIndex = 33;
            this.lblBienvenida.Text = "¡Bienvenido a Workout!\r\nEntrenador";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picMascota
            // 
            this.picMascota.Image = ((System.Drawing.Image)(resources.GetObject("picMascota.Image")));
            this.picMascota.Location = new System.Drawing.Point(54, 37);
            this.picMascota.Name = "picMascota";
            this.picMascota.Size = new System.Drawing.Size(73, 78);
            this.picMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMascota.TabIndex = 43;
            this.picMascota.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(656, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmInicioEntr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 412);
            this.Controls.Add(this.picMascota);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConslRutina);
            this.Controls.Add(this.btnAlumnosList);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRutina);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "FrmInicioEntr";
            this.Text = "Workout Entrenador";
            this.Load += new System.EventHandler(this.FrmInicioEntr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMascota;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConslRutina;
        private System.Windows.Forms.Button btnAlumnosList;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRutina;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}