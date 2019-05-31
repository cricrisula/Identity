using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recetas_y_Mascotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            Form mascotas = new Mascotas();
            mascotas.Show();
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            Form recetas = new Recetas();
            recetas.Show();
        }
    }
}
