namespace EasyPayWinFormApp.Formualrios_Productos
{
    partial class frmModProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.dtpFecVencimiento = new System.Windows.Forms.DateTimePicker();
            this.nudVolumen = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblFecVencimiento = new System.Windows.Forms.Label();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtBarras = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblBarras = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVolumen)).BeginInit();
            this.SuspendLayout();
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(201, 273);
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(415, 20);
            this.nudPrecio.TabIndex = 40;
            // 
            // dtpFecVencimiento
            // 
            this.dtpFecVencimiento.Location = new System.Drawing.Point(877, 308);
            this.dtpFecVencimiento.Name = "dtpFecVencimiento";
            this.dtpFecVencimiento.Size = new System.Drawing.Size(415, 20);
            this.dtpFecVencimiento.TabIndex = 39;
            // 
            // nudVolumen
            // 
            this.nudVolumen.Location = new System.Drawing.Point(877, 273);
            this.nudVolumen.Name = "nudVolumen";
            this.nudVolumen.Size = new System.Drawing.Size(415, 20);
            this.nudVolumen.TabIndex = 38;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(877, 236);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(415, 20);
            this.dtpFecha.TabIndex = 37;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(877, 194);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(415, 20);
            this.txtProveedor.TabIndex = 36;
            // 
            // lblFecVencimiento
            // 
            this.lblFecVencimiento.AutoSize = true;
            this.lblFecVencimiento.Location = new System.Drawing.Point(746, 313);
            this.lblFecVencimiento.Name = "lblFecVencimiento";
            this.lblFecVencimiento.Size = new System.Drawing.Size(113, 13);
            this.lblFecVencimiento.TabIndex = 35;
            this.lblFecVencimiento.Text = "Fecha de Vencimiento";
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Location = new System.Drawing.Point(746, 275);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(48, 13);
            this.lblVolumen.TabIndex = 34;
            this.lblVolumen.Text = "Volumen";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(746, 236);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 33;
            this.lblFecha.Text = "Fecha";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(746, 197);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(56, 13);
            this.lblProveedor.TabIndex = 32;
            this.lblProveedor.Text = "Proveedor";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "Abarrotes",
            "Carnes",
            "Cereales y Granos",
            "Frutas y Verduras",
            "Lacteos",
            "De Limpieza",
            "Automotriz",
            "Pan",
            "Agua, Jugos y Sodas",
            "Ferreteria",
            "Productos de Cuidado Personal",
            "Utensilios",
            "Alcohol, Vinos y Cerveza",
            "Otros"});
            this.cboCategoria.Location = new System.Drawing.Point(201, 310);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(415, 21);
            this.cboCategoria.TabIndex = 31;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(201, 233);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(415, 20);
            this.txtDescripcion.TabIndex = 30;
            // 
            // txtBarras
            // 
            this.txtBarras.Location = new System.Drawing.Point(201, 194);
            this.txtBarras.Name = "txtBarras";
            this.txtBarras.Size = new System.Drawing.Size(415, 20);
            this.txtBarras.TabIndex = 29;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(70, 313);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 28;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(70, 275);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 27;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(70, 236);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 26;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblBarras
            // 
            this.lblBarras.AutoSize = true;
            this.lblBarras.Location = new System.Drawing.Point(70, 197);
            this.lblBarras.Name = "lblBarras";
            this.lblBarras.Size = new System.Drawing.Size(88, 13);
            this.lblBarras.TabIndex = 25;
            this.lblBarras.Text = "Codigo de Barras";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(122, 46);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(453, 13);
            this.lblBuscar.TabIndex = 41;
            this.lblBuscar.Text = "INTRODUZCA EL CODIGO DE BARRAS CON EL QUE FUE ALMACENADO EL PRODUCTO";
            this.lblBuscar.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(139, 79);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(415, 20);
            this.txtBuscar.TabIndex = 42;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(609, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(193, 64);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.Text = "Modificar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(609, 448);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(193, 64);
            this.btnModificar.TabIndex = 44;
            this.btnModificar.Text = "Realizar la modificacion";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmModProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.ControlBox = false;
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.dtpFecVencimiento);
            this.Controls.Add(this.nudVolumen);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.lblFecVencimiento);
            this.Controls.Add(this.lblVolumen);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtBarras);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblBarras);
            this.Name = "frmModProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVolumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.DateTimePicker dtpFecVencimiento;
        private System.Windows.Forms.NumericUpDown nudVolumen;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblFecVencimiento;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtBarras;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblBarras;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
    }
}