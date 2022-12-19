using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public static class Content
    {
        public static int AmOfUn = 0;
        public static int StudentNum = 0;
        public static int NumToShow = 0;
        public static University[] Univer = new University[AmOfUn]; 
        public static UIEcomparer boxEqC = new UIEcomparer();
        public static Dictionary<University, string> Universities = new Dictionary<University, string>(boxEqC);
        public static void AddUniversity(Dictionary<University, String> dict, University A, String name)
        {
            
            try
            {
                dict.Add(A, name);
                int i = 0;
                AmOfUn++;
                University[] temp = new University[AmOfUn];
                while (i < AmOfUn - 1)
                {
                    temp[i] = Univer[i];
                    i++;
                }
                temp[i] = A;
                Univer = temp;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Unable to add {0}: {1}", A, e.Message);
            }
            
        }
        public static void RemoveUniversity(Dictionary<University, String> dict, University A)
        {
            
            dict.Remove(A);
            int i = 0, counter = 0;
            AmOfUn--;
            University[] temp = new University[AmOfUn];
            while (i < AmOfUn)
            {
                if (i == NumToShow) { i++; continue; }
                temp[counter] = Univer[i];
                i++;
                counter++;
            }
            Univer = temp;
            NumToShow = 0;
        }
    }
}
