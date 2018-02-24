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

    public partial class Form1 : Form
    {
        int Contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            { 
            listBox1.Items.Add(textBox1.Text);
            Contador++;
            textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sLine = "";
            StreamReader Lista = new StreamReader("C:\\Users\\Jalil Raziel\\Documents\\graficas\\Nueva carpeta (2)\\ya_me_arte\\1er_Proyecto\\1er_Proyecto\\Lista.txt");
            while (sLine != null)
            {
                sLine = Lista.ReadLine();
                if (sLine != null)
                {
                    listBox1.Items.Add(sLine);
                    Contador++;
                }
            }
            Lista.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            Contador--;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            StreamWriter Lista = new StreamWriter("C:\\Users\\Jalil Raziel\\Documents\\graficas\\Nueva carpeta (2)\\ya_me_arte\\1er_Proyecto\\1er_Proyecto\\Lista.txt");
            while (i != Contador)
            {
                Lista.WriteLine(listBox1.Items[i].ToString());
                i++;
            }
            Lista.Close();
            
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
