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
    public partial class FrmMostrarArticulo : Form
    {
        public FrmMostrarArticulo()
        {
            InitializeComponent();
        }

        #region mis metodos

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[3].Width = 100;
            DgvListado.Columns[3].HeaderText = "CATEGORIA";
            DgvListado.Columns[4].Width = 100;
            DgvListado.Columns[4].HeaderText = "CÓDIGO";
            DgvListado.Columns[5].Width = 110;
            DgvListado.Columns[5].HeaderText = "NOMBRE";
            DgvListado.Columns[6].Width = 50;
            DgvListado.Columns[6].HeaderText = "PRECIO";
            DgvListado.Columns[7].Width = 50;
            DgvListado.Columns[7].HeaderText = "STOCK";
            DgvListado.Columns[8].Width = 110;
            DgvListado.Columns[8].HeaderText = "DESCRIPCIÓN";
            DgvListado.Columns[9].Width = 80;
            DgvListado.Columns[9].HeaderText = "IMAGEN";
            DgvListado.Columns[10].Width = 75;
            DgvListado.Columns[10].HeaderText = "ESTADO";

        }

        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NArticulo.Buscar(TxtBuscar.Text);
                this.Formato();
                LblTotal.Text = "Total Registros: " + DgvListado.Rows.Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exepcion no controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void FrmMostrarArticulo_Load(object sender, EventArgs e)
        {  
            try
            {
                DgvListado.DataSource = NArticulo.Listar();
                this.Formato();
                LblTotal.Text = "Total Registros: " + DgvListado.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar artículos: " + ex.Message,
                                "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.IdArticulo = Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);
            Variables.Codigo = Convert.ToString(DgvListado.CurrentRow.Cells["Codigo"].Value);
            Variables.Nombre = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
            Variables.Precio = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Precio_Venta"].Value);
            Variables.Stock = Convert.ToInt32(DgvListado.CurrentRow.Cells["Stock"].Value);
            this.Close();

        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
