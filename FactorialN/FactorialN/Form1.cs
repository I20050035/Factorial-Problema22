using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Factorial clase = new  Factorial();
            //ingresar el numero
            clase.Num_set(int.Parse(textBox1.Text));
            //llamar el metodo para calcular
            clase.calcular();
            //mostrar resultado
            textBox2.Text = clase.fac_regresar() + "";
            MessageBox.Show("El factor es : "+clase.fac_regresar()+"");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //para salir 
            DialogResult salir;
            salir = MessageBox.Show("Deseas salir de la aplicacion?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //borrar contenido del textbox
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
