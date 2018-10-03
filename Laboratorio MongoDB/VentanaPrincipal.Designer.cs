namespace Laboratorio_MongoDB
{
    partial class VentanaPrincipal
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
            this.btnPeli = new System.Windows.Forms.Button();
            this.btnProdu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPeli
            // 
            this.btnPeli.Location = new System.Drawing.Point(74, 102);
            this.btnPeli.Name = "btnPeli";
            this.btnPeli.Size = new System.Drawing.Size(312, 23);
            this.btnPeli.TabIndex = 0;
            this.btnPeli.Text = "Administración Películas";
            this.btnPeli.UseVisualStyleBackColor = true;
            this.btnPeli.Click += new System.EventHandler(this.btnPeli_Click);
            // 
            // btnProdu
            // 
            this.btnProdu.Location = new System.Drawing.Point(392, 102);
            this.btnProdu.Name = "btnProdu";
            this.btnProdu.Size = new System.Drawing.Size(326, 23);
            this.btnProdu.TabIndex = 1;
            this.btnProdu.Text = "Administración Productoras";
            this.btnProdu.UseVisualStyleBackColor = true;
            this.btnProdu.Click += new System.EventHandler(this.btnProdu_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProdu);
            this.Controls.Add(this.btnPeli);
            this.Name = "VentanaPrincipal";
            this.Text = "Ventana Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPeli;
        private System.Windows.Forms.Button btnProdu;
    }
}