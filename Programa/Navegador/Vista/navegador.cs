using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using NavegadorControlador;
using Vista;

namespace NavegadorVista
{
    public partial class Navegador : UserControl
    {
        csControlador cn = new csControlador();
        public Navegador()
        {
            InitializeComponent();
        }

        public Form actual = new Form();
        public TextBox[] textbox = { };
        public TextBox[] textboxi = { };
        public DataGridView tabla;
       

        int opcion; 
        public void cargar(DataGridView dtabla, TextBox[] text, string BD)
        {
            IconButton[] botongc = {btnInsert, btnModificar, btnDelete, btnConsultar, btnReporte};
            cn.evaluartabla(dtabla);
            cn.inicializargrid(dtabla);
            cn.llenartablainicio(dtabla.Tag.ToString(), dtabla, text);
            cn.evaluartags(text, dtabla, BD);
            cn.desactivar(actual);
            cn.bloqueobtn(botongc);
            


        }
      

        private void btnExit_Click(object sender, EventArgs e)
        {
            actual.Close();
        }

        private void ComponenteNavegador_Load(object sender, EventArgs e)
        {
            IconButton[] botongc = { btnSave, btnCancelar };
            cn.bloquearbotonesGC(botongc, true);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            cn.moverseIF(tabla, "b");
            cn.llenartxt(textbox, tabla);
            cn.desactivar(actual);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            cn.moverseIF(tabla, "s");
            cn.llenartxt(textbox, tabla);
            cn.desactivar(actual);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            cn.moverseIF(tabla, "i");
            cn.llenartxt(textbox, tabla);
            cn.desactivar(actual);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            cn.moverseIF(tabla, "f");
            cn.llenartxt(textbox, tabla);
            cn.desactivar(actual);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            IconButton[] botongc = { btnSave, btnCancelar };
            opcion = 1;
            cn.limpiar(actual);
            cn.activar(actual);
            cn.crearid(textboxi, tabla);
            cn.bloquearbotonesGC(botongc, false);
            


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            opcion = 3;
            int permiso = cn.comprobacionvacio(tabla);
            if (permiso != 0)
            {
                IconButton[] botongc = { btnSave, btnCancelar };
                cn.bloquearbotonesGC(botongc, false);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            opcion = 2;
            int permiso = cn.comprobacionvacio(tabla);
            if(permiso != 0)
            {
                cn.activar(actual);
                cn.enfocar(textboxi);
                IconButton[] botongc = { btnSave, btnCancelar };
                cn.bloquearbotonesGC(botongc, false);
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IconButton[] botongc = { btnSave, btnCancelar };
           
            if (opcion == 1)
            {
                cn.ingresar(textbox, tabla);
                //cn.bloquearbotonesGC(botongc, true);
            }
            else if (opcion == 2)
            {
                cn.actualizar(textbox, tabla);
               // cn.bloquearbotonesGC(botongc, true);
            }
            else if(opcion == 3)
            {
                DialogResult resultado = MessageBox.Show("Desea eliminar el Resgistro", "Eliminar", MessageBoxButtons.YesNo);
                if(resultado == DialogResult.Yes)
                {
                    cn.delete(textbox, tabla);
                    //cn.bloquearbotonesGC(botongc, true);
                }
                else if(resultado == DialogResult.No)
                {

                    cn.limpiar(actual);
                    cn.desactivar(actual);
                    cn.llenartxt(textbox, tabla);
                    cn.bloquearbotonesGC(botongc, true);
                }
               
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cn.limpiar(actual);
            cn.desactivar(actual);
            cn.llenartxt(textbox, tabla);
            IconButton[] botongc = { btnSave, btnCancelar };
            cn.bloquearbotonesGC(botongc, true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cn.moverseIF(tabla, "i");
            cn.llenartablainicio(tabla.Tag.ToString(), tabla, textbox);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Ayuda ayuda = new Ayuda();
            ayuda.Show();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Consulta.Vista cv = new Consulta.Vista();
            /*
             * Form 'fcv' = new 'cv.BusquedaAvanzada';
             */
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            //Reportes.Vista cr = new Reportes.Vista();
            /*
             * Form 'fcr' = new 'cr.BusquedaAvanzada';
             */
        }
    }
}
