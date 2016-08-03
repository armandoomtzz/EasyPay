namespace EasyPayWinFormApp.Formularios_Menu
{
    partial class frmMenu
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
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnOrganizacion = new System.Windows.Forms.Button();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(190, 75);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(114, 49);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "VENTA DE PRODUCTOS";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOrganizacion
            // 
            this.btnOrganizacion.Location = new System.Drawing.Point(190, 166);
            this.btnOrganizacion.Name = "btnOrganizacion";
            this.btnOrganizacion.Size = new System.Drawing.Size(114, 49);
            this.btnOrganizacion.TabIndex = 1;
            this.btnOrganizacion.Text = "ORGANIZACION DE PRODUCTOS";
            this.btnOrganizacion.UseVisualStyleBackColor = true;
            this.btnOrganizacion.Click += new System.EventHandler(this.btnOrganizacion_Click);
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.Location = new System.Drawing.Point(71, 258);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Size = new System.Drawing.Size(114, 49);
            this.btnAdministracion.TabIndex = 2;
            this.btnAdministracion.Text = "ADMINISTRACION";
            this.btnAdministracion.UseVisualStyleBackColor = true;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ELIGE LA OPCION CON LA QUE QUIERES TRABAJAR";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(310, 258);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 49);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdministracion);
            this.Controls.Add(this.btnOrganizacion);
            this.Controls.Add(this.btnVentas);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnOrganizacion;
        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;

    }
}