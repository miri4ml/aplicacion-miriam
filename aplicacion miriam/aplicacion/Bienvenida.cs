using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacion_miriam.aplicacion
{
    public partial class REGISTRO : Form
    {
        public REGISTRO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text) ||
                string.IsNullOrWhiteSpace(textApellido.Text) ||
                string.IsNullOrWhiteSpace(textEdad.Text) ||
                string.IsNullOrWhiteSpace(textCorreo.Text) ||
                string.IsNullOrWhiteSpace(textTelefono.Text) ||
                string.IsNullOrWhiteSpace(textDireccion.Text) ||
                string.IsNullOrWhiteSpace(textCargo.Text) ||
                string.IsNullOrWhiteSpace(textSalario.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Validar el formato de los campos
            if (!int.TryParse(textEdad.Text, out int edad) || edad <= 0)
            {
                MessageBox.Show("La edad ingresada no es válida.");
                return;
            }

            if (!IsValidEmail(textCorreo.Text))
            {
                MessageBox.Show("El correo electrónico ingresado no es válido.");
                return;
            }

            if (!long.TryParse(textTelefono.Text, out long telefono) || telefono <= 0)
            {
                MessageBox.Show("El número de teléfono ingresado no es válido.");
                return;
            }

            if (!decimal.TryParse(textSalario.Text, out decimal salario) || salario <= 0)
            {
                MessageBox.Show("El salario ingresado no es válido.");
                return;
            }

            // Realizar el registro del empleado
            // Aquí puedes agregar el código para guardar los datos en una base de datos o hacer cualquier otra acción

            MessageBox.Show("Empleado registrado exitosamente.");
            Estudiantes menu = new Estudiantes();
            menu.Show();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}