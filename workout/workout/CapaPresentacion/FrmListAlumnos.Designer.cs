namespace workout.CapaPresentacion
{
    partial class FrmListAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListAlumnos));
            this.listAlumnos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.picMascota = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.listAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // listAlumnos
            // 
            this.listAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.listAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listAlumnos.Location = new System.Drawing.Point(29, 115);
            this.listAlumnos.Name = "listAlumnos";
            this.listAlumnos.RowHeadersVisible = false;
            this.listAlumnos.Size = new System.Drawing.Size(479, 362);
            this.listAlumnos.TabIndex = 0;
            this.listAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listAlumnos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTA DE ALUMNOS";
            // 
            // picMascota
            // 
            this.picMascota.Image = ((System.Drawing.Image)(resources.GetObject("picMascota.Image")));
            this.picMascota.Location = new System.Drawing.Point(66, 21);
            this.picMascota.Name = "picMascota";
            this.picMascota.Size = new System.Drawing.Size(73, 78);
            this.picMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMascota.TabIndex = 22;
            this.picMascota.TabStop = false;
            // 
            // FrmListAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 533);
            this.Controls.Add(this.picMascota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAlumnos);
            this.Name = "FrmListAlumnos";
            this.Text = "Lista Alumnos";
            this.Load += new System.EventHandler(this.FrmListAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picMascota;
    }
}