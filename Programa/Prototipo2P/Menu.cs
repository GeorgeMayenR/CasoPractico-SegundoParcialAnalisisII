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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            FProcesos fp = new FProcesos();
            fp.Show();
            this.Hide();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            FInformes fi = new FInformes();
            fi.Show();
            this.Hide();
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            FHerramientas fh = new FHerramientas();
            fh.Show();
            this.Hide();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            FAyuda fa = new FAyuda();
            fa.Show();
            this.Hide();
        }

        private void btnCatalogos_Click(object sender, EventArgs e)
        {
            Fcatálogos fc = new Fcatálogos();
            fc.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
