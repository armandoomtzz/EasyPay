using EasyPayWinFormApp.Formularios_Administrador;
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

namespace EasyPayWinFormApp.Formularios_Menu
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        #region Entrar al Formulario de Ventas
        private void button1_Click(object sender, EventArgs e)
        {
            frmVenta form = new frmVenta();
            form.Show();
            this.Hide();
        }
        #endregion

        #region Entrar al formulario de Productos
        private void btnOrganizacion_Click(object sender, EventArgs e)
        {
            frmProductos form = new frmProductos();
            form.Show();
            this.Hide();
        }
        #endregion

        #region Entrar al formulario de Administracion
        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            frmMenuAdmin form = new frmMenuAdmin();
            form.Show();
            this.Hide();
        }
        #endregion

        #region Salir del formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }
        #endregion
    }
}
