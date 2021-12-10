
namespace ParcialAlumno_20210506
{
    partial class FrmEstacionamiento
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbTipoMoto = new System.Windows.Forms.ComboBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lstVehiculos = new System.Windows.Forms.ListBox();
            this.txtNombreEstacionamiento = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(9, 42);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(81, 15);
            this.lblTipoVehiculo.TabIndex = 0;
            this.lblTipoVehiculo.Text = "Tipo Vehículo:";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(9, 71);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(50, 15);
            this.lblPatente.TabIndex = 1;
            this.lblPatente.Text = "Patente:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(9, 100);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(65, 15);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo Moto:";
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(93, 39);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoVehiculo.TabIndex = 0;
            // 
            // cmbTipoMoto
            // 
            this.cmbTipoMoto.FormattingEnabled = true;
            this.cmbTipoMoto.Location = new System.Drawing.Point(95, 97);
            this.cmbTipoMoto.Name = "cmbTipoMoto";
            this.cmbTipoMoto.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoMoto.TabIndex = 2;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(93, 68);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(121, 23);
            this.txtPatente.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(222, 97);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(132, 23);
            this.txtMarca.TabIndex = 6;
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.FormattingEnabled = true;
            this.lstVehiculos.ItemHeight = 15;
            this.lstVehiculos.Location = new System.Drawing.Point(360, 97);
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(329, 319);
            this.lstVehiculos.TabIndex = 10;
            // 
            // txtNombreEstacionamiento
            // 
            this.txtNombreEstacionamiento.Location = new System.Drawing.Point(360, 12);
            this.txtNombreEstacionamiento.Name = "txtNombreEstacionamiento";
            this.txtNombreEstacionamiento.Size = new System.Drawing.Size(329, 23);
            this.txtNombreEstacionamiento.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(9, 415);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar Vehículo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmEstacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreEstacionamiento);
            this.Controls.Add(this.lstVehiculos);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.cmbTipoMoto);
            this.Controls.Add(this.cmbTipoVehiculo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.lblTipoVehiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstacionamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmEstacionamiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.ComboBox cmbTipoMoto;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.ListBox lstVehiculos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombreEstacionamiento;
        //private System.Windows.Forms.Button btnAgregrar;
    }
}

