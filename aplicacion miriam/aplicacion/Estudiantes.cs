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
    public partial class Estudiantes : Form
    {
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void dataEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow renglon = (DataGridViewRow)dataEstudiante.Rows[0].Clone();
                renglon.Cells[0].Value = textBox1.Text;
                renglon.Cells[1].Value = textBox3.Text;
                renglon.Cells[2].Value = textBox2.Text;
                renglon.Cells[3].Value = comboBox1.Text;
                renglon.Cells[4].Value = comboBox2.Text;

                dataEstudiante.Rows.Add(renglon);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando estudianre",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los controles
            string valor1 = textBox1.Text;
            string valor2 = textBox3.Text;
            string valor3 = textBox2.Text;
            string valor4 = comboBox1.Text;
            string valor5 = comboBox2.Text;

            // Agregar los valores al DataGridView
            dataEstudiante.Rows.Add(valor1, valor2, valor3, valor4, valor5);

            // Limpiar los controles después de agregar los valores
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
        

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea eliminar el registro?";
            string titulo = "Eliminandi el reguistro";

            if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dataEstudiante.Rows.Remove(dataEstudiante.CurrentRow);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eliminando estudiante",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un renglon", "Eliminando estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(dataEstudiante.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debes seleccionar un renglon", "Modificando estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                textBox3.Text = dataEstudiante.CurrentRow.Cells["Nombre"].Value.ToString();
                textBox2.Text = dataEstudiante.CurrentRow.Cells["Apellidos"].Value.ToString();
                textBox1.Text = dataEstudiante.CurrentRow.Cells["Matricula"].Value.ToString();
                comboBox1.Text = dataEstudiante.CurrentRow.Cells["Carrera"].Value.ToString();
                comboBox2.Text = dataEstudiante.CurrentRow.Cells["Grupo"].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
