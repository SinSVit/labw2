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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Text = String.Format("Співробітники - {0}", Content.Univer[Content.NumToShow].Name);
                if (Content.Univer[Content.NumToShow].AOE != 0)
                {
                    label1.Text = String.Format("Кількість співробітників: {0}", Content.Univer[Content.NumToShow].AOE);
                    label2.Text = String.Format("Викладачів: {0}", Content.Univer[Content.NumToShow].Teachers.Length);
                    label3.Text = String.Format("Інженерів: {0}", Content.Univer[Content.NumToShow].Engineers.Length);

                }
                else
                {
                    label1.Text = String.Format("Кількість співробітників: {0}", Content.Univer[Content.NumToShow].AOE);
                }
            
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Content.Univer[Content.NumToShow].Employ(true, true);
            label2.Text = String.Format("Викладачів: {0}", Content.Univer[Content.NumToShow].Teachers.Length);
            label1.Text = String.Format("Кількість співробітників: {0}", Content.Univer[Content.NumToShow].AOE);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Content.Univer[Content.NumToShow].Employ(true, false);
            label2.Text = String.Format("Викладачів: {0}", Content.Univer[Content.NumToShow].Teachers.Length);
            label1.Text = String.Format("Кількість співробітників: {0}", Content.Univer[Content.NumToShow].AOE);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Content.Univer[Content.NumToShow].Employ(false, true);
            label3.Text = String.Format("Інженерів: {0}", Content.Univer[Content.NumToShow].Engineers.Length);
            label1.Text = String.Format("Кількість співробітників: {0}", Content.Univer[Content.NumToShow].AOE);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Content.Univer[Content.NumToShow].Employ(false, false);
            label3.Text = String.Format("Інженерів: {0}", Content.Univer[Content.NumToShow].Engineers.Length);
            label1.Text = String.Format("Кількість співробітників: {0}", Content.Univer[Content.NumToShow].AOE);
        }
    }
}
