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
    public partial class Registropiexas : Form
    {
        public Registropiexas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor1 = textBox1.Text;
            string valor2 = textBox3.Text;
            string valor3 = textBox2.Text;
            string valor4 = textBox4.Text;
            

            // Agregar los valores al DataGridView
            dataGridView1.Rows.Add(valor1, valor2, valor3, valor4);

            // Limpiar los controles después de agregar los valores
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox4.Clear();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea eliminar el registro?";
            string titulo = "Eliminandi el reguistro";

            if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eliminando",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un renglon", "Eliminando",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debes seleccionar un renglon", "Modificando estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                textBox3.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["Apellidos"].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells["Matricula"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["Carrera"].Value.ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow renglon = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                renglon.Cells[0].Value = textBox1.Text;
                renglon.Cells[1].Value = textBox3.Text;
                renglon.Cells[2].Value = textBox2.Text;
                renglon.Cells[3].Value = textBox4.Text;
               

                dataGridView1.Rows.Add(renglon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando estudianre",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }
}
