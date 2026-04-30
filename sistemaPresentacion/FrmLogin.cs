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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla = NUsuario.Login(txtEmail.Text.Trim(), txtClave.Text.Trim());
                if (tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("Email o Clave incorrecto");
                    //poner mensaje error aqui
                }
                else
                {
                    if (Convert.ToBoolean(tabla.Rows[0][4]) == false)
                    {
                        MessageBox.Show("Usuario Desactivado");
                    }
                    else
                    {
                        FrmPrincipal frm = new FrmPrincipal();
                        frm.IdUsuario = Convert.ToInt32(tabla.Rows [0][0]);
                        Variables.IdUsuario = Convert.ToInt32(tabla.Rows[0][0]);
                        frm.IdRol = Convert.ToInt32(tabla.Rows[0][1]);
                        frm.Rol = Convert.ToString(tabla.Rows[0][2]);
                        frm.Nombre = Convert.ToString(tabla.Rows[0][3]);
                        frm.Estado = Convert.ToBoolean(tabla.Rows[0][4]);
                        frm.Show();
                        this.Hide();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
