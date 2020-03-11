using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recoleccion_de_datos
{
    public partial class Cargar : Form
    {
        public Cargar()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFile.FileName;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
