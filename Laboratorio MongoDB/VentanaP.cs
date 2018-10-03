using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_MongoDB
{
    public partial class VentanaP : Form
    {
        public VentanaP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion test;
            test = new Conexion();
            //MessageBox.Show("Conecto");
            dataGridView1.DataSource = test.leerPeliculas();
           // dataGridView2.DataSource=test.leerPeliculas()
        }
    }
}
