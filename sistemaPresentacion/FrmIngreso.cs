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
    public partial class FrmIngreso : Form
    {
        //crear el Dtdetalle
        private DataTable DtDetalle = new DataTable();
        public FrmIngreso()
        {
            InitializeComponent();
        }


        //Metodo para mostrar un mensaje cuando algo salga bien
        private void mensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //metodo para mostrar mesnaje cuando algo salga mal

        private void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CrearTabla()
        {
            this.DtDetalle.Columns.Add("idarticulo", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("codigo", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("precio", System.Type.GetType("System.Decimal"));
            this.DtDetalle.Columns.Add("importe", System.Type.GetType("System.Decimal"));

            //anadimos al dgvdetalle
            dgvDetalle.DataSource = this.DtDetalle;
            dgvDetalle.Columns[0].Visible = false;
            dgvDetalle.Columns[1].HeaderText = "CODIGO";
            dgvDetalle.Columns[1].Width = 100;
            dgvDetalle.Columns[2].HeaderText = "ARTICULO";
            dgvDetalle.Columns[2].Width = 200;
            dgvDetalle.Columns[3].HeaderText = "CANTIDAD";
            dgvDetalle.Columns[3].Width = 70;
            dgvDetalle.Columns[4].HeaderText = "PRECIO";
            dgvDetalle.Columns[4].Width = 70;
            dgvDetalle.Columns[5].HeaderText = "IMPORTE";
            dgvDetalle.Columns[5].Width = 80;

            dgvDetalle.Columns[1].ReadOnly = true;
            dgvDetalle.Columns[2].ReadOnly = true;
            dgvDetalle.Columns[5].ReadOnly = true;
        }


        //metodo para darle formato al datagridview DgvListado
        private void formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[0].Width = 100;
            DgvListado.Columns[3].Width = 150;
            DgvListado.Columns[4].Width = 150;
            DgvListado.Columns[5].Width = 100;
            DgvListado.Columns[5].HeaderText = "Documento";
            DgvListado.Columns[6].Width = 70;
            DgvListado.Columns[6].HeaderText = "Serie";
            DgvListado.Columns[7].Width = 70;
            DgvListado.Columns[7].HeaderText = "Numero";
            DgvListado.Columns[8].Width = 60;
            DgvListado.Columns[9].Width = 100;
            DgvListado.Columns[10].Width = 100;
            DgvListado.Columns[11].Width = 100;

        }

        //Metodo para resetear la interfaz
        private void limpiar()
        {
            TxtBuscar.Clear();
            txtId.Clear();
            txtCodigo.Clear();
            txtIdProveedor.Clear();
            txtnombreProveedor.Clear();
            txtserieComprobante.Clear();
            txtnumComprobante.Clear();
            DtDetalle.Clear();
            txtsubTotal.Text = "0.00";
            txtTotalimpuesto.Text = "0.00";
            txtTotal.Text = "0.00";

            DgvListado.Columns[0].Visible = false;
            BtnAnular.Visible = false;
            ChkSeleccionar.Checked = false;
        }

        /* private void Formato_Articulos()
       {
           DgvArticulos.Columns[1].Visible = false;
           DgvArticulos.Columns[2].Width = 100;
           DgvArticulos.Columns[2].HeaderText = "Categoria";
           DgvArticulos.Columns[3].Width = 100;
           DgvArticulos.Columns[3].HeaderText = "Codigo";
           DgvArticulos.Columns[4].Width = 150;
           DgvArticulos.Columns[5].Width = 100;
           DgvArticulos.Columns[5].HeaderText = "Precio Venta";
           DgvArticulos.Columns[6].Width = 60;
           DgvArticulos.Columns[7].Width = 200;
           DgvArticulos.Columns[7].HeaderText = "Descripcion";
           DgvArticulos.Columns[8].Width = 100;
       }*/


        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NIngreso.Listar();
                this.formato();
                this.limpiar();
                LblTotal.Text = "Total Registros: " + DgvListado.Rows.Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Excepción no Controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //buscar categorias
        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NIngreso.Buscar(TxtBuscar.Text);
                this.formato();
                LblTotal.Text = "Total Registros: " + DgvListado.Rows.Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Excepción no Controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //metodo para insertar una categoria
        private void Insertar()
        {
            try
            {
                string Rpta = "";
                if (txtIdProveedor.Text == "" || txtserieComprobante.Text.Trim() == "" ||
                    txtnumComprobante.Text.Trim() == "" || DtDetalle.Rows.Count == 0)
                {
                    this.mensajeError("Complete los campos vacios");

                }
                else
                {
                    Rpta = NIngreso.Insertar(Convert.ToInt32(txtIdProveedor.Text), Variables.IdUsuario, cboComprobante.Text, txtserieComprobante.Text.Trim(), txtnumComprobante.Text.Trim(), Convert.ToDecimal(txtImpuesto.Text), Convert.ToDecimal(txtTotal.Text), DtDetalle);
                    if (Rpta.Equals("OK"))
                    {
                        this.mensajeOK("Se Insertó el Registro Correctamente!");
                        this.limpiar();
                        this.Listar();
                    }
                    else
                    {
                        this.mensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                mensajeOK(ex.Message + ex.StackTrace);
            }
        }






        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CrearTabla();
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                //obtener el valor de la celda
                DataGridViewCheckBoxCell ChkEliminar = ((DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"]);
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
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

        private void btnbuscarProveedor_Click(object sender, EventArgs e)
        {
            FrmVistaProveedores vista = new FrmVistaProveedores();
            vista.ShowDialog();
            txtIdProveedor.Text = Variables.IdProveedor.ToString();
            txtnombreProveedor.Text = Variables.NombreProveedor;
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DataTable tabla = new DataTable();
                    tabla = NArticulo.BuscarCodigo(txtCodigo.Text.Trim());

                    if (tabla.Rows.Count <= 0)
                    {
                        this.mensajeError("No existe un artículo con ese codigo de barras");
                    }
                    else
                    {
                        //agregar este articulo y su detalle
                        this.AgregarDetalle(
                            Convert.ToInt32(tabla.Rows[0][0]),
                            Convert.ToString(tabla.Rows[0][1]),
                            Convert.ToString(tabla.Rows[0][2]),
                            Convert.ToDecimal(tabla.Rows[0][3])

                            );
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AgregarDetalle(int idarticulo, string codigo, string nombre, decimal precio)
        {
            bool agregar = true;
            foreach (DataRow Filatemp in DtDetalle.Rows)
            {
                if (Convert.ToInt32(Filatemp["idarticulo"]) == idarticulo)
                {
                    agregar = false;
                    this.mensajeError("El Artículo ya fue Agregado!");
                }
            }
            if (agregar)
            {
                DataRow fila = DtDetalle.NewRow();
                fila["idarticulo"] = idarticulo;
                fila["codigo"] = codigo;
                fila["articulo"] = nombre;
                fila["cantidad"] = 1;
                fila["precio"] = precio;
                fila["importe"] = precio;
                this.DtDetalle.Rows.Add(fila);

                this.CalcularTotales();

            }

        }

        private void CalcularTotales()
        {
            decimal total = 0;
            decimal subtotal = 0;
            if (dgvDetalle.Rows.Count == 0)
            {
                total = 0;
            }
            else
            {
                foreach (DataRow item in DtDetalle.Rows)
                {
                    total = total + Convert.ToDecimal(item["importe"]);
                }
                subtotal = total / (1 + Convert.ToDecimal(txtImpuesto.Text));
                txtTotal.Text = total.ToString("#0.00#");
                txtsubTotal.Text = subtotal.ToString("#0.00#");
                txtTotalimpuesto.Text = (total - subtotal).ToString("#0.00#");
            }
        }

        private void btnverArticulos_Click(object sender, EventArgs e)
        {

            FrmMostrarArticulo frm = new FrmMostrarArticulo();
            frm.ShowDialog();

            this.AgregarDetalle(Variables.IdArticulo,Variables.Codigo,Variables.Nombre,Variables.Precio);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void dgvDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRow fila = (DataRow)DtDetalle.Rows[e.RowIndex];
            decimal precio = Convert.ToDecimal(fila["precio"]);
            int cantidad = Convert.ToInt32(fila["cantidad"]);
            fila["importe"] = precio * cantidad;
            this.CalcularTotales();
        }

        private void dgvDetalle_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.CalcularTotales();
        }

        private void DgvListado_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvMostrarDetalles.DataSource = NIngreso.ListarDetalle(Convert.ToInt32(DgvListado.CurrentRow.Cells["id"].Value));
                decimal Total, subtotal;
                decimal impuesto = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Impuesto"].Value);
                Total = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Total"].Value);
                subtotal = Total / (1 + impuesto);
                txtSubTotalID.Text = subtotal.ToString("#0.00#");
                txtTotalImpuestosID.Text = (Total - subtotal).ToString("#0.00#");
                txtTotalID.Text = Total.ToString("#0.00#");
                panelDetalle.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.Insertar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            panelDetalle.Visible = false;
        }

        private void ChkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                BtnAnular.Visible = true;
            }
            else
            {

                DgvListado.Columns[0].Visible = false;
                BtnAnular.Visible = false;

            }
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Deseas Anular estos Registros?", "Sistema Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Necesito obtener el id de la categoria a desactivar
                    int id;
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            id = Convert.ToInt32(row.Cells[1].Value);
                            string respuesta = NIngreso.Anular(id);
                            if (respuesta == "OK")
                            {
                                this.mensajeOK("Se Anulo el registro " + Convert.ToString(row.Cells[6].Value) + (" - ") + Convert.ToString(row.Cells[6].Value) + " Correctamente");
                            }
                            else
                            {
                                this.mensajeError(respuesta);
                            }

                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exepcion no controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
            TabPrincipal.SelectedIndex = 0;
        }
    }

}
