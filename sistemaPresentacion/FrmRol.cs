using sistemaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaPresentacion
{
    public partial class FrmRol : Form
    {
        public FrmRol()
        {
            InitializeComponent();
        }

        //formato al dataGridView
        private void Formato()
        {
            DgvListado.Columns[0].Width = 100;
            DgvListado.Columns[0].HeaderText = "ID Rol";
            DgvListado.Columns[1].Width = 200;
            DgvListado.Columns[1].HeaderText = "TIPO ROL";
        }

        //listar los roles
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NRol.Listar();
                this.Formato();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmRol_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
