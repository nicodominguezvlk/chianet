using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Tango.PublicarPedidoDeEnvio
{
    public partial class PublicarPedidoDeEnvio : Form
    {
        DateTime fechaHoy = DateTime.Today;
        public PublicarPedidoDeEnvio()
        {
            InitializeComponent();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            string fechaRetiroUsuario = mtbRetiro.Text;
            string fechaEnvioUsuario = mtbEnvio.Text;
            DateTime fechaUsuario;

            //Verificación de campos obligatorios
            if (cmbTipoDeCarga.SelectedIndex == -1 || txtCalleRetiro.Text == "" || txtNumeroRetiro.Text == "" || cmbProvinciaRetiro.SelectedIndex == -1
                || txtLocalidadRetiro.Text == "" || mtbRetiro.Text == "" || txtCalleEnvio.Text == "" || txtNumeroEnvio.Text == "" || cmbProvinciaEnvio.SelectedIndex == -1
                || txtLocalidadEnvio.Text == "" || mtbEnvio.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los datos obligatorios (*). Por favor, revise", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Verificación fecha retiro mayor a hoy
                if (DateTime.TryParseExact(fechaRetiroUsuario, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaUsuario))
                {
                    int resultado = DateTime.Compare(fechaUsuario, fechaHoy);
                    if (resultado < 0)
                    {
                        MessageBox.Show("La fecha ingresada de retiro no es vália, ingrese una fecha mayor o igual a la actual.", "Fecha de retiro incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Formato de fecha de retiro incorrecto. Ingrese una fecha válida (dd/MM/yyyy).", "Fecha de retiro incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
       
    }
}
