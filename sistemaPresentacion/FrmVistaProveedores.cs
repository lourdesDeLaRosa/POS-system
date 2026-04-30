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
    public partial class FrmVistaProveedores : Form
    {
        public FrmVistaProveedores()
        {
            InitializeComponent();
        }

        #region Mis Metodos

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

        private void ListarProveedores()
        {
            try
            {
                DgvListado.DataSource = NProveedor.Listar();
                this.Formato();
                LblTotal.Text = "Total Registros: " + DgvListado.Rows.Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exepcion no controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarProveedores()
        {
            try
            {
                DgvListado.DataSource = NProveedor.Buscar(TxtBuscar.Text);
                this.Formato();
                LblTotal.Text = "Total Registros: " + DgvListado.Rows.Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exepcion no controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        private void FrmVistaProveedores_Load(object sender, EventArgs e)
        {
            this.ListarProveedores();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarProveedores();
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                //Capturar los valores correspondientes a la fila en la que se hizo el evento
                Variables.IdProveedor = Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);
                Variables.NombreProveedor = Convert.ToString(DgvListado.CurrentRow.Cells["NOMBRE"].Value);
                this.Close();






            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exepcion no controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ChkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
