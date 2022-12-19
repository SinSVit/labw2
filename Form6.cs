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
    public partial class Form6 : Form
    {
        int LabNum = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Text = String.Format("Лекційні аудиторії - {0}", Content.Univer[Content.NumToShow].Name);
            String text = String.Format("Лекційна аудиторія №{0}\n", (LabNum + 1));
            int counter = 0;
            for (int i = 0; i < Content.Univer[Content.NumToShow].Engineers.Length; i++)
            {
                if (Content.Univer[Content.NumToShow].Engineers[i] == LabNum)
                {
                    counter++;
                    text += String.Format("\nІнженер №{0} - {1}", counter, (i + 1));
                }
            }
            label2.Text = String.Format("Кількість аудиторій: {0}", Content.Univer[Content.NumToShow].Auditory[1]);
            if (counter == 0) text += String.Format("\nІнженерів немає");
            label1.Text = text;
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Content.StudentNum = LabNum;
            Form8 frm = new Form8();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Content.Univer[Content.NumToShow].Auditories(false, true);
            label2.Text = String.Format("Кількість лабораторій: {0}", Content.Univer[Content.NumToShow].Auditory[1]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Content.StudentNum = LabNum;
            Content.Univer[Content.NumToShow].Auditories(false, false);
            LabNum--;
            String text = String.Format("Лабораторія №{0}\n", (LabNum + 1));
            int counter = 0;
            for (int i = 0; i < Content.Univer[Content.NumToShow].Engineers.Length; i++)
            {
                if (Content.Univer[Content.NumToShow].Engineers[i] == LabNum)
                {
                    counter++;
                    text += String.Format("\nІнженер №{0} - {1}", counter, (i + 1));
                }
            }
            if (counter == 0) text += String.Format("\nІнженерів немає");
            label1.Text = text;
            label2.Text = String.Format("Кількість аудиторій: {0}", Content.Univer[Content.NumToShow].Auditory[1]);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LabNum > 0)
            {
                LabNum--;
                String text = String.Format("Лабораторія №{0}\n", (LabNum + 1));
                int counter = 0;
                for (int i = 0; i < Content.Univer[Content.NumToShow].Engineers.Length; i++)
                {
                    if (Content.Univer[Content.NumToShow].Engineers[i] == LabNum)
                    {
                        counter++;
                        text += String.Format("\nІнженер №{0} - {1}", counter, (i + 1));
                    }
                }
                if (counter == 0) text += String.Format("\nІнженерів немає");
                label1.Text = text;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LabNum < Content.Univer[Content.NumToShow].Auditory[0])
            {

                LabNum++;
                String text = String.Format("Лабораторія №{0}\n", (LabNum + 1));
                int counter = 0;
                for (int i = 0; i < Content.Univer[Content.NumToShow].Engineers.Length; i++)
                {
                    if (Content.Univer[Content.NumToShow].Engineers[i] == LabNum)
                    {
                        counter++;
                        text += String.Format("\nІнженер №{0} - {1}", counter, (i + 1));
                    }
                }
                if (counter == 0) text += String.Format("\nІнженерів немає");
                label1.Text = text;
            }
        }
    }
}
