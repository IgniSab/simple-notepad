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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }



        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.Filter = "Текстовый файл (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
                streamWriter.WriteLine(richTextBox1.Text);
                streamWriter.Close();
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.Filter = "Текстовый файл (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
           
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = streamReader.ReadLine();
                streamReader.Close();

                

            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.SelectionFont;
            fontDialog1.Color = richTextBox1.SelectionColor;


            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
         
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.Show();
        }

        private void новоеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

    
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

     
    }
}
