namespace workout.CapaPresentacion
{
    partial class FrmReporteEstadistica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteEstadistica));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.picMascota = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNuevosAlum = new System.Windows.Forms.Label();
            this.lblTotalRecaudado = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.blblDesde = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblAltas = new System.Windows.Forms.Label();
            this.lblBajas = new System.Windows.Forms.Label();
            this.chartPagos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPagos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMascota
            // 
            this.picMascota.Image = ((System.Drawing.Image)(resources.GetObject("picMascota.Image")));
            this.picMascota.Location = new System.Drawing.Point(75, 21);
            this.picMascota.Name = "picMascota";
            this.picMascota.Size = new System.Drawing.Size(73, 78);
            this.picMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMascota.TabIndex = 36;
            this.picMascota.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(338, 51);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(244, 20);
            this.lblTitulo.TabIndex = 37;
            this.lblTitulo.Text = "REPORTE Y ESTADISTICAS";
            // 
            // lblNuevosAlum
            // 
            this.lblNuevosAlum.AutoSize = true;
            this.lblNuevosAlum.BackColor = System.Drawing.SystemColors.Control;
            this.lblNuevosAlum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevosAlum.Location = new System.Drawing.Point(21, 71);
            this.lblNuevosAlum.Name = "lblNuevosAlum";
            this.lblNuevosAlum.Size = new System.Drawing.Size(111, 16);
            this.lblNuevosAlum.TabIndex = 38;
            this.lblNuevosAlum.Text = "Nuevos alumnos:\r\n";
            this.lblNuevosAlum.Click += new System.EventHandler(this.lblNuevosAlum_Click);
            // 
            // lblTotalRecaudado
            // 
            this.lblTotalRecaudado.AutoSize = true;
            this.lblTotalRecaudado.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalRecaudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecaudado.Location = new System.Drawing.Point(21, 22);
            this.lblTotalRecaudado.Name = "lblTotalRecaudado";
            this.lblTotalRecaudado.Size = new System.Drawing.Size(126, 16);
            this.lblTotalRecaudado.TabIndex = 39;
            this.lblTotalRecaudado.Text = "Total Recaudado: $";
            this.lblTotalRecaudado.Click += new System.EventHandler(this.lblTotalRecaudado_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(509, 105);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(95, 20);
            this.dtpHasta.TabIndex = 73;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(354, 105);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(104, 20);
            this.dtpDesde.TabIndex = 72;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(464, 109);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(43, 13);
            this.lblHasta.TabIndex = 71;
            this.lblHasta.Text = "HASTA";
            // 
            // blblDesde
            // 
            this.blblDesde.AutoSize = true;
            this.blblDesde.Location = new System.Drawing.Point(304, 109);
            this.blblDesde.Name = "blblDesde";
            this.blblDesde.Size = new System.Drawing.Size(44, 13);
            this.blblDesde.TabIndex = 70;
            this.blblDesde.Text = "DESDE";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerar.Location = new System.Drawing.Point(664, 95);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(97, 40);
            this.btnGenerar.TabIndex = 74;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblAltas
            // 
            this.lblAltas.AutoSize = true;
            this.lblAltas.BackColor = System.Drawing.SystemColors.Control;
            this.lblAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltas.Location = new System.Drawing.Point(21, 114);
            this.lblAltas.Name = "lblAltas";
            this.lblAltas.Size = new System.Drawing.Size(40, 16);
            this.lblAltas.TabIndex = 75;
            this.lblAltas.Text = "Altas:";
            this.lblAltas.Click += new System.EventHandler(this.lblAltas_Click);
            // 
            // lblBajas
            // 
            this.lblBajas.AutoSize = true;
            this.lblBajas.BackColor = System.Drawing.SystemColors.Control;
            this.lblBajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBajas.Location = new System.Drawing.Point(21, 149);
            this.lblBajas.Name = "lblBajas";
            this.lblBajas.Size = new System.Drawing.Size(45, 16);
            this.lblBajas.TabIndex = 76;
            this.lblBajas.Text = "Bajas:";
            this.lblBajas.Click += new System.EventHandler(this.lblBajas_Click);
            // 
            // chartPagos
            // 
            this.chartPagos.BackColor = System.Drawing.SystemColors.Control;
            this.chartPagos.BorderSkin.BackColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.chartPagos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPagos.Legends.Add(legend1);
            this.chartPagos.Location = new System.Drawing.Point(364, 158);
            this.chartPagos.Name = "chartPagos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPagos.Series.Add(series1);
            this.chartPagos.Size = new System.Drawing.Size(460, 243);
            this.chartPagos.TabIndex = 77;
            this.chartPagos.Text = "Recaudación diaria por membresías entre";
            this.chartPagos.Click += new System.EventHandler(this.chartPagos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblBajas);
            this.panel1.Controls.Add(this.lblAltas);
            this.panel1.Controls.Add(this.lblTotalRecaudado);
            this.panel1.Controls.Add(this.lblNuevosAlum);
            this.panel1.Location = new System.Drawing.Point(37, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 187);
            this.panel1.TabIndex = 78;
            // 
            // FrmReporteEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartPagos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.blblDesde);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picMascota);
            this.Name = "FrmReporteEstadistica";
            this.Text = "FrmReporteEstadistica";
            this.Load += new System.EventHandler(this.FrmReporteEstadistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPagos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMascota;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNuevosAlum;
        private System.Windows.Forms.Label lblTotalRecaudado;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label blblDesde;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblAltas;
        private System.Windows.Forms.Label lblBajas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPagos;
        private System.Windows.Forms.Panel panel1;
    }
}