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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            for (int i = 0; i < Content.Univer[Content.NumToShow].Students.Length; i++)
                if (Content.Univer[Content.NumToShow].Students[i] == Convert.ToInt32(textBox1.Text) - 1) counter++;
            if(counter != 10) 
            { 
                Content.Univer[Content.NumToShow].Students[Convert.ToInt32(textBox2.Text)-1] = Convert.ToInt32(textBox1.Text) - 1;
                Close();
            }
            else 
            {
                MessageBox.Show("За одним викладачем може бути\n закріплено не більше ніж 10 студентів!", "Помилка");
                Close();
            }
           }
    }
}
