using Proyecto3._0.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        // keypress es un evento que detecta las teclas que son presionadas en el textbox.
        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <=47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {


            DialogResult ask = MessageBox.Show("Está a punto de eliminar el cliente:" + TNombre.Text + " " + TApellido.Text + '"', "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            
            if(ask == DialogResult.Yes)
            {
                TDni.Clear();
                TApellido.Clear();
                TNombre.Clear();
                TTelefono.Clear();
                RBVaron.Checked = true;

                LModificar.ForeColor = Color.Red;
            }
        
        }
        
        private void BGuardar_Click(object sender, EventArgs e)
        {

            


            if (string.IsNullOrWhiteSpace(TApellido.Text) || string.IsNullOrWhiteSpace(TDni.Text) || string.IsNullOrWhiteSpace(TNombre.Text) || string.IsNullOrWhiteSpace(TTelefono.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
            }
            else
            {
                LModificar.ForeColor = Color.Black;

                // la variable tipo dialogResult devuelve true or false
                DialogResult ask = MessageBox.Show("Seguro que desea insertar un nuevo Cliente?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if(ask == DialogResult.Yes) {
                    MessageBox.Show("El cliente: " + TNombre.Text + " " + TApellido.Text + " " + "se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void Bsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = null;

            if(RBVaron.Checked == true)
            {
                String rutaVaron = "C:\\Users\\Usuario\\source\\repos\\Proyecto3.0\\Resources\\hombre.png";
                pictureBox1.BackgroundImage = Image.FromFile(rutaVaron);
            }
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = null;

            if (RBMujer.Checked == true)
            {
                String rutaMujer = "C:\\Users\\Usuario\\source\\repos\\Proyecto3.0\\Resources\\mujer.png";
                pictureBox1.BackgroundImage = Image.FromFile(rutaMujer);
            }
        }
    }
}
