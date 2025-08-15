namespace workout.CapaPresentacion
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.picMascota = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnMembresias = new System.Windows.Forms.Button();
            this.btnEntrenadores = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBienvenida.Location = new System.Drawing.Point(238, 27);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(318, 55);
            this.lblBienvenida.TabIndex = 2;
            this.lblBienvenida.Text = "¡Bienvenido a Workout!";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picMascota
            // 
            this.picMascota.Image = ((System.Drawing.Image)(resources.GetObject("picMascota.Image")));
            this.picMascota.Location = new System.Drawing.Point(27, 27);
            this.picMascota.Name = "picMascota";
            this.picMascota.Size = new System.Drawing.Size(73, 78);
            this.picMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMascota.TabIndex = 10;
            this.picMascota.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrarSesion.Location = new System.Drawing.Point(653, 46);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(135, 29);
            this.btnCerrarSesion.TabIndex = 11;
            this.btnCerrarSesion.Text = "CERRAR SESION";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // btnMembresias
            // 
            this.btnMembresias.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMembresias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembresias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMembresias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembresias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMembresias.Location = new System.Drawing.Point(339, 114);
            this.btnMembresias.Name = "btnMembresias";
            this.btnMembresias.Size = new System.Drawing.Size(135, 29);
            this.btnMembresias.TabIndex = 12;
            this.btnMembresias.Text = "MEMBRESIAS";
            this.btnMembresias.UseVisualStyleBackColor = false;
            // 
            // btnEntrenadores
            // 
            this.btnEntrenadores.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEntrenadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrenadores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrenadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrenadores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEntrenadores.Location = new System.Drawing.Point(542, 114);
            this.btnEntrenadores.Name = "btnEntrenadores";
            this.btnEntrenadores.Size = new System.Drawing.Size(135, 29);
            this.btnEntrenadores.TabIndex = 13;
            this.btnEntrenadores.Text = "ENTRENADORES";
            this.btnEntrenadores.UseVisualStyleBackColor = false;
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlumnos.Location = new System.Drawing.Point(131, 114);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(135, 29);
            this.btnAlumnos.TabIndex = 14;
            this.btnAlumnos.Text = "ALUMNOS";
            this.btnAlumnos.UseVisualStyleBackColor = false;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlumnos);
            this.Controls.Add(this.btnEntrenadores);
            this.Controls.Add(this.btnMembresias);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.picMascota);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "FrmInicio";
            this.Text = "Workout";
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.PictureBox picMascota;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnMembresias;
        private System.Windows.Forms.Button btnEntrenadores;
        private System.Windows.Forms.Button btnAlumnos;
    }
}