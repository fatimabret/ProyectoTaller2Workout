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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscador = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picMascota = new System.Windows.Forms.PictureBox();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.btnComprobante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // listAlumnos
            // 
            this.listAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.listAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listAlumnos.Location = new System.Drawing.Point(38, 187);
            this.listAlumnos.Name = "listAlumnos";
            this.listAlumnos.RowHeadersVisible = false;
            this.listAlumnos.Size = new System.Drawing.Size(499, 362);
            this.listAlumnos.TabIndex = 0;
            this.listAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listAlumnos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTA DE ALUMNOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(439, 573);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 37);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModificar.Location = new System.Drawing.Point(177, 573);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 37);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnBuscador
            // 
            this.btnBuscador.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscador.Location = new System.Drawing.Point(425, 130);
            this.btnBuscador.Name = "btnBuscador";
            this.btnBuscador.Size = new System.Drawing.Size(112, 37);
            this.btnBuscador.TabIndex = 29;
            this.btnBuscador.Text = "Buscar";
            this.btnBuscador.UseVisualStyleBackColor = false;
            this.btnBuscador.Click += new System.EventHandler(this.btnBuscador_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.txtBuscador.Location = new System.Drawing.Point(117, 135);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(3, 10, 3, 15);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(302, 25);
            this.txtBuscador.TabIndex = 47;
            this.txtBuscador.Text = "Ingrese el DNI";
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            this.txtBuscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscador_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(308, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 48;
            this.button1.Text = "ACTIVAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.picMascota.Click += new System.EventHandler(this.picMascota_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecargar.Image = global::workout.Properties.Resources.rec;
            this.btnRecargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecargar.Location = new System.Drawing.Point(38, 135);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(73, 25);
            this.btnRecargar.TabIndex = 60;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnComprobante
            // 
            this.btnComprobante.BackColor = System.Drawing.Color.Gray;
            this.btnComprobante.Location = new System.Drawing.Point(38, 573);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(98, 37);
            this.btnComprobante.TabIndex = 61;
            this.btnComprobante.Text = "COMPROBANTE";
            this.btnComprobante.UseVisualStyleBackColor = false;
            this.btnComprobante.Click += new System.EventHandler(this.btnComprobante_Click);
            // 
            // FrmListAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 630);
            this.Controls.Add(this.btnComprobante);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.btnBuscador);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
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
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscador;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnComprobante;
    }
}