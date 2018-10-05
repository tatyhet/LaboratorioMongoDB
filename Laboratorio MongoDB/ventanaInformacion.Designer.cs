namespace Laboratorio_MongoDB
{
    partial class ventanaInformacion
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
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbFranquicia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDFecha = new System.Windows.Forms.ComboBox();
            this.cbAFecha = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProductora = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCantPeli = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMenorP = new System.Windows.Forms.Label();
            this.lblMayorP = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.tbProductoraP = new System.Windows.Forms.TextBox();
            this.btnObtenerPromedio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(12, 12);
            this.dgvInfo.MultiSelect = false;
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            this.dgvInfo.RowTemplate.Height = 24;
            this.dgvInfo.RowTemplate.ReadOnly = true;
            this.dgvInfo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfo.Size = new System.Drawing.Size(1395, 268);
            this.dgvInfo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Información";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(412, 319);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(322, 22);
            this.tbNombre.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(740, 320);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(252, 46);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbFranquicia
            // 
            this.tbFranquicia.Location = new System.Drawing.Point(412, 344);
            this.tbFranquicia.Name = "tbFranquicia";
            this.tbFranquicia.Size = new System.Drawing.Size(322, 22);
            this.tbFranquicia.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Franquicia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Rango de años";
            // 
            // cbDFecha
            // 
            this.cbDFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDFecha.FormattingEnabled = true;
            this.cbDFecha.Location = new System.Drawing.Point(431, 369);
            this.cbDFecha.Name = "cbDFecha";
            this.cbDFecha.Size = new System.Drawing.Size(121, 24);
            this.cbDFecha.TabIndex = 24;
            // 
            // cbAFecha
            // 
            this.cbAFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAFecha.FormattingEnabled = true;
            this.cbAFecha.Location = new System.Drawing.Point(613, 369);
            this.cbAFecha.Name = "cbAFecha";
            this.cbAFecha.Size = new System.Drawing.Size(121, 24);
            this.cbAFecha.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Del: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Al: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Productora";
            // 
            // tbProductora
            // 
            this.tbProductora.Location = new System.Drawing.Point(412, 394);
            this.tbProductora.Name = "tbProductora";
            this.tbProductora.Size = new System.Drawing.Size(322, 22);
            this.tbProductora.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Cantidad de películas";
            // 
            // lblCantPeli
            // 
            this.lblCantPeli.AutoSize = true;
            this.lblCantPeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantPeli.Location = new System.Drawing.Point(329, 419);
            this.lblCantPeli.Name = "lblCantPeli";
            this.lblCantPeli.Size = new System.Drawing.Size(77, 20);
            this.lblCantPeli.TabIndex = 31;
            this.lblCantPeli.Text = "Contador";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "Película con menor duración";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(283, 25);
            this.label10.TabIndex = 33;
            this.label10.Text = "Película con mayor duración";
            // 
            // lblMenorP
            // 
            this.lblMenorP.AutoSize = true;
            this.lblMenorP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenorP.Location = new System.Drawing.Point(329, 469);
            this.lblMenorP.Name = "lblMenorP";
            this.lblMenorP.Size = new System.Drawing.Size(77, 20);
            this.lblMenorP.TabIndex = 34;
            this.lblMenorP.Text = "Contador";
            // 
            // lblMayorP
            // 
            this.lblMayorP.AutoSize = true;
            this.lblMayorP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayorP.Location = new System.Drawing.Point(329, 444);
            this.lblMayorP.Name = "lblMayorP";
            this.lblMayorP.Size = new System.Drawing.Size(77, 20);
            this.lblMayorP.TabIndex = 35;
            this.lblMayorP.Text = "Contador";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 490);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(277, 25);
            this.label11.TabIndex = 36;
            this.label11.Text = "Promedio según productora";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(329, 494);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(18, 20);
            this.lblPromedio.TabIndex = 37;
            this.lblPromedio.Text = "0";
            // 
            // tbProductoraP
            // 
            this.tbProductoraP.Location = new System.Drawing.Point(412, 494);
            this.tbProductoraP.Name = "tbProductoraP";
            this.tbProductoraP.Size = new System.Drawing.Size(327, 22);
            this.tbProductoraP.TabIndex = 38;
            // 
            // btnObtenerPromedio
            // 
            this.btnObtenerPromedio.Location = new System.Drawing.Point(745, 490);
            this.btnObtenerPromedio.Name = "btnObtenerPromedio";
            this.btnObtenerPromedio.Size = new System.Drawing.Size(247, 26);
            this.btnObtenerPromedio.TabIndex = 39;
            this.btnObtenerPromedio.Text = "Obtener promedio de la productora";
            this.btnObtenerPromedio.UseVisualStyleBackColor = true;
            this.btnObtenerPromedio.Click += new System.EventHandler(this.btnObtenerPromedio_Click);
            // 
            // ventanaInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 581);
            this.Controls.Add(this.btnObtenerPromedio);
            this.Controls.Add(this.tbProductoraP);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblMayorP);
            this.Controls.Add(this.lblMenorP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCantPeli);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbProductora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAFecha);
            this.Controls.Add(this.cbDFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFranquicia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.dgvInfo);
            this.Name = "ventanaInformacion";
            this.Text = "Ventana de Informacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbFranquicia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDFecha;
        private System.Windows.Forms.ComboBox cbAFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbProductora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCantPeli;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMenorP;
        private System.Windows.Forms.Label lblMayorP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.TextBox tbProductoraP;
        private System.Windows.Forms.Button btnObtenerPromedio;
    }
}