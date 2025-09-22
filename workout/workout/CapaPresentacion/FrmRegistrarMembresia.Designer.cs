namespace workout.CapaPresentacion
{
    partial class FrmRegistrarMembresia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarMembresia));
            this.picMascota = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMetodoPago = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // picMascota
            // 
            this.picMascota.Image = ((System.Drawing.Image)(resources.GetObject("picMascota.Image")));
            this.picMascota.Location = new System.Drawing.Point(59, 25);
            this.picMascota.Name = "picMascota";
            this.picMascota.Size = new System.Drawing.Size(73, 78);
            this.picMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMascota.TabIndex = 29;
            this.picMascota.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoEllipsis = true;
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(111, 229);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(196, 29);
            this.btnRegistrar.TabIndex = 27;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(68, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 34);
            this.label1.TabIndex = 25;
            this.label1.Text = "Seleccione el metodo de pago a abonar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.FormattingEnabled = true;
            this.cbMetodoPago.Location = new System.Drawing.Point(60, 181);
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.Size = new System.Drawing.Size(310, 21);
            this.cbMetodoPago.TabIndex = 30;
            this.cbMetodoPago.SelectedIndexChanged += new System.EventHandler(this.cbMetodoPago_SelectedIndexChanged);
            // 
            // txtMonto
            // 
            this.txtMonto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonto.Location = new System.Drawing.Point(178, 83);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(154, 20);
            this.txtMonto.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(174, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 34);
            this.label2.TabIndex = 32;
            this.label2.Text = "Costo de Membresia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmRegistrarMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 296);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.cbMetodoPago);
            this.Controls.Add(this.picMascota);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrarMembresia";
            this.Text = "FrmRegistrarMembresia";
            this.Load += new System.EventHandler(this.FrmRegistrarMembresia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picMascota;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMetodoPago;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label2;
    }
}