namespace workout.CapaPresentacion
{
    partial class FrmModificarEntrenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarEntrenador));
            this.picMascota = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDetalles = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbHorario_disp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDias_disp = new System.Windows.Forms.ComboBox();
            this.lblCupo = new System.Windows.Forms.Label();
            this.hsCupo = new System.Windows.Forms.HScrollBar();
            this.lblCupoVal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // picMascota
            // 
            this.picMascota.Image = ((System.Drawing.Image)(resources.GetObject("picMascota.Image")));
            this.picMascota.Location = new System.Drawing.Point(46, 14);
            this.picMascota.Name = "picMascota";
            this.picMascota.Size = new System.Drawing.Size(73, 78);
            this.picMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMascota.TabIndex = 98;
            this.picMascota.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(177, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(225, 25);
            this.lblTitulo.TabIndex = 97;
            this.lblTitulo.Text = "Modificacion de Datos";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(128, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(323, 31);
            this.label7.TabIndex = 113;
            this.label7.Text = "Categoria";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDetalles
            // 
            this.cmbDetalles.FormattingEnabled = true;
            this.cmbDetalles.Location = new System.Drawing.Point(128, 266);
            this.cmbDetalles.Name = "cmbDetalles";
            this.cmbDetalles.Size = new System.Drawing.Size(323, 21);
            this.cmbDetalles.TabIndex = 112;
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
            this.btnModificar.Location = new System.Drawing.Point(193, 382);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(196, 29);
            this.btnModificar.TabIndex = 111;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(128, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 31);
            this.label4.TabIndex = 118;
            this.label4.Text = "Horarios Disponibles";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbHorario_disp
            // 
            this.cmbHorario_disp.FormattingEnabled = true;
            this.cmbHorario_disp.Location = new System.Drawing.Point(128, 198);
            this.cmbHorario_disp.Name = "cmbHorario_disp";
            this.cmbHorario_disp.Size = new System.Drawing.Size(323, 21);
            this.cmbHorario_disp.TabIndex = 117;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(128, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 31);
            this.label5.TabIndex = 120;
            this.label5.Text = "Días Disponibles";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDias_disp
            // 
            this.cmbDias_disp.FormattingEnabled = true;
            this.cmbDias_disp.Location = new System.Drawing.Point(128, 130);
            this.cmbDias_disp.Name = "cmbDias_disp";
            this.cmbDias_disp.Size = new System.Drawing.Size(323, 21);
            this.cmbDias_disp.TabIndex = 119;
            // 
            // lblCupo
            // 
            this.lblCupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCupo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCupo.Location = new System.Drawing.Point(231, 315);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(45, 25);
            this.lblCupo.TabIndex = 121;
            this.lblCupo.Text = "Cupo";
            this.lblCupo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsCupo
            // 
            this.hsCupo.Location = new System.Drawing.Point(259, 340);
            this.hsCupo.Maximum = 15;
            this.hsCupo.Name = "hsCupo";
            this.hsCupo.Size = new System.Drawing.Size(80, 17);
            this.hsCupo.TabIndex = 123;
            this.hsCupo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsCupo_Scroll);
            // 
            // lblCupoVal
            // 
            this.lblCupoVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCupoVal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCupoVal.Location = new System.Drawing.Point(272, 315);
            this.lblCupoVal.Name = "lblCupoVal";
            this.lblCupoVal.Size = new System.Drawing.Size(45, 25);
            this.lblCupoVal.TabIndex = 124;
            this.lblCupoVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmModificarEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 444);
            this.Controls.Add(this.lblCupoVal);
            this.Controls.Add(this.hsCupo);
            this.Controls.Add(this.lblCupo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDias_disp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbHorario_disp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbDetalles);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.picMascota);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmModificarEntrenador";
            this.Text = "Modificar Datos Entrenador";
            this.Load += new System.EventHandler(this.FrmModificarEntrenador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picMascota;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDetalles;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbHorario_disp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDias_disp;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.HScrollBar hsCupo;
        private System.Windows.Forms.Label lblCupoVal;
    }
}