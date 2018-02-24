using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace _1er_Proyecto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Image fondo2 = Image.FromFile(@"C: \Users\Jalil Raziel\Downloads\transparente.jpg");
            Image fondo1 = Image.FromFile(@"C: \Users\Jalil Raziel\Downloads\untitled.png");
            
            listView1.BackgroundImage = fondo2;
           
            int i = 0;
            string sLine = "";
            ListBox Contenedor = new ListBox();
            using (System.IO.StreamReader Lista = new System.IO.StreamReader("C:\\Users\\Jalil Raziel\\Documents\\graficas\\Nueva carpeta (2)\\ya_me_arte\\1er_Proyecto\\1er_Proyecto\\Lista.txt"))
            {
                while (sLine != null)
                {
                    sLine = Lista.ReadLine();
                    if (sLine != null)
                    {
                        Contenedor.Items.Add(sLine);
                    }
                }
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }
    }
}
