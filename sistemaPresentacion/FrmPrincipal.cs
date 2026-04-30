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
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;

        //creamos atributos para recibir un usuario
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string Rol { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public FrmPrincipal()
        {
            InitializeComponent();
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

        private void ShowNewForm(object sender, EventArgs e)
        {
           
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciar el formulario 
            FrmCategoria frm = new FrmCategoria();
            //hay que asignarle un padre
            frm.MdiParent = this;
            //mostrar formulario
            frm.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciar el formulario 
            FrmArticulo frm = new FrmArticulo();
            //hay que asignarle un padre
            frm.MdiParent = this;
            //mostrar formulario
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión y salir del sistema?", "Sistema de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                foreach (Form child in MdiChildren)
                {
                    child.Close();
                }


                this.Hide();

       
                FrmLogin frmLogin = new FrmLogin();

                frmLogin.Show();
            }

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //mandar mensaje ok


            //MessageBox.Show("Bienvenido al Sistema, " + this.Nombre + "!");
            mensajeOK("Bienvenido al Sistema, " + this.Nombre + "!");
            statusStrip.Text = "Usuario: " + this.Nombre;

            if(this.Rol == "Administrador")
            {
                almacenToolStripMenuItem.Enabled = true;
                ingresosToolStripMenuItem.Enabled = true;
                ventasToolStripMenuItem.Enabled = true;
                accesoToolStripMenuItem.Enabled = true;
                consultasToolStripMenuItem.Enabled = true;


            }else if (this.Rol == "Vendedor")
            {
                almacenToolStripMenuItem.Enabled = false;
                ingresosToolStripMenuItem.Enabled = false;
                ventasToolStripMenuItem1.Enabled = true;
                clientesToolStripMenuItem.Enabled = false;
                accesoToolStripMenuItem.Enabled = false;
                consultasToolStripMenuItem.Enabled = true;
            }
            else if(this.Rol == "Almacen")
            {
                almacenToolStripMenuItem.Enabled = true;
                ingresosToolStripMenuItem.Enabled = true;
                ventasToolStripMenuItem.Enabled = false;
                accesoToolStripMenuItem.Enabled = false;
                consultasToolStripMenuItem.Enabled = true;
            }
            else
            {
                almacenToolStripMenuItem.Enabled = false;
                ingresosToolStripMenuItem.Enabled = false;
                ventasToolStripMenuItem.Enabled = false;
                accesoToolStripMenuItem.Enabled = false;
                consultasToolStripMenuItem.Enabled = false;
            }

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngreso frm = new FrmIngreso();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVentas frm = new FrmVentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedor frm = new FrmProveedor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRol frm = new FrmRol();
            frm.MdiParent = this;
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
