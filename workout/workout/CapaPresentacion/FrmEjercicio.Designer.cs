namespace workout.CapaPresentacion
{
    partial class FrmEjercicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEjercicio));
            this.picMascota = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescanso = new System.Windows.Forms.Label();
            this.lblRepeticiones = new System.Windows.Forms.Label();
            this.llblSerie = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // picMascota
            // 
            this.picMascota.Image = ((System.Drawing.Image)(resources.GetObject("picMascota.Image")));
            this.picMascota.Location = new System.Drawing.Point(377, 25);
            this.picMascota.Name = "picMascota";
            this.picMascota.Size = new System.Drawing.Size(73, 78);
            this.picMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMascota.TabIndex = 30;
            this.picMascota.TabStop = false;
            this.picMascota.Click += new System.EventHandler(this.picMascota_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(167, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(117, 31);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Ejercicio";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblDescanso
            // 
            this.lblDescanso.AutoSize = true;
            this.lblDescanso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescanso.Location = new System.Drawing.Point(21, 270);
            this.lblDescanso.Name = "lblDescanso";
            this.lblDescanso.Size = new System.Drawing.Size(100, 25);
            this.lblDescanso.TabIndex = 31;
            this.lblDescanso.Text = "Descanso";
            // 
            // lblRepeticiones
            // 
            this.lblRepeticiones.AutoSize = true;
            this.lblRepeticiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeticiones.Location = new System.Drawing.Point(21, 207);
            this.lblRepeticiones.Name = "lblRepeticiones";
            this.lblRepeticiones.Size = new System.Drawing.Size(124, 25);
            this.lblRepeticiones.TabIndex = 32;
            this.lblRepeticiones.Text = "Repeticiones";
            // 
            // llblSerie
            // 
            this.llblSerie.AutoSize = true;
            this.llblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblSerie.Location = new System.Drawing.Point(22, 152);
            this.llblSerie.Name = "llblSerie";
            this.llblSerie.Size = new System.Drawing.Size(58, 25);
            this.llblSerie.TabIndex = 33;
            this.llblSerie.Text = "Serie";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(22, 92);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(114, 25);
            this.lblDescripcion.TabIndex = 34;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // FrmEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 415);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.llblSerie);
            this.Controls.Add(this.lblRepeticiones);
            this.Controls.Add(this.lblDescanso);
            this.Controls.Add(this.picMascota);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmEjercicio";
            this.Text = "Ejercicio";
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMascota;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescanso;
        private System.Windows.Forms.Label lblRepeticiones;
        private System.Windows.Forms.Label llblSerie;
        private System.Windows.Forms.Label lblDescripcion;
    }
}