using sistemaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaPresentacion
{
    public partial class FrmArticulo : Form
    {
        public FrmArticulo()
        {
            InitializeComponent();
        }

        #region "Mis Variabes"
        int id;
        string rutaImagen = "";
        string carpetaCodigoBarra = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ImagenesCodigoBarra");
        #endregion


        #region "Mis Metodos"

        private void CargarMetodos()
        {
            try
            {
                cmbCategorias.DataSource = NArticulo.CargarCategorias();
                cmbCategorias.DisplayMember = "nombre";
                cmbCategorias.ValueMember = "idcategoria";
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

        //metodo para darle formato al datagridview DgvListado
        private void formato()
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

        //Metodo para resetear la interfaz
        private void limpiar()
        {


            //Limpiar las cajas de texto
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCodigo.Clear();
            txtprecio.Text = "0.00";
            txtstock.Text = "0";
            TxtBuscar.Clear();

            //deshabilitar las cajas de texto de la pestaña mantenimiento
            txtNombre.Enabled = false;
            cmbCategorias.Enabled = false;
            txtstock.Enabled = false;
            txtprecio.Enabled = false;
            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = false;

            //activar y desactivar y ocultar ciertos botones
            BtnActualizar.Visible = false; //oculta el boton actualizar
            BtnguardarCodigo.Visible = false;
            BtnActivar.Visible = false;
            BtnDesactivar.Visible = false;
            BtnEliminar.Visible = false;

            //BtnGuardar.Enabled = false;
            BtngenerarCodigo.Enabled = false;
            btnImagen.Enabled = false;



            //ocultar la columna seleccionar
            DgvListado.Columns[0].Visible = false;
            ChkSeleccionar.Checked = false;


        }




        //listar las categorias
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NArticulo.Listar();
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
                DgvListado.DataSource = NArticulo.Buscar(TxtBuscar.Text);
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
                string respuesta; //variable para capturar la respuesta del procedimiento almacenado

                //validamos primero que los campos obligatorios estan completos
                if (cmbCategorias.SelectedIndex == -1 || txtNombre.Text.Trim() == "" || txtprecio.Text.Trim() == ""
                    || txtstock.Text.Trim() == "" || txtCodigo.Text.Trim() == "" || PicImagen.Image == null)
                {
                    this.mensajeError("Complete los campos obligatorios");
                }
                else
                {
                    respuesta = NArticulo.Insertar(Convert.ToInt32(cmbCategorias.SelectedValue), txtCodigo.Text.Trim(), txtNombre.Text.Trim(), Convert.ToDecimal(txtprecio.Text.Trim()),
                      Convert.ToInt32(txtstock.Text.Trim()), txtDescripcion.Text.Trim(), rutaImagen);
                    if (respuesta == "OK")
                    {
                        this.mensajeOK("El Registro de Insertó Correctamente!");
                        this.Listar(); //Refresca el DataGridView
                        TabPrincipal.SelectedIndex = 0; //nos movemos a la pestaña de la consulta
                    }
                    else
                    {
                        this.mensajeError(respuesta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //desactivar categoria
        private void Desactivar()
        {
            try
            {
                if (MessageBox.Show("¿Deseas desactivar estos(s) Articulos(S)", "Sistema Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Necesito obtener el id de la categoria a desactivar
                    int id;
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            id = Convert.ToInt32(row.Cells[1].Value);
                            string respuesta = NArticulo.Desactivar(id);
                            if (respuesta == "OK")
                            {
                                this.mensajeOK("El Articulo(S) " + Convert.ToString(row.Cells[5].Value) + " se Desactivó Correctamente!");
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
                if (MessageBox.Show("¿Deseas eliminar esto(s) Articulo(S)", "Sistema Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Necesito obtener el id de la categoria a desactivar
                    int id;
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            id = Convert.ToInt32(row.Cells[1].Value);
                            string respuesta = NArticulo.Eliminar(id);
                            if (respuesta == "OK")
                            {
                                this.mensajeOK("El Articulo " + Convert.ToString(row.Cells[5].Value) + " se Eliminó Correctamente!");
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

        //activar categoria
        private void Activar()
        {
            try
            {
                if (MessageBox.Show("¿Deseas Activar estos(s) Articulos(S)", "Sistema Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Necesito obtener el id de la categoria a desactivar
                    int id;
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            id = Convert.ToInt32(row.Cells[1].Value);
                            string respuesta = NArticulo.Activar(id);
                            if (respuesta == "OK")
                            {
                                this.mensajeOK("El Articulo " + Convert.ToString(row.Cells[5].Value) + " se Activó Correctamente!");
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
                if (cmbCategorias.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtNombre.Text)
                    || string.IsNullOrWhiteSpace(txtprecio.Text) || string.IsNullOrWhiteSpace(txtstock.Text)
                    || string.IsNullOrWhiteSpace(txtCodigo.Text) || PicImagen.Image == null)
                {
                    this.mensajeError("Complete los campos obligatorios");
                    return;
                }

                string respuesta = NArticulo.Actualizar(id, Convert.ToInt32(cmbCategorias.SelectedValue), txtNombre.Text.Trim(), txtDescripcion.Text.Trim(),
                        txtCodigo.Text.Trim(), Convert.ToDecimal(txtprecio.Text.Trim()), Convert.ToInt32(txtstock.Text.Trim()), rutaImagen);

                if (respuesta == "OK")
                {
                    this.mensajeOK("El Registro se Actualizó Correctamente!");
                    this.Listar(); // Refresca el DataGridView
                    TabPrincipal.SelectedIndex = 0; // volvemos a la pestaña de consulta
                }
                else
                {
                    this.mensajeError(respuesta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void GenerarCodigoBarra()
        {
            BarcodeLib.Barcode codigoBarraLib = new BarcodeLib.Barcode();
            codigoBarraLib.IncludeLabel = true;

            Image codigoBarraImagen = codigoBarraLib.Encode(BarcodeLib.TYPE.CODE128, txtCodigo.Text.Trim(),
                Color.Black, Color.White, 266, 110);

            setBackgroundImage(PnlCodigo, codigoBarraImagen);
        }

        //Metodo para liberar la imagen anterior antes de asignar la nueva
        private void setBackgroundImage(Panel panel, Image nueva)
        {
            //Libera la imagen anterior si es que existe
            if (panel.BackgroundImage != null)
            {
                panel.BackgroundImage.Dispose();
            }
            //Va a asignar la nueva imagen (puede ser null o la imagen cargada)
            panel.BackgroundImage = nueva;
        }


        #endregion

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            // Cargar las categorías en el ComboBox
            this.CargarMetodos();
         

            // Cargar todos los artículos en el DataGridView
            this.Listar();

         


        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            this.Activar();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
           
            // 1. Llama al método limpiar para resetear todos los campos de texto
            // y deshabilitar botones de edición/actualización.
            this.limpiar();

            // 2. Limpia explícitamente las imágenes cargadas, ya que limpiar() no lo hace
            PicImagen.Image = null;
            setBackgroundImage(PnlCodigo, null); // Usa el método seguro para liberar la imagen del código de barras
            rutaImagen = ""; // Limpia la variable de ruta de la imagen

            // 3. Habilita los controles necesarios para la nueva entrada
            txtNombre.Enabled = true;
            txtCodigo.Enabled = true;
            txtprecio.Enabled = true;
            txtstock.Enabled = true;
            cmbCategorias.Enabled = true;
            txtDescripcion.Enabled = true;
            PnlCodigo.Enabled = true;
            PicImagen.Enabled = true;


            // 4. Configura los botones para el modo "Nuevo"
            BtnGuardar.Enabled = true;
            BtnguardarCodigo.Visible = false;
            BtngenerarCodigo.Enabled = true;
            BtnActualizar.Visible = false;
            btnImagen.Enabled = true;

            // 5. Cambia a la pestaña de Mantenimiento
            TabPrincipal.SelectedIndex = 1;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            this.Insertar();
            int idcategoria = Convert.ToInt32(cmbCategorias.SelectedValue);
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

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
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
            
            

                //Capturar los valores correspondientes a la fila en la que se hizo el evento
                id = Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);
                cmbCategorias.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Categoria"].Value);
                txtCodigo.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Codigo"].Value);
                txtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                txtprecio.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Precio_Venta"].Value);
                txtstock.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Stock"].Value);
                txtDescripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value);
            rutaImagen = Convert.ToString(DgvListado.CurrentRow.Cells["Imagen"].Value).Trim();

            if (File.Exists(rutaImagen))
            {
                PicImagen.Image = CargarArchivo(rutaImagen);
            }
            else
            {
                MessageBox.Show("No se encontró la imagen: " + rutaImagen);
            }

            //Cargar el Codigo de Barra
            string codigoBarra = Convert.ToString(DgvListado.CurrentRow.Cells["Codigo"].Value);
            string rutaCodigoBarra = Path.Combine(carpetaCodigoBarra, $"{codigoBarra}.png");

            if (File.Exists(rutaCodigoBarra))
            {
                var imagenCodigoBarra = CargarArchivo(rutaCodigoBarra);

                if (imagenCodigoBarra != null)
                {
                    //setBackgroundImage se encarga de liberar la imagen anterior del panel
                    setBackgroundImage(PnlCodigo, imagenCodigoBarra);
                }
                else
                {
                    //Si falla la carga del archivo, aseguro que el panel este limpio
                    setBackgroundImage(PnlCodigo, null);
                }
            }
            else
            {
                //Si no existe el archivo, entonces el panel se limpiara
                setBackgroundImage(PnlCodigo, null);
                MessageBox.Show("No se encontró el código de barra: " + rutaCodigoBarra);
            }

            txtNombre.Enabled = true;
            cmbCategorias.Enabled = true;
            txtstock.Enabled = true;
            txtprecio.Enabled = true;
            txtCodigo.Enabled = true;
            txtDescripcion.Enabled = true;
            PnlCodigo.Visible = true;
            BtnGuardar.Visible = false;
            BtnActualizar.Visible = true;
            BtnActualizar.Enabled = true;
            btnImagen.Enabled = true;
            BtngenerarCodigo.Enabled = false;
            BtnNuevo.Visible = true;

            TabPrincipal.SelectedIndex = 1;

        }

        private Image CargarArchivo(string rutaArchivo)
        {
            if (!File.Exists(rutaArchivo)) return null;
            {
                try
                {
                    using (var fileStreamImagen = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
                    {
                        return new Bitmap(fileStreamImagen);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            this.Actualizar();
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            this.Desactivar();
        }

        private void BtnguardarCodigo_Click(object sender, EventArgs e)
        {
            string codigoBarra = txtCodigo.Text.Trim();
            string rutaCompleta = Path.Combine(carpetaCodigoBarra, $"{codigoBarra}.png");

            if (!Directory.Exists(carpetaCodigoBarra))
            {
                Directory.CreateDirectory(carpetaCodigoBarra);
            }

            if (File.Exists(rutaCompleta))
            {
                MessageBox.Show($"El Código de Barra ya está guardado");
            }
            else
            {

                if (PnlCodigo.BackgroundImage != null)
                {
                    PnlCodigo.BackgroundImage.Save(rutaCompleta, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show($"Imagen guardada en: {rutaCompleta}");
                }
                else
                {
                    MessageBox.Show($"No se ha Generado un Código para Guardar");
                }
            }

            string codigoAnterior = NArticulo.ObtenerCodigoBarrasPorId(id);

            if (codigoAnterior != codigoBarra)
            {
                string rutaImagenVieja = Path.Combine(carpetaCodigoBarra, $"{codigoAnterior}.png");

                if (File.Exists(rutaImagenVieja))
                {
                    try
                    {
                        // Se libera la imagen del Panel de Código de Barras si está cargada
                        if (PnlCodigo.BackgroundImage != null)
                        {
                            PnlCodigo.BackgroundImage.Dispose();
                            PnlCodigo.BackgroundImage = null;
                        }

                        File.Delete(rutaImagenVieja);

                        //Vuelvo a generar el codigo ya que "PnlCodigoBarras.BackgroundImage = null;"
                        GenerarCodigoBarra();
                    }
                    catch (IOException ioEx)
                    {
                        MessageBox.Show($"No se pudo borrar la imagen antigua: {ioEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            BtngenerarCodigo.Enabled = true;
        }

        private void BtngenerarCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text == "")
                {
                    MessageBox.Show("Debe Introducir un Código");
                }
                else
                {
                    GenerarCodigoBarra();

                    BtnguardarCodigo.Visible = true;
                    BtnguardarCodigo.Enabled = true;
                    PnlCodigo.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialogArticulo = new OpenFileDialog();
                openFileDialogArticulo.Filter = "Archivos de Imagen (*.jpeg, *.jpg, *.png) | *.jpeg; *.jpg; *.png";

                if (openFileDialogArticulo.ShowDialog() == DialogResult.OK)
                {
                    rutaImagen = openFileDialogArticulo.FileName;
                    PicImagen.Image = CargarArchivo(rutaImagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PnlCodigo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

            this.limpiar();


            PicImagen.Image = null;
            setBackgroundImage(PnlCodigo, null); 
            rutaImagen = ""; 


            BtnGuardar.Enabled = false;
            BtnGuardar.Visible = true;


            TabPrincipal.SelectedIndex = 0;

        }
    }
    
}


