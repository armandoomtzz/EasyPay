#region Using directives
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

namespace EasyPayWinFormApp.Formularios_Login
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        #region Boton verificar administrador
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=(local) ; database=dbEasyPayESC ; integrated security = true");
            conexion.Open();

            string Administrador = txtAdministrador.Text;
            string cadena = "select * from Administradores where PassAdmin='" + Administrador + "'";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                MessageBox.Show("VERIFICACION CORRECTA");
                btnRegistrar.Enabled = true;
            }
            else
            {
                MessageBox.Show("DATOS INCORRECTOS, VERIFIQUE LA INFORMACION.");
            }
            conexion.Close();
        }
        #endregion

        #region Boton registrar nuevo empleado
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=(local) ; database=dbEasyPayESC ; integrated security = true");
            conexion.Open();

            string NoEmpleado = nudEmpleado.Text;
            string Usuario = txtUsuario.Text;
            string Password = txtPassword.Text;
            string Fecha = dtpFecha.Text;
            string Nombre = txtNombre.Text;
            string cadena = "insert into Usuarios(NoEmpleado, Usuario, Contrasena, Fecha, Nombre) values (" + NoEmpleado + ",'" + Usuario + "','" + Password + "','" + Fecha + "','" + Nombre + "')";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();

            MessageBox.Show("¡DATOS AGREGADOS CORRECTAMENTE!");

            nudEmpleado.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
            dtpFecha.Text = "";
            txtNombre.Text = "";
            conexion.Close();
        }
        #endregion

        #region Boton regresar al login
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }
        #endregion

        private void frmRegistrar_Load(object sender, EventArgs e)
        {

        }
    }
}
