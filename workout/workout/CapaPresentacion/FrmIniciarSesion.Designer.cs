namespace workout.CapaPresentacion
{
    partial class FrmIniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIniciarSesion));
            this.picMascota = new System.Windows.Forms.PictureBox();
            this.lblInicioSesion = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtCorreoInicioSes = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // picMascota
            // 
            this.picMascota.Image = ((System.Drawing.Image)(resources.GetObject("picMascota.Image")));
            this.picMascota.Location = new System.Drawing.Point(12, 21);
            this.picMascota.Name = "picMascota";
            this.picMascota.Size = new System.Drawing.Size(73, 78);
            this.picMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMascota.TabIndex = 44;
            this.picMascota.TabStop = false;
            // 
            // lblInicioSesion
            // 
            this.lblInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblInicioSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInicioSesion.Location = new System.Drawing.Point(91, 21);
            this.lblInicioSesion.Name = "lblInicioSesion";
            this.lblInicioSesion.Size = new System.Drawing.Size(318, 78);
            this.lblInicioSesion.TabIndex = 45;
            this.lblInicioSesion.Text = "¡Bienvenido a Workout!\r\nInicie Sesion";
            this.lblInicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciarSesion.Location = new System.Drawing.Point(115, 270);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(179, 29);
            this.btnIniciarSesion.TabIndex = 47;
            this.btnIniciarSesion.Text = "INICIAR SESION";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // txtCorreoInicioSes
            // 
            this.txtCorreoInicioSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.txtCorreoInicioSes.Location = new System.Drawing.Point(64, 160);
            this.txtCorreoInicioSes.Margin = new System.Windows.Forms.Padding(3, 10, 3, 15);
            this.txtCorreoInicioSes.Name = "txtCorreoInicioSes";
            this.txtCorreoInicioSes.Size = new System.Drawing.Size(301, 25);
            this.txtCorreoInicioSes.TabIndex = 46;
            this.txtCorreoInicioSes.Text = "Ingrese su correo";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(64, 210);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 10, 3, 15);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(301, 25);
            this.txtContraseña.TabIndex = 48;
            this.txtContraseña.Text = "Ingrese su contraseña";
            // 
            // FrmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 392);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtCorreoInicioSes);
            this.Controls.Add(this.lblInicioSesion);
            this.Controls.Add(this.picMascota);
            this.Name = "FrmIniciarSesion";
            this.Text = "FrmIniciarSesion";
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMascota;
        private System.Windows.Forms.Label lblInicioSesion;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.TextBox txtCorreoInicioSes;
        private System.Windows.Forms.TextBox txtContraseña;
    }
}