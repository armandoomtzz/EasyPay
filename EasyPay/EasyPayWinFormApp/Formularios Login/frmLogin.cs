#region Using Directives
using EasyPayWinFormApp.Formularios_Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace EasyPayWinFormApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        #region Codigo conectar
        private void btnConectar_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Codigo registrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar form = new frmRegistrar();
            form.Show();
            this.Hide();
        }
        #endregion

        #region Verificar datos
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=(local) ; database=dbEasyPayESC ; integrated security = true");
            conexion.Open();

            string Usuario = txtUsuario.Text;
            string Contraseña = txtPassword.Text;
            string cadena = "select * from Usuarios where Usuario='" + Usuario + "' and Contraseña='" + Contraseña + "'";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                MessageBox.Show("DATOS CORRECTOS, ¡BIENVENIDO!");
                btnConectar.Enabled = true;
            }
            else
            {
                MessageBox.Show("DATOS INCORRECTOS, VERIFIQUE LA INFORMACION.");
            }
            conexion.Close();
        }
        #endregion
    }
}
