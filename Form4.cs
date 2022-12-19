using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        int AOS = Content.Univer[Content.NumToShow].Students.Length;
        String stud = "";
        int Studnum = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Text = String.Format("Студенти - {0}", Content.Univer[Content.NumToShow].Name);
                if (AOS != 0)
                {
                label1.Text = String.Format("Кількість студентів: {0}", AOS);
                stud = String.Format("Студент №{0}", Studnum+1);
                if (Content.Univer[Content.NumToShow].Students[Studnum] != -1) stud += String.Format("\nЗакріплений за викладачем №{0}", Content.Univer[Content.NumToShow].Students[Studnum]+1);
                else stud += String.Format("\nНемає викладача");
                label2.Text = stud;

                }
                else
                {
                    label1.Text = String.Format("Кількість студентів: {0}", AOS);
                    label2.Text = String.Format(" ");
            }

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Content.Univer[Content.NumToShow].Student(true);
            AOS = Content.Univer[Content.NumToShow].Students.Length;
            label1.Text = String.Format("Кількість студентів: {0}", AOS);
            stud = String.Format("Студент №{0}", Studnum + 1);
            if (Content.Univer[Content.NumToShow].Students[Studnum] != -1) stud += String.Format("\nЗакріплений за викладачем №{0}", Content.Univer[Content.NumToShow].Students[Studnum] + 1);
            else stud += String.Format("\nНемає викладача");
            label2.Text = stud;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Content.StudentNum = Studnum;
            if (AOS != 0) { Content.Univer[Content.NumToShow].Student(false);
                
            }
            AOS = Content.Univer[Content.NumToShow].Students.Length;
            if (AOS == 0) label2.Text = String.Format(" ");
            if (AOS > 0 && Studnum!=0)
            {
                Studnum--;
                stud = String.Format("Студент №{0}", Studnum + 1);
                if (Content.Univer[Content.NumToShow].Students[Studnum] != -1) stud += String.Format("\nЗакріплений за викладачем №{0}", Content.Univer[Content.NumToShow].Students[Studnum] + 1);
                else stud += String.Format("\nНемає викладача");
                label2.Text = stud;
            }
            label1.Text = String.Format("Кількість студентів: {0}", AOS);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AOS != 0)
            {
                Form5 form = new Form5();
                form.Show();
            }
            else
            {
                MessageBox.Show("Немає студентів!");

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(Studnum > 0) 
            {
                Studnum--;
                stud = String.Format("Студент №{0}", Studnum + 1);
                if (Content.Univer[Content.NumToShow].Students[Studnum] != -1) stud += String.Format("\nЗакріплений за викладачем №{0}", Content.Univer[Content.NumToShow].Students[Studnum] + 1);
                else stud += String.Format("\nНемає викладача");
                label2.Text = stud; 
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Studnum < AOS - 1)
            {
                Studnum++;
                stud = String.Format("Студент №{0}", Studnum + 1);
                if (Content.Univer[Content.NumToShow].Students[Studnum] != -1) stud += String.Format("\nЗакріплений за викладачем №{0}", Content.Univer[Content.NumToShow].Students[Studnum] + 1);
                else stud += String.Format("\nНемає викладача");
                label2.Text = stud;
            }
        }
    }
}
