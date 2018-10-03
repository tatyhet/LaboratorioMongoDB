namespace Laboratorio_MongoDB
{
    partial class AdmProductoras
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.tbAnnioF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvProductoras = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.tbWeb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-297, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Administración";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(585, 314);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(387, 27);
            this.btnEliminar.TabIndex = 51;
            this.btnEliminar.Text = "Eliminar productora seleccionada";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(484, 394);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(95, 66);
            this.btnInsertar.TabIndex = 50;
            this.btnInsertar.Text = "Insertar nueva productora";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // tbAnnioF
            // 
            this.tbAnnioF.Location = new System.Drawing.Point(376, 341);
            this.tbAnnioF.Name = "tbAnnioF";
            this.tbAnnioF.Size = new System.Drawing.Size(203, 22);
            this.tbAnnioF.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Año de fundación";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 25);
            this.label11.TabIndex = 33;
            this.label11.Text = "Nombre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(203, 32);
            this.label12.TabIndex = 32;
            this.label12.Text = "Administración";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(376, 316);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(203, 22);
            this.tbNombre.TabIndex = 31;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(376, 394);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 66);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "Modificar productora seleccionada";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvProductoras
            // 
            this.dgvProductoras.AllowUserToAddRows = false;
            this.dgvProductoras.AllowUserToDeleteRows = false;
            this.dgvProductoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductoras.Location = new System.Drawing.Point(21, 9);
            this.dgvProductoras.MultiSelect = false;
            this.dgvProductoras.Name = "dgvProductoras";
            this.dgvProductoras.ReadOnly = true;
            this.dgvProductoras.RowTemplate.Height = 24;
            this.dgvProductoras.RowTemplate.ReadOnly = true;
            this.dgvProductoras.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductoras.Size = new System.Drawing.Size(951, 268);
            this.dgvProductoras.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 25);
            this.label10.TabIndex = 41;
            this.label10.Text = "Dirección web";
            // 
            // tbWeb
            // 
            this.tbWeb.Location = new System.Drawing.Point(376, 366);
            this.tbWeb.Name = "tbWeb";
            this.tbWeb.Size = new System.Drawing.Size(203, 22);
            this.tbWeb.TabIndex = 49;
            // 
            // AdmProductoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 470);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.tbWeb);
            this.Controls.Add(this.tbAnnioF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvProductoras);
            this.Controls.Add(this.label1);
            this.Name = "AdmProductoras";
            this.Text = "Productoras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox tbAnnioF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvProductoras;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbWeb;
    }
}