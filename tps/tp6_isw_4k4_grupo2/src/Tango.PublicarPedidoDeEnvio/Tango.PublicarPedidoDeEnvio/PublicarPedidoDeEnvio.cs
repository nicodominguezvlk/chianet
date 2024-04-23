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
        private readonly DateTime fechaHoy = DateTime.Today;
        
        public PublicarPedidoDeEnvio()
        {
            InitializeComponent();
        }



        // Metodos

        public void AgregarFotos()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivo PNG (.png)|*.png|Archivo JPG (.jpg)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.SafeFileName;
                grdFotos.Rows.Add(fileName);
            }
        }

        public void Cancelar()
        {
            Cerrar();
        }

        public void Cerrar()
        {
            Close();
        }

        public void Publicar()
        {
            // Verificacion de campos obligatorios
            if (cmbTipoDeCarga.SelectedIndex == -1 || txtCalleRetiro.Text == "" || txtNumeroRetiro.Text == "" || cmbProvinciaRetiro.SelectedIndex == -1
                || txtLocalidadRetiro.Text == "" || mtbRetiro.Text == "" || txtCalleEnvio.Text == "" || txtNumeroEnvio.Text == "" || cmbProvinciaEnvio.SelectedIndex == -1
                || txtLocalidadEnvio.Text == "" || mtbEnvio.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los datos obligatorios (*). Por favor, revise.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Verificacion fecha retiro mayor a hoy
                VerificarFechaRetiro();
                VerificarFechaEnvio();
            }
        }

        private void QuitarFoto(int index)
        {
            grdFotos.Rows.RemoveAt(index);
        }

        private void VerificarFechaEnvio() // Verificacion campo fecha envio
        {
            string fechaEnvioStr = mtbEnvio.Text;
            string fechaRetiroStr = mtbRetiro.Text;

            DateTime fechaEnvio;
            DateTime fechaRetiro;
            if (DateTime.TryParseExact(fechaEnvioStr, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaEnvio) &&
                DateTime.TryParseExact(fechaRetiroStr, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaRetiro))
            {
                int resultado = DateTime.Compare(fechaEnvio, fechaRetiro);

                if (resultado < 0)
                {
                    MessageBox.Show("La fecha de envío es anterior a la fecha de retiro.", "Fecha de envío incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Formato de fecha de envío incorrecto. Ingrese una fecha válida (dd/MM/yyyy).", "Fecha de envío incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarFechaRetiro() // Verificacion campo fecha retiro
        {
            string fechaRetiroUsuario = mtbRetiro.Text;

            DateTime fechaUsuario;
            if (DateTime.TryParseExact(fechaRetiroUsuario, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaUsuario))
            {
                int resultado = DateTime.Compare(fechaUsuario, fechaHoy);
                if (resultado < 0)
                {
                    MessageBox.Show("La fecha ingresada de retiro no es válida, ingrese una fecha mayor o igual a la actual.", "Fecha de retiro incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Formato de fecha de retiro incorrecto. Ingrese una fecha válida (dd/MM/yyyy).", "Fecha de retiro incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Utilidades

        private void ImpedirEntradaNumerica(object sender, KeyPressEventArgs e) // Funcion para no poder escribir letras en los campos numericos
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Evita que se ingrese el caracter no numerico
            }

            // Permite solo un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }



        // Eventos

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarFotos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            Publicar();
        }

        private void grdFotos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorar clicks que no sean en celdas con botón 
            if (e.RowIndex < 0 || e.ColumnIndex != grdFotos.Columns[1].Index) return;
            QuitarFoto(e.RowIndex);
        }
    }
}
