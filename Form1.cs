using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            if(Content.AmOfUn != 0) label1.Text = Content.Univer[Content.NumToShow].ToString();
            label2.Text = String.Format("Кількість університетів: {0}", Content.AmOfUn.ToString());
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (Content.Universities.Count == 0) label1.Text = "Немає жодного університета в записах";
            else label1.Text = Content.Univer[Content.NumToShow].ToString();
            Content.NumToShow = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Content.Universities.Count == 0) label1.Text = "Немає жодного університета в записах";
            else label1.Text = Content.Univer[Content.NumToShow].ToString();
            label2.Text = String.Format("Кількість університетів: {0}",Content.AmOfUn.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
                if (Content.Universities.Count == 0) label1.Text = "Немає жодного університета в записах";
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e) //Попередній
        {
            if (Content.NumToShow - 1 >= 0) Content.NumToShow--;
            if (Content.Universities.Count == 0) label1.Text = "Немає жодного університета в записах";
            else label1.Text = Content.Univer[Content.NumToShow].ToString();
            Update();
        }

        private void button4_Click(object sender, EventArgs e) //Наступний
        {
            if (Content.NumToShow + 1 < Content.AmOfUn) Content.NumToShow++;
            if (Content.Universities.Count == 0) label1.Text = "Немає жодного університета в записах";
            else label1.Text = Content.Univer[Content.NumToShow].ToString();
            Show();
        }

        private void button2_Click(object sender, EventArgs e) //Видалення
        {
            if (Content.AmOfUn != 0)
            {
                Content.RemoveUniversity(Content.Universities, Content.Univer[Content.NumToShow]);
                if (Content.Universities.Count == 0) label1.Text = "Немає жодного університета в записах";
                else label1.Text = Content.Univer[Content.NumToShow].ToString();
                label2.Text = String.Format("Кількість університетів: {0}", Content.AmOfUn.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Content.AmOfUn != 0)
            {
                Form3 form = new Form3();
                form.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Немає університетів!");

            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (Content.AmOfUn != 0)
            {
                Form4 form = new Form4();
                form.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Немає університетів!");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Content.AmOfUn != 0)
            {
                    Form6 form = new Form6();
                    form.Show();
                    Hide();
            }
            else
            {
                MessageBox.Show("Немає університетів!");

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Content.AmOfUn != 0)
            {
                Form7 form = new Form7();
                form.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Немає університетів!");

            }
        }
    }
}
