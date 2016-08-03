namespace EasyPayWinFormApp
{
    partial class frmStock
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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(508, 45);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoria";
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
            this.cboCategoria.Location = new System.Drawing.Point(633, 42);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(257, 21);
            this.cboCategoria.TabIndex = 1;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.GridColor = System.Drawing.Color.White;
            this.dgvProductos.Location = new System.Drawing.Point(254, 101);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(843, 466);
            this.dgvProductos.TabIndex = 2;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(583, 633);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(193, 64);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(865, 633);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(193, 64);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(292, 633);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(193, 64);
            this.btnVer.TabIndex = 5;
            this.btnVer.Text = "Ver Productos";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.ControlBox = false;
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.lblCategoria);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revision de Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnVer;
    }
}