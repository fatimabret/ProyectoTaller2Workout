namespace workout.CapaPresentacion
{
    partial class FrmListPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListPago));
            this.label1 = new System.Windows.Forms.Label();
            this.listAlumnos = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENCIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picMascota = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.listAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "LISTA DE PAGOS";
            // 
            // listAlumnos
            // 
            this.listAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.listAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Column2,
            this.PAGO,
            this.VENCIMIENTO,
            this.Column1});
            this.listAlumnos.Location = new System.Drawing.Point(58, 106);
            this.listAlumnos.Name = "listAlumnos";
            this.listAlumnos.RowHeadersVisible = false;
            this.listAlumnos.Size = new System.Drawing.Size(479, 362);
            this.listAlumnos.TabIndex = 23;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOMB APELL";
            this.Column2.Name = "Column2";
            // 
            // PAGO
            // 
            this.PAGO.HeaderText = "PAGO";
            this.PAGO.Name = "PAGO";
            this.PAGO.ReadOnly = true;
            // 
            // VENCIMIENTO
            // 
            this.VENCIMIENTO.HeaderText = "VENCIMIENTO";
            this.VENCIMIENTO.Name = "VENCIMIENTO";
            this.VENCIMIENTO.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ENTRENADOR";
            this.Column1.Name = "Column1";
            // 
            // picMascota
            // 
            this.picMascota.Image = ((System.Drawing.Image)(resources.GetObject("picMascota.Image")));
            this.picMascota.Location = new System.Drawing.Point(95, 12);
            this.picMascota.Name = "picMascota";
            this.picMascota.Size = new System.Drawing.Size(73, 78);
            this.picMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMascota.TabIndex = 25;
            this.picMascota.TabStop = false;
            // 
            // FrmListPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 522);
            this.Controls.Add(this.picMascota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAlumnos);
            this.Name = "FrmListPago";
            this.Text = "FrmListPago";
            ((System.ComponentModel.ISupportInitialize)(this.listAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMascota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENCIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}