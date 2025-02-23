namespace CapaPresentacion
{
    partial class FrmCuentas
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
            this.gboxClientes = new System.Windows.Forms.GroupBox();
            this.cboxTipocuenta = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoclientes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoCuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.gboxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxClientes
            // 
            this.gboxClientes.Controls.Add(this.txtFecha);
            this.gboxClientes.Controls.Add(this.cboxTipocuenta);
            this.gboxClientes.Controls.Add(this.btnGuardar);
            this.gboxClientes.Controls.Add(this.btnActualizar);
            this.gboxClientes.Controls.Add(this.btnCancelar);
            this.gboxClientes.Controls.Add(this.cboxEstado);
            this.gboxClientes.Controls.Add(this.label8);
            this.gboxClientes.Controls.Add(this.label7);
            this.gboxClientes.Controls.Add(this.txtSaldo);
            this.gboxClientes.Controls.Add(this.label6);
            this.gboxClientes.Controls.Add(this.label4);
            this.gboxClientes.Controls.Add(this.txtNumeroCuenta);
            this.gboxClientes.Controls.Add(this.label3);
            this.gboxClientes.Controls.Add(this.txtCodigoclientes);
            this.gboxClientes.Controls.Add(this.label2);
            this.gboxClientes.Controls.Add(this.txtCodigoCuenta);
            this.gboxClientes.Controls.Add(this.label1);
            this.gboxClientes.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(34)))), ((int)(((byte)(118)))));
            this.gboxClientes.Location = new System.Drawing.Point(0, 2);
            this.gboxClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxClientes.Name = "gboxClientes";
            this.gboxClientes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxClientes.Size = new System.Drawing.Size(1298, 314);
            this.gboxClientes.TabIndex = 1;
            this.gboxClientes.TabStop = false;
            this.gboxClientes.Text = "DATOS CUENTAS";
            this.gboxClientes.Enter += new System.EventHandler(this.gboxClientes_Enter);
            // 
            // cboxTipocuenta
            // 
            this.cboxTipocuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(34)))), ((int)(((byte)(118)))));
            this.cboxTipocuenta.FormattingEnabled = true;
            this.cboxTipocuenta.Items.AddRange(new object[] {
            "Ahorro",
            "Corriente"});
            this.cboxTipocuenta.Location = new System.Drawing.Point(214, 205);
            this.cboxTipocuenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxTipocuenta.Name = "cboxTipocuenta";
            this.cboxTipocuenta.Size = new System.Drawing.Size(220, 36);
            this.cboxTipocuenta.TabIndex = 19;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 35;
            this.btnGuardar.Location = new System.Drawing.Point(1142, 65);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(145, 50);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnActualizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 35;
            this.btnActualizar.Location = new System.Drawing.Point(1142, 128);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(145, 50);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnCancelar.IconColor = System.Drawing.Color.Red;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 35;
            this.btnCancelar.Location = new System.Drawing.Point(1142, 196);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 50);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Eliminar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cboxEstado
            // 
            this.cboxEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(34)))), ((int)(((byte)(118)))));
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxEstado.Location = new System.Drawing.Point(703, 211);
            this.cboxEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(220, 36);
            this.cboxEstado.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(560, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(560, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha Apertura:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(703, 108);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(220, 32);
            this.txtSaldo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(560, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Saldo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo Cuenta:";
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCuenta.Location = new System.Drawing.Point(214, 158);
            this.txtNumeroCuenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(244, 32);
            this.txtNumeroCuenta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero Cuenta:";
            // 
            // txtCodigoclientes
            // 
            this.txtCodigoclientes.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoclientes.Location = new System.Drawing.Point(214, 111);
            this.txtCodigoclientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoclientes.Name = "txtCodigoclientes";
            this.txtCodigoclientes.Size = new System.Drawing.Size(200, 32);
            this.txtCodigoclientes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo clientes:";
            // 
            // txtCodigoCuenta
            // 
            this.txtCodigoCuenta.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCuenta.Location = new System.Drawing.Point(194, 58);
            this.txtCodigoCuenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoCuenta.Name = "txtCodigoCuenta";
            this.txtCodigoCuenta.Size = new System.Drawing.Size(220, 32);
            this.txtCodigoCuenta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Cuenta:";
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCuentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.GridColor = System.Drawing.Color.DarkGray;
            this.dgvCuentas.Location = new System.Drawing.Point(0, 324);
            this.dgvCuentas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.RowHeadersWidth = 51;
            this.dgvCuentas.RowTemplate.Height = 24;
            this.dgvCuentas.Size = new System.Drawing.Size(1298, 410);
            this.dgvCuentas.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(34)))), ((int)(((byte)(118)))));
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Red;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 35;
            this.btnEliminar.Location = new System.Drawing.Point(1124, 746);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(145, 50);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(735, 160);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(220, 32);
            this.txtFecha.TabIndex = 20;
            // 
            // FrmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 809);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.gboxClientes);
            this.Name = "FrmCuentas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCuentas_Load);
            this.gboxClientes.ResumeLayout(false);
            this.gboxClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxClientes;
        private System.Windows.Forms.ComboBox cboxTipocuenta;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoclientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.TextBox txtFecha;
    }
}