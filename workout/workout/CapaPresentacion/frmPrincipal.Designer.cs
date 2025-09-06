namespace workout
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblSubtituloBienvenida = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnConsultarMembresia = new System.Windows.Forms.Button();
            this.btnConsultarRutina = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.picMascota = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBienvenida.Location = new System.Drawing.Point(256, 100);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(318, 55);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "¡Bienvenido a Workout!";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBienvenida.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSubtituloBienvenida
            // 
            this.lblSubtituloBienvenida.AutoSize = true;
            this.lblSubtituloBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtituloBienvenida.Location = new System.Drawing.Point(310, 155);
            this.lblSubtituloBienvenida.Name = "lblSubtituloBienvenida";
            this.lblSubtituloBienvenida.Size = new System.Drawing.Size(202, 15);
            this.lblSubtituloBienvenida.TabIndex = 2;
            this.lblSubtituloBienvenida.Text = "Consulte su Membresia o su Rutina";
            this.lblSubtituloBienvenida.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(262, 197);
            this.txtDni.Margin = new System.Windows.Forms.Padding(3, 10, 3, 15);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(301, 25);
            this.txtDni.TabIndex = 3;
            this.txtDni.Text = "Ingrese su DNI";
            this.txtDni.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.btnConsultarMembresia.Location = new System.Drawing.Point(313, 250);
            this.btnConsultarMembresia.Name = "btnConsultarMembresia";
            this.btnConsultarMembresia.Size = new System.Drawing.Size(196, 29);
            this.btnConsultarMembresia.TabIndex = 4;
            this.btnConsultarMembresia.Text = "CONSULTAR MEMBRESIA";
            this.btnConsultarMembresia.UseVisualStyleBackColor = false;
            this.btnConsultarMembresia.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsultarRutina
            // 
            this.btnConsultarRutina.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConsultarRutina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarRutina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarRutina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarRutina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultarRutina.Location = new System.Drawing.Point(313, 285);
            this.btnConsultarRutina.Name = "btnConsultarRutina";
            this.btnConsultarRutina.Size = new System.Drawing.Size(196, 29);
            this.btnConsultarRutina.TabIndex = 5;
            this.btnConsultarRutina.Text = "CONSULTAR RUTINA";
            this.btnConsultarRutina.UseVisualStyleBackColor = false;
            this.btnConsultarRutina.Click += new System.EventHandler(this.btnConsultarRutina_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Eres Administrador o Entrenador?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(466, 381);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(84, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Iniciar Sesion";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciarSesion.Location = new System.Drawing.Point(603, 39);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(135, 29);
            this.btnIniciarSesion.TabIndex = 8;
            this.btnIniciarSesion.Text = "INICIAR SESION";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.button3_Click);
            // 
            // picMascota
            // 
            this.picMascota.Image = ((System.Drawing.Image)(resources.GetObject("picMascota.Image")));
            this.picMascota.Location = new System.Drawing.Point(68, 21);
            this.picMascota.Name = "picMascota";
            this.picMascota.Size = new System.Drawing.Size(73, 78);
            this.picMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMascota.TabIndex = 9;
            this.picMascota.TabStop = false;
            this.picMascota.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picMascota);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConsultarRutina);
            this.Controls.Add(this.btnConsultarMembresia);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblSubtituloBienvenida);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "FrmPrincipal";
            this.Text = "Workout";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblSubtituloBienvenida;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnConsultarMembresia;
        private System.Windows.Forms.Button btnConsultarRutina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.PictureBox picMascota;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}

