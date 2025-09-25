namespace workout.CapaPresentacion
{
    partial class FrmListaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaUsuarios));
            this.btnActivarUsuario = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscador = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listUsuarios = new System.Windows.Forms.DataGridView();
            this.picMascota = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.listUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActivarUsuario
            // 
            this.btnActivarUsuario.BackColor = System.Drawing.Color.Lime;
            this.btnActivarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnActivarUsuario.Location = new System.Drawing.Point(111, 547);
            this.btnActivarUsuario.Name = "btnActivarUsuario";
            this.btnActivarUsuario.Size = new System.Drawing.Size(112, 37);
            this.btnActivarUsuario.TabIndex = 56;
            this.btnActivarUsuario.Text = "ACTIVAR";
            this.btnActivarUsuario.UseVisualStyleBackColor = false;
            this.btnActivarUsuario.Click += new System.EventHandler(this.btnActivarUsuario_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.txtBuscador.Location = new System.Drawing.Point(83, 141);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(3, 10, 3, 15);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(301, 25);
            this.txtBuscador.TabIndex = 55;
            this.txtBuscador.Text = "Ingrese el DNI";
            // 
            // btnBuscador
            // 
            this.btnBuscador.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscador.Location = new System.Drawing.Point(408, 136);
            this.btnBuscador.Name = "btnBuscador";
            this.btnBuscador.Size = new System.Drawing.Size(112, 37);
            this.btnBuscador.TabIndex = 54;
            this.btnBuscador.Text = "Buscar";
            this.btnBuscador.UseVisualStyleBackColor = false;
            this.btnBuscador.Click += new System.EventHandler(this.btnBuscador_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(311, 547);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 37);
            this.btnEliminar.TabIndex = 52;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "LISTA DE USUARIOS";
            // 
            // listUsuarios
            // 
            this.listUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.listUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listUsuarios.Location = new System.Drawing.Point(41, 179);
            this.listUsuarios.Name = "listUsuarios";
            this.listUsuarios.RowHeadersVisible = false;
            this.listUsuarios.Size = new System.Drawing.Size(479, 362);
            this.listUsuarios.TabIndex = 49;
            // 
            // picMascota
            // 
            this.picMascota.Image = ((System.Drawing.Image)(resources.GetObject("picMascota.Image")));
            this.picMascota.Location = new System.Drawing.Point(82, 33);
            this.picMascota.Name = "picMascota";
            this.picMascota.Size = new System.Drawing.Size(73, 78);
            this.picMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMascota.TabIndex = 51;
            this.picMascota.TabStop = false;
            // 
            // FrmListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 619);
            this.Controls.Add(this.btnActivarUsuario);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.btnBuscador);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.picMascota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listUsuarios);
            this.Name = "FrmListaUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmListaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActivarUsuario;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Button btnBuscador;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox picMascota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listUsuarios;
    }
}