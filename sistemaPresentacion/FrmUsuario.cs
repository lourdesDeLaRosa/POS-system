using sistemaNegocios;
using System;
using System.Windows.Forms;

namespace sistemaPresentacion
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        #region "Mis Variabes"
        int id;
        #endregion

        #region "Mis Metodos"
        private void CargarMetodos()
        {
            try
            {
                cmbRol.DataSource = NUsuario.CargarRol();
                cmbRol.DisplayMember = "nombre";
                cmbRol.ValueMember = "idrol";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void mensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //metodo para mostrar mesnaje cuando algo salga mal

        private void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void formato()
        {




            if (DgvListado.Columns.Contains("idrol"))
            {
                DgvListado.Columns["idrol"].Visible = false;
            }

            // Si tu consulta devuelve 'Rol' y 'Tipo_Usuario' por separado,
            // este es el formato que debes usar.
            if (DgvListado.Columns.Contains("Rol"))
            {
                DgvListado.Columns["Rol"].HeaderText = "ROL";
                DgvListado.Columns["Rol"].Width = 100;
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


            if (DgvListado.Columns.Contains("ESTADO"))
            {
                DgvListado.Columns["ESTADO"].HeaderText = "ESTADO";
                DgvListado.Columns["ESTADO"].Width = 80;
            }

        }

        private void limpiar()
        {
            //Limpiar las cajas de texto
            txtEmail.Clear();
            txtClave.Clear();
            txtNombre.Clear();
            txtNoDocumento.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

            //deshabilitar las cajas de texto de la pestaña mantenimiento
            txtNombre.Enabled = false;
            cmbRol.Enabled = false;
            cmbTipoDocumento.Enabled = false;
            txtEmail.Enabled = false;
            txtClave.Enabled = false;
            txtTelefono.Enabled = false;
            txtNoDocumento.Enabled = false;
            txtDireccion.Enabled = false;


            //activar y desactivar y ocultar ciertos botones
            BtnActualizar.Visible = false; //oculta el boton actualizar
            BtnGuardar.Visible = false;
            BtnActivar.Visible = false;
            BtnDesactivar.Visible = false;
            BtnEliminar.Visible = false;




            //ocultar la columna seleccionar
            DgvListado.Columns[0].Visible = false;
            ChkSeleccionar.Checked = false;
        }

        //listar las categorias
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NUsuario.Listar();
                this.formato();
                this.limpiar();
                LblTotal.Text = "Total Registros: " + DgvListado.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepción no Controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NUsuario.Buscar(TxtBuscar.Text);
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
                    //cmbCategorias.DataSource = NArticulo.CargarCategorias();
                    id = Convert.ToInt32(cmbRol.SelectedValue);


                    respuesta = NUsuario.Insertar(Convert.ToInt32(cmbRol.SelectedValue), txtNombre.Text.Trim(), cmbTipoDocumento.Text.Trim(), txtNoDocumento.Text.Trim(), txtDireccion.Text.Trim(), txtTelefono.Text.Trim(), txtEmail.Text.Trim(), txtClave.Text.Trim());
                    if (respuesta == "OK")
                    {
                        this.mensajeOK("El Usuario se Insertó Correctamente!");
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

        private void Desactivar()
        {
            try
            {
                if (MessageBox.Show("¿Deseas desactivar estos(s) Usuario(S)?", "Sistema Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Necesito obtener el id de la categoria a desactivar
                    int id;
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            id = Convert.ToInt32(row.Cells[1].Value);
                            string respuesta = NUsuario.Desactivar(id);
                            if (respuesta == "OK")
                            {
                                this.mensajeOK("El Usuario " + Convert.ToString(row.Cells[4].Value) + " se Desactivó Correctamente!");
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

        //eliminar categoria
        private void Eliminar()
        {
            try
            {
                if (MessageBox.Show("¿Deseas Eliminar esto(s) Usuarios(S)?", "Sistema Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Necesito obtener el id de la categoria a desactivar
                    int id;
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            id = Convert.ToInt32(row.Cells[1].Value);
                            string respuesta = NUsuario.Eliminar(id);
                            if (respuesta == "OK")
                            {
                                this.mensajeOK("El Usuario " + Convert.ToString(row.Cells[4].Value) + " se Eliminó Correctamente!");
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


        private void Actualizar()
        {
            try
            {
                string respuesta = "";//aqui capturamos lo que devuelve la capa de DAtos
                //primero Validamos que los campos necesarios en ela interfaz esten completos
                if (cmbRol.SelectedIndex == -1 && cmbTipoDocumento.SelectedIndex == -1 && txtNombre.Text.Trim() == "" && txtEmail.Text.Trim() == ""
                    && txtClave.Text.Trim() == "" && txtNoDocumento.Text.Trim() == "" && txtTelefono.Text.Trim() == "")
                {
                    this.mensajeError("Complete Los datos necesarios");
                }
                else
                {


                    respuesta = NUsuario.Actualizar(id, Convert.ToInt32(cmbRol.SelectedValue), txtNombre.Text.Trim(), cmbTipoDocumento.Text.Trim(), txtNoDocumento.Text.Trim(), txtDireccion.Text.Trim(), txtTelefono.Text.Trim(), txtEmail.Text.Trim(), txtClave.Text.Trim());
                    if (respuesta == "OK")
                    {
                        this.mensajeOK("El Usuario se Actualizó Correctamente!");
                        this.Listar(); //Refresca el DataGridView
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

        private void Activar()
        {
            try
            {
                if (MessageBox.Show("¿Deseas activar estos(s) Usuario(s)?", "Sistema de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Seleccionar"].Value))
                        {
                            int idUsuario = Convert.ToInt32(row.Cells["ID"].Value);
                            string estadoActual = row.Cells["ESTADO"].Value.ToString().ToLower();

                            if (estadoActual == "activo")
                            {
                                this.mensajeOK("El Usuario " + row.Cells["NOMBRE"].Value + " ya está Activo.");
                                continue;
                            }

                            string respuesta = NUsuario.Activar(idUsuario);

                            if (respuesta == "OK")
                            {
                                this.mensajeOK("El Usuario " + row.Cells["NOMBRE"].Value + " se Activó Correctamente!");
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
                MessageBox.Show(ex.Message, "Excepción no controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        #endregion

        private void LblTotal_Click(object sender, EventArgs e)
        {

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // Cargar los roles en el ComboBox
            cmbRol.DataSource = NUsuario.CargarRol();
            cmbRol.DisplayMember = "nombre";
            cmbRol.ValueMember = "idrol";

            // Cargar todos los artículos en el DataGridView
            this.Listar();

            BtnActivar.Visible = false;
            BtnDesactivar.Visible = false;
            BtnEliminar.Visible = false;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            // Llama a limpiar() al inicio para resetear todos los campos
            this.limpiar();

            // Re-habilita los controles para la nueva entrada, ya que 'limpiar' los deshabilita
            txtNombre.Enabled = true;
            cmbRol.Enabled = true;
            cmbTipoDocumento.Enabled = true;
            txtNoDocumento.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            txtClave.Enabled = true;

            // Configura los botones para el modo "Guardar/Nuevo"
            BtnGuardar.Visible = true; // Hacer visible el botón Guardar
            BtnActualizar.Visible = false; // Ocultar el botón Actualizar
            BtnActualizar.Enabled = false;

            // Cambia a la pestaña de Mantenimiento
            TabPrincipal.SelectedIndex = 1;
        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            this.Activar();

        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            this.Desactivar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            this.Insertar();
            int idcategoria = Convert.ToInt32(cmbRol.SelectedValue);
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

        private void ChkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                BtnActivar.Visible = true;
                BtnDesactivar.Visible = true;
                BtnEliminar.Visible = true;
                BtnNuevo.Visible = false;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                BtnActivar.Visible = false;
                BtnDesactivar.Visible = false;
                BtnEliminar.Visible = false;

                BtnNuevo.Visible = true;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }

        private void DgvListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                //Capturar los valores correspondientes a la fila en la que se hizo el evento
                id = Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);
                cmbRol.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ROL"].Value);
                txtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["NOMBRE"].Value);
                cmbTipoDocumento.Text = Convert.ToString(DgvListado.CurrentRow.Cells["TIPO_DOCUMENTO"].Value);
                txtNoDocumento.Text = Convert.ToString(DgvListado.CurrentRow.Cells["NUM_DOCUMENTO"].Value);
                txtDireccion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["DIRECCION"].Value);
                txtTelefono.Text = Convert.ToString(DgvListado.CurrentRow.Cells["TELEFONO"].Value);
                txtEmail.Text = Convert.ToString(DgvListado.CurrentRow.Cells["EMAIL"].Value);



                txtNombre.Enabled = true;
                cmbRol.Enabled = true;
                cmbTipoDocumento.Enabled = true;
                txtNoDocumento.Enabled = true;
                txtDireccion.Enabled = true;
                txtTelefono.Enabled = true;
                txtEmail.Enabled = true;
                txtClave.Enabled = true;
                BtnGuardar.Visible = false;
                BtnActualizar.Visible = true;
                BtnActualizar.Enabled = true;

                TabPrincipal.SelectedIndex = 1;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exepcion no controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            this.Actualizar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.limpiar();

            this.id = 0;


            TabPrincipal.SelectedIndex = 0;


        }
    }
}
