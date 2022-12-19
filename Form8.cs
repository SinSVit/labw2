using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            for(int i = 0; i < Content.Univer[Content.NumToShow].Engineers.Length; i++)
            {
                if (Content.Univer[Content.NumToShow].Engineers[i] == Content.StudentNum) counter++;
            }
            if (counter < 2)
            {
                int temp = Convert.ToInt32(textBox1.Text);
                Content.Univer[Content.NumToShow].Engineers[temp - 1] = Content.StudentNum;
            }
            else
            {
               
                MessageBox.Show("Не більше двох інженерів на одну аудиторію");
            }
            Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
        }
    }
}
