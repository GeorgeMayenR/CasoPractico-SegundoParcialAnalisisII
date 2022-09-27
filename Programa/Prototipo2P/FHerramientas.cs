using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo2P
{
    public partial class FHerramientas : Form
    {
        public FHerramientas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4 };
            TextBox[] textboxi = { textBox1, textBox2 };
            navegador1.textbox = textbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = textboxi;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, textbox, "siu");
        }

        private void navegador1_Load_1(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4 };
            TextBox[] textboxi = { textBox1, textBox2 };
            navegador1.textbox = textbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = textboxi;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, textbox, "siu");
        }
    }
}
