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
    public partial class FrmVistaCliente : Form
    {
        public FrmVistaCliente()
        {
            InitializeComponent();
        }

        #region "Mis metodos"

        private void Formato()
        {


            if (DgvListado.Columns.Contains("Seleccionar"))
            {
                DgvListado.Columns["Seleccionar"].Visible = false;
            }

            if (DgvListado.Columns.Contains("idpersona"))
            {
                DgvListado.Columns["idpersona"].Visible = false;
            }

            if (DgvListado.Columns.Contains("TIPO_PERSONA"))
            {
                DgvListado.Columns["TIPO_PERSONA"].HeaderText = "TIPO_PERSONA";
                DgvListado.Columns["TIPO_PERSONA"].Width = 100;
            }


            if (DgvListado.Columns.Contains("NOMBRE"))
            {
                DgvListado.Columns["NOMBRE"].HeaderText = "NOMBRE";
                DgvListado.Columns["NOMBRE"].Width = 150;
            }

            if (DgvListado.Columns.Contains("TIPO_DOCUMENTO"))
            {
                DgvListado.Columns["TIPO_DOCUMENTO"].HeaderText = "TIPO_DOCUMENTO";
                DgvListado.Columns["TIPO_DOCUMENTO"].Width = 120;
            }

            if (DgvListado.Columns.Contains("NUM_DOCUMENTO"))
            {
                DgvListado.Columns["NUM_DOCUMENTO"].HeaderText = "NUM_DOCUMENTO";
                DgvListado.Columns["NUM_DOCUMENTO"].Width = 150;
            }

            if (DgvListado.Columns.Contains("DIRECCION"))
            {
                DgvListado.Columns["DIRECCION"].HeaderText = "DIRECCION";
                DgvListado.Columns["DIRECCION"].Width = 200;
            }

            if (DgvListado.Columns.Contains("TELEFONO"))
            {
                DgvListado.Columns["TELEFONO"].HeaderText = "TELEFONO";
                DgvListado.Columns["TELEFONO"].Width = 100;
            }

            if (DgvListado.Columns.Contains("EMAIL"))
            {
                DgvListado.Columns["EMAIL"].HeaderText = "EMAIL";
                DgvListado.Columns["EMAIL"].Width = 200;
            }



        }


        private void ListarClientes()
        {
            try
            {
                DgvListado.DataSource = NCliente.Listar();
                this.Formato();
                LblTotal.Text = "Total Registros: " + DgvListado.Rows.Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exepcion no controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarClientes()
        {
            try
            {
                DgvListado.DataSource = NCliente.Buscar(TxtBuscar.Text);
                this.Formato();
                LblTotal.Text = "Total Registros: " + DgvListado.Rows.Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exepcion no controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        private void FrmVistaCliente_Load(object sender, EventArgs e)
        {
            this.ListarClientes();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarClientes();
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                //Capturar los valores correspondientes a la fila en la que se hizo el evento
                Variables.IdCliente = Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);
                Variables.NombreCliente = Convert.ToString(DgvListado.CurrentRow.Cells["NOMBRE"].Value);
                this.Close();






            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exepcion no controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ChkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
