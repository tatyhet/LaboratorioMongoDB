namespace Laboratorio_MongoDB
{
    partial class VentanaP
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.tbActores = new System.Windows.Forms.TextBox();
            this.tbProductor = new System.Windows.Forms.TextBox();
            this.tbDuracion = new System.Windows.Forms.TextBox();
            this.tbAnnio = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbFranquicia = new System.Windows.Forms.TextBox();
            this.tbDirector = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToAddRows = false;
            this.dgvPeliculas.AllowUserToDeleteRows = false;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Location = new System.Drawing.Point(12, 12);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.ReadOnly = true;
            this.dgvPeliculas.RowTemplate.Height = 24;
            this.dgvPeliculas.RowTemplate.ReadOnly = true;
            this.dgvPeliculas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeliculas.Size = new System.Drawing.Size(1395, 268);
            this.dgvPeliculas.TabIndex = 1;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(367, 547);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(203, 47);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar película seleccionada";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(367, 319);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(203, 22);
            this.tbNombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modificar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Género";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Actores (separados por coma)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Productor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Duración";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Año";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "País";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Franquicia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Director";
            // 
            // tbGenero
            // 
            this.tbGenero.Location = new System.Drawing.Point(367, 344);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(203, 22);
            this.tbGenero.TabIndex = 14;
            // 
            // tbActores
            // 
            this.tbActores.Location = new System.Drawing.Point(367, 519);
            this.tbActores.Name = "tbActores";
            this.tbActores.Size = new System.Drawing.Size(203, 22);
            this.tbActores.TabIndex = 15;
            // 
            // tbProductor
            // 
            this.tbProductor.Location = new System.Drawing.Point(367, 494);
            this.tbProductor.Name = "tbProductor";
            this.tbProductor.Size = new System.Drawing.Size(203, 22);
            this.tbProductor.TabIndex = 16;
            // 
            // tbDuracion
            // 
            this.tbDuracion.Location = new System.Drawing.Point(367, 469);
            this.tbDuracion.Name = "tbDuracion";
            this.tbDuracion.Size = new System.Drawing.Size(203, 22);
            this.tbDuracion.TabIndex = 17;
            // 
            // tbAnnio
            // 
            this.tbAnnio.Location = new System.Drawing.Point(367, 443);
            this.tbAnnio.Name = "tbAnnio";
            this.tbAnnio.Size = new System.Drawing.Size(203, 22);
            this.tbAnnio.TabIndex = 18;
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(367, 419);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(203, 22);
            this.tbPais.TabIndex = 19;
            // 
            // tbFranquicia
            // 
            this.tbFranquicia.Location = new System.Drawing.Point(367, 394);
            this.tbFranquicia.Name = "tbFranquicia";
            this.tbFranquicia.Size = new System.Drawing.Size(203, 22);
            this.tbFranquicia.TabIndex = 20;
            // 
            // tbDirector
            // 
            this.tbDirector.Location = new System.Drawing.Point(367, 369);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.Size = new System.Drawing.Size(203, 22);
            this.tbDirector.TabIndex = 21;
            // 
            // VentanaP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 596);
            this.Controls.Add(this.tbDirector);
            this.Controls.Add(this.tbFranquicia);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.tbAnnio);
            this.Controls.Add(this.tbDuracion);
            this.Controls.Add(this.tbProductor);
            this.Controls.Add(this.tbActores);
            this.Controls.Add(this.tbGenero);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvPeliculas);
            this.Name = "VentanaP";
            this.Text = "Peliculas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.TextBox tbActores;
        private System.Windows.Forms.TextBox tbProductor;
        private System.Windows.Forms.TextBox tbDuracion;
        private System.Windows.Forms.TextBox tbAnnio;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.TextBox tbFranquicia;
        private System.Windows.Forms.TextBox tbDirector;
    }
}

