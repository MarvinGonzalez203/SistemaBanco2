using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCuentas : Form
    {
        public FrmCuentas()
        {
            InitializeComponent();
        }


          
        public void MtdMostrarCuentas()
        {

            CD_Cuentas cd_cuentas = new CD_Cuentas();
            DataTable dtMostrarCuentas = cd_cuentas.MtMostrarCuentas();
            dgvCuentas.DataSource = dtMostrarCuentas;
        }
        

        private void gboxClientes_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCuentas_Load(object sender, EventArgs e)
        {
            MtdMostrarCuentas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CD_Cuentas cD_Cuentas = new CD_Cuentas();
            cD_Cuentas.MtdAgregarCuentas(txtCodigoclientes.Text, txtNumeroCuenta.Text, txtSaldo.Text, txtFecha.Text, cboxTipocuenta.Text, cboxEstado.Text);
            MessageBox.Show("El cliente se agrego con exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /*  try
              {

                


                  MtdMostrarCuentas();
              }
              catch (Exception ex)

              {
                  MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


              }*/
        }
    }
}
