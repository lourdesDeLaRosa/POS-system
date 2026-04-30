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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            DgvListado.RowHeadersVisible = false;
        }

        #region "Mis Variables"
        int id;
        #endregion

        #region "Mis Metodos"
        private void mensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //metodo para mostrar mesnaje cuando algo salga mal

        private void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //metodo para darle formato al datagridview DgvListado
        private void formato()
        {


            if (DgvListado.Columns.Contains("ID"))
                DgvListado.Columns["ID"].Visible = false;

            if(DgvListado.Columns.Contains("Seleccionar"))
                DgvListado.Columns["Seleccionar"].Visible = false;


            if (DgvListado.Columns.Contains("TIPO_PERSONA"))
            {
                DgvListado.Columns["TIPO_PERSONA"].Width = 100;
                DgvListado.Columns["TIPO_PERSONA"].HeaderText = "TIPO PERSONA";
            }

            if (DgvListado.Columns.Contains("NOMBRE"))
            {
                DgvListado.Columns["NOMBRE"].Width = 100;
                DgvListado.Columns["NOMBRE"].HeaderText = "NOMBRE";
            }

            if (DgvListado.Columns.Contains("TIPO_DOCUMENTO"))
            {
                DgvListado.Columns["TIPO_DOCUMENTO"].Width = 110;
                DgvListado.Columns["TIPO_DOCUMENTO"].HeaderText = "TIPO DOCUMENTO";
            }

            if (DgvListado.Columns.Contains("NUM_DOCUMENTO"))
            {
                DgvListado.Columns["NUM_DOCUMENTO"].Width = 80;
                DgvListado.Columns["NUM_DOCUMENTO"].HeaderText = "NUM DOCUMENTO";
            }

            if (DgvListado.Columns.Contains("DIRECCION"))
            {
                DgvListado.Columns["DIRECCION"].Width = 150;
                DgvListado.Columns["DIRECCION"].HeaderText = "DIRECCION";
            }

            if (DgvListado.Columns.Contains("TELEFONO"))
            {
                DgvListado.Columns["TELEFONO"].Width = 110;
                DgvListado.Columns["TELEFONO"].HeaderText = "TELEFONO";
            }

            if (DgvListado.Columns.Contains("EMAIL"))
            {
                DgvListado.Columns["EMAIL"].Width = 120;
                DgvListado.Columns["EMAIL"].HeaderText = "EMAIL";
            }




        }

       

        //Metodo para resetear la interfaz
        private void limpiar()
        {
            //Limpiar las cajas de texto
            txtEmail.Clear();
            txtNombre.Clear();
            txtNumDoc.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

            //deshabilitar las cajas de texto de la pestaña mantenimiento
            txtNombre.Enabled = false;

            cmbTipoDocumento.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefono.Enabled = false;
            txtNumDoc.Enabled = false;
            txtDireccion.Enabled = false;


            //activar y desactivar y ocultar ciertos botones
            BtnActualizar.Visible = false; //oculta el boton actualizar
            BtnGuardar.Visible = false;

            btnCancelar.Visible = false;




            //ocultar la columna seleccionar
            DgvListado.Columns[0].Visible = false;
            ChkSeleccionar.Checked = false;
        }



        private void Actualizar()
        {
            try
            {
                string respuesta = ""; // Aquí capturamos lo que devuelve la capa de Datos

                // 💡 Ajuste de Validación: Solamente validamos campos obligatorios para el Cliente.
                // Asumo que el Nombre es obligatorio.
                if (txtNombre.Text.Trim() == "" || cmbTipoDocumento.Text.Trim() == "" || txtNumDoc.Text.Trim() == "")
                {
                    this.mensajeError("Complete Los datos obligatorios (Nombre, Tipo Documento y Número Documento).");
                    // Nota: Debes validar el contenido de las cajas de texto que usaste en la inserción de NCliente.
                }
                else
                {
                    // 💡 Lógica de Actualización de Cliente:
                    // Llama al método Actualizar de NCliente con los datos de la interfaz.
                    // Uso 'id' (int) y 'txtPersona.Text' (string) que asumí existen en tu FrmCliente original.
                    respuesta = NCliente.Actualizar(
                        id,                                       
                        txtPersona.Text.Trim(),                   
                        txtNombre.Text.Trim(),                  
                        cmbTipoDocumento.Text.Trim(),    
                        txtNumDoc.Text.Trim(),        
                        txtDireccion.Text.Trim(),             
                        txtTelefono.Text.Trim(),             
                        txtEmail.Text.Trim()                 
                    );

                    if (respuesta == "OK")
                    {
                        this.mensajeOK("El Cliente se Actualizó Correctamente!");
                        this.Listar(); // Refresca el DataGridView
                        TabPrincipal.SelectedIndex = 0; // Muévete al tab de consulta
                    }
                    else
                    {
                        this.mensajeError(respuesta);
                    }
                }
            }
            catch (Exception ex)
            {
                // En caso de error (ej. conexión, formato de datos), muestra la excepción.
                MessageBox.Show(ex.Message, "Excepción no controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //listar las categorias
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NCliente.Listar();
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
                DgvListado.DataSource = NCliente.Buscar(TxtBuscar.Text);
                this.formato();
                LblTotal.Text = "Total Registros: " + DgvListado.Rows.Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Excepción no Controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Insertar()
        {
            try
            {
                string respuesta = "";//aqui capturamos lo que devuelve la capa de DAtos
                                      //primero Validamos que los campos necesarios en ela interfaz esten completos
                if (txtNombre.Text == "")
                {
                    this.mensajeError("Complete Los datos necesarios");
                }
                else
                {
                   


                    respuesta = NCliente.Insertar(id, txtPersona.Text.Trim(), txtNombre.Text.Trim(),  cmbTipoDocumento.Text.Trim(), txtNumDoc.Text.Trim(), txtDireccion.Text.Trim(), txtTelefono.Text.Trim(), txtEmail.Text.Trim());
                    if (respuesta == "OK")
                    {
                        this.mensajeOK("El Cliente se Insertó Correctamente!");
                        this.Listar();
                        TabPrincipal.SelectedIndex = 0;// Muevete al tab de consulta
                    }
                    else
                    {
                        this.mensajeError(respuesta);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exepcion no controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar()
        {
            try
            {
                if (MessageBox.Show("¿Deseas eliminar esto(s) Cliente(S)", "Sistema Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Necesito obtener el id de la categoria a desactivar
                    int id;
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            id = Convert.ToInt32(row.Cells[1].Value);
                            string respuesta = NCliente.Eliminar(id);
                            if (respuesta == "OK")
                            {
                                this.mensajeOK("El Cliente " + Convert.ToString(row.Cells["NOMBRE"].Value) + " se Eliminó Correctamente!");
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




        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            this.Insertar();
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                //obtener el valor de la celda
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);


            }
        }

        private void DgvListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //capturar los datos de la categoria en la que se huzo el doble click
            try
            {
             

                id = Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);
                txtPersona.Text = Convert.ToString(DgvListado.CurrentRow.Cells["TIPO_PERSONA"].Value);
                txtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["NOMBRE"].Value);
                cmbTipoDocumento.Text = Convert.ToString(DgvListado.CurrentRow.Cells["TIPO_DOCUMENTO"].Value);
                txtNumDoc.Text = Convert.ToString(DgvListado.CurrentRow.Cells["NUM_DOCUMENTO"].Value);
                txtDireccion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["DIRECCION"].Value);
                txtTelefono.Text = Convert.ToString(DgvListado.CurrentRow.Cells["TELEFONO"].Value);
                txtEmail.Text = Convert.ToString(DgvListado.CurrentRow.Cells["EMAIL"].Value);

                txtNombre.Enabled = true;
                cmbTipoDocumento.Enabled = true;
                txtNumDoc.Enabled = true;
                txtDireccion.Enabled = true;
                txtTelefono.Enabled = true;
                txtEmail.Enabled = true;
                BtnGuardar.Visible = false;
                BtnActualizar.Visible = true;
                BtnActualizar.Enabled = true;

                TabPrincipal.SelectedIndex = 1;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.limpiar();
            txtNombre.Enabled = true;
            cmbTipoDocumento.Enabled = true;
            txtNumDoc.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            BtnGuardar.Visible = true;
            BtnActualizar.Visible = false;
            BtnActualizar.Enabled = false;
            TabPrincipal.SelectedIndex = 1;
        }

        private void ChkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                BtnNuevo.Enabled = false;
                btnCancelar.Visible = true;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                BtnNuevo.Enabled = true;
                btnCancelar.Visible = false;
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            this.Actualizar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.limpiar();


            this.id = 0;


            TabPrincipal.SelectedIndex = 0;


        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
