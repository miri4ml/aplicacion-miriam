using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacion_miriam
{
    public partial class Form1 : Form
    {
        private int intentos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttoningresar_Click(object sender, EventArgs e)
        {
            string usuario = textname.Text;
            string contraseña = textcontra.Text;
            if (string.IsNullOrEmpty(usuario)||string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Los campos estan vacios,favor de ingresar sus datos");
                return;
            }
            if(usuario.Length)


        }
    }
}
