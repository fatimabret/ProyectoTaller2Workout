namespace workout.CapaPresentacion
{
    partial class FrmListEntrenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListEntrenador));
            this.label1 = new System.Windows.Forms.Label();
            this.listEntrenadores = new System.Windows.Forms.DataGridView();
            this.picMascota = new System.Windows.Forms.PictureBox();
            this.clmEntrenador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmhorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listEntrenadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "LISTA DE ENTRENADORES";
            // 
            // listEntrenadores
            // 
            this.listEntrenadores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.listEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listEntrenadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmEntrenador,
            this.clmdias,
            this.clmhorario,
            this.clmCategoria,
            this.clmCupo});
            this.listEntrenadores.Location = new System.Drawing.Point(26, 127);
            this.listEntrenadores.Name = "listEntrenadores";
            this.listEntrenadores.RowHeadersVisible = false;
            this.listEntrenadores.Size = new System.Drawing.Size(554, 362);
            this.listEntrenadores.TabIndex = 0;
            // 
            // picMascota
            // 
            this.picMascota.Image = ((System.Drawing.Image)(resources.GetObject("picMascota.Image")));
            this.picMascota.Location = new System.Drawing.Point(82, 7);
            this.picMascota.Name = "picMascota";
            this.picMascota.Size = new System.Drawing.Size(73, 78);
            this.picMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMascota.TabIndex = 25;
            this.picMascota.TabStop = false;
            // 
            // clmEntrenador
            // 
            this.clmEntrenador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmEntrenador.Frozen = true;
            this.clmEntrenador.HeaderText = "ENTRENADOR";
            this.clmEntrenador.Name = "clmEntrenador";
            this.clmEntrenador.Width = 119;
            // 
            // clmdias
            // 
            this.clmdias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmdias.Frozen = true;
            this.clmdias.HeaderText = "DIAS";
            this.clmdias.Name = "clmdias";
            this.clmdias.ReadOnly = true;
            this.clmdias.Width = 119;
            // 
            // clmhorario
            // 
            this.clmhorario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmhorario.Frozen = true;
            this.clmhorario.HeaderText = "HORARIOS";
            this.clmhorario.Name = "clmhorario";
            this.clmhorario.ReadOnly = true;
            this.clmhorario.Width = 119;
            // 
            // clmCategoria
            // 
            this.clmCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmCategoria.Frozen = true;
            this.clmCategoria.HeaderText = "CATEGORIA";
            this.clmCategoria.Name = "clmCategoria";
            this.clmCategoria.ReadOnly = true;
            // 
            // clmCupo
            // 
            this.clmCupo.Frozen = true;
            this.clmCupo.HeaderText = "CUPO";
            this.clmCupo.Name = "clmCupo";
            // 
            // FrmListEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 589);
            this.Controls.Add(this.picMascota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listEntrenadores);
            this.Name = "FrmListEntrenador";
            this.Text = "Lista Entrenadores";
            ((System.ComponentModel.ISupportInitialize)(this.listEntrenadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMascota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listEntrenadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEntrenador;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdias;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmhorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCupo;
    }
}