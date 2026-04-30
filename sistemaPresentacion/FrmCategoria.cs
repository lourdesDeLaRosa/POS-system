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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int id;
        #endregion

        #region "Mis Metodos"

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

        //metodo para darle formato al datagridview DgvListado
        private void formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Width = 100;
            DgvListado.Columns[2].HeaderText = "NOMBRE";
            DgvListado.Columns[3].Width = 300;
            DgvListado.Columns[3].HeaderText = "DESCRIPCIÓN";
            DgvListado.Columns[4].Width = 120;
            DgvListado.Columns[4].HeaderText = "ESTADO";

        }


        private void limpiar()
        {

            TxtBuscar.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            this.id = 0; 


            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;

            BtnGuardar.Visible = true;
            BtnGuardar.Enabled = false; 
            BtnActualizar.Visible = false; 


            BtnActivar.Visible = false;
            BtnDesactivar.Visible = false;
            BtnEliminar.Visible = false;
            DgvListado.Columns[0].Visible = false;
            ChkSeleccionar.Checked = false; 
            ChkSeleccionar.Visible = true;
        }

        //listar las categorias
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NCategoria.Listar();
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
                DgvListado.DataSource = NCategoria.Buscar(TxtBuscar.Text);
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
                string respuesta = ""; //aqui se captura lo que devuelve la capa de datos
                //primero se valida que los campos necesarios en la interfaz esten completos
                if(txtNombre.Text == "")
                {
                    this.mensajeError("Compelete los Campos Necesarios");
                }
                else
                {
                    respuesta = NCategoria.Insertar(txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                    if(respuesta == "OK")
                    {
                        this.mensajeOK("La Categoria se Insertó Correctamente!");
                        this.Listar();
                        this.limpiar();
                        TabPrincipal.SelectedIndex = 0; //muevete al tab de consulta
                    }
                    else
                    {
                        this.mensajeError(respuesta);
                    }
                }
            }
            catch (Exception ex)
            {

               
            }
        }

        //actualizar categoria
        private void Actualizar()
        {
            try
            {

                string respuesta = ""; //aqui se captura lo que devuelve la capa de datos
                //primero se valida que los campos necesarios en la interfaz esten completos
                if (txtNombre.Text == "")
                {
                    this.mensajeError("Complete los Campos Necesarios");
                }
                else
                {
                    respuesta = NCategoria.Actualizar(id, txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                    if (respuesta == "OK")
                    {
                        this.mensajeOK("La Categoria se Actualizó Correctamente!");
                        this.Listar();
                        TabPrincipal.SelectedIndex = 0; //muevete al tab de consulta
                    }
                    else
                    {
                        this.mensajeError(respuesta);
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //desactivar categoria
        private void Desactivar()
        {
            try
            {
                if(MessageBox.Show("¿Deseas desactivar esta(s) Categoria(s)?", "Sistema de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    //necesito tener el id de la categoria a desactivar
                    int id;
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            id = Convert.ToInt32(row.Cells[1].Value);
                           string respuesta = NCategoria.Desactivar(id);
                            if (respuesta == "OK")
                            {
                                this.mensajeOK("La Categoria " + Convert.ToString(row.Cells[2].Value)+ " se Desactivó Correctamente!");
                            }
                            else
                            {
                                this.mensajeError(respuesta);
                            }
                            this.Listar();

                        }
                    }
                }



                

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //eliminar categoria
        private void Eliminar()
        {
            try
            {
                if (MessageBox.Show("¿Deseas desactivar esta(s) Categoria(s)?", "Sistema de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //necesito tener el id de la categoria a desactivar
                    int id;
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            id = Convert.ToInt32(row.Cells[1].Value);
                            string respuesta = NCategoria.Eliminar(id);
                            if (respuesta == "OK")
                            {
                                this.mensajeOK("La Categoria " + Convert.ToString(row.Cells[2].Value) + " se Eliminó Correctamente!");
                            }
                            else
                            {
                                this.mensajeError(respuesta);
                            }
                            this.Listar();

                        }
                    }
                }





            }
            catch (Exception ex)
            {

                throw;
            }
        }


        private void Activar()
        {
            try
            {
                if (MessageBox.Show("¿Deseas Activar esta(s) Categoria(s)?", "Sistema de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //necesito tener el id de la categoria a desactivar
                    int id;
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            id = Convert.ToInt32(row.Cells[1].Value);
                            string respuesta = NCategoria.Activar(id);
                            if (respuesta == "OK")
                            {
                                this.mensajeOK("La Categoria " + Convert.ToString(row.Cells[2].Value) + " se Activó Correctamente!");
                            }
                            else
                            {
                                this.mensajeError(respuesta);
                            }
                            this.Listar();

                        }
                    }
                }





            }
            catch (Exception ex)
            {

                throw;
            }
        }

    

        #endregion

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

            this.limpiar();


            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;


            BtnGuardar.Visible = true;
            BtnGuardar.Enabled = true;

            BtnActualizar.Visible = false; 


            TabPrincipal.SelectedIndex = 1;

        }

            
        

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            this.Insertar();
            this.limpiar();
           
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                //obtener el valor de la celda
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //capturar los datos de la categoria en la que se huzo el doble click
            try
            {
                BtnGuardar.Visible = false;
                BtnActualizar.Visible = true;

                id= Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);
                txtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                txtDescripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value);

                txtNombre.Enabled= true;
                txtDescripcion.Enabled= true;
                BtnActualizar.Enabled= true;
                TabPrincipal.SelectedIndex = 1;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            this.Actualizar();
        }

        private void ChkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible= true;
                BtnNuevo.Enabled= false;
                BtnActivar.Visible= true;
                BtnDesactivar.Visible= true;    
                BtnEliminar.Visible= true;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                BtnNuevo.Enabled = true;
                BtnActivar.Visible = false;
                BtnDesactivar.Visible = false;
                BtnEliminar.Visible = false;
            }
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            this.Desactivar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            this.Activar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {


            this.limpiar();

   
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;


            TabPrincipal.SelectedIndex = 0;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
