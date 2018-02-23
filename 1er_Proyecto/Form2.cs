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
            string sLine = "";
            using (System.IO.StreamReader Lista = new System.IO.StreamReader("C:\\Users\\Jalil Raziel\\Documents\\graficas\\Nueva carpeta (2)\\ya_me_arte\\1er_Proyecto\\1er_Proyecto\\Lista.txt"))
            {
                while (sLine != null)
                {
                    sLine = Lista.ReadLine();
                    if (sLine != null)
                        listView1.Items.Add(sLine);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
