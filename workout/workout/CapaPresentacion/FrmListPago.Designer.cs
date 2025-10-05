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
            this.listPagos = new System.Windows.Forms.DataGridView();
            this.picMascota = new System.Windows.Forms.PictureBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscador = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.blblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.listPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "LISTA DE PAGOS";
            // 
            // listPagos
            // 
            this.listPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listPagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.listPagos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPagos.Location = new System.Drawing.Point(46, 210);
            this.listPagos.Name = "listPagos";
            this.listPagos.RowHeadersVisible = false;
            this.listPagos.Size = new System.Drawing.Size(553, 362);
            this.listPagos.TabIndex = 23;
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
            // txtBuscador
            // 
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.txtBuscador.Location = new System.Drawing.Point(144, 124);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(3, 10, 3, 15);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(339, 25);
            this.txtBuscador.TabIndex = 51;
            this.txtBuscador.Text = "Ingrese el DNI";
            this.txtBuscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscador_KeyPress);
            // 
            // btnBuscador
            // 
            this.btnBuscador.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscador.Location = new System.Drawing.Point(489, 119);
            this.btnBuscador.Name = "btnBuscador";
            this.btnBuscador.Size = new System.Drawing.Size(112, 37);
            this.btnBuscador.TabIndex = 50;
            this.btnBuscador.Text = "Buscar";
            this.btnBuscador.UseVisualStyleBackColor = false;
            this.btnBuscador.Click += new System.EventHandler(this.btnBuscador_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecargar.Image = global::workout.Properties.Resources.rec;
            this.btnRecargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecargar.Location = new System.Drawing.Point(65, 125);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(73, 25);
            this.btnRecargar.TabIndex = 61;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // blblDesde
            // 
            this.blblDesde.AutoSize = true;
            this.blblDesde.Location = new System.Drawing.Point(45, 183);
            this.blblDesde.Name = "blblDesde";
            this.blblDesde.Size = new System.Drawing.Size(44, 13);
            this.blblDesde.TabIndex = 63;
            this.blblDesde.Text = "DESDE";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(250, 183);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(43, 13);
            this.lblHasta.TabIndex = 65;
            this.lblHasta.Text = "HASTA";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(489, 175);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(94, 21);
            this.cmbEstado.TabIndex = 66;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(432, 184);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 13);
            this.lblEstado.TabIndex = 67;
            this.lblEstado.Text = "ESTADO";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(95, 177);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(134, 20);
            this.dtpDesde.TabIndex = 68;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(299, 176);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(118, 20);
            this.dtpHasta.TabIndex = 69;
            // 
            // FrmListPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 618);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.blblDesde);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.btnBuscador);
            this.Controls.Add(this.picMascota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPagos);
            this.Name = "FrmListPago";
            this.Text = "FrmListPago";
            this.Load += new System.EventHandler(this.FrmListPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMascota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listPagos;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Button btnBuscador;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Label blblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
    }
}