using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WindowsFormsApp2;

namespace WindowsFormsApp2
{
    public class Auditories
    {
        public int  AOL = 0,    // Лабораторії
                    AOLA = 0;   // Лекційній аудиторії
        public int this[int index]
        {
            get
            {
                if (index == 0) return AOL;
                return AOLA;
            }
            set
            {
                if(index == 0) AOL = value;
                else if(index == 1) AOLA = value;
            }
        }
        public Auditories()
        {

        }
    }
    
    public class University
    {
       
        public string Name;     // Назва закладу
        public int AOF = 0;   // Факультет
        public int AOE = 0;     // Співробітники
        public static int AOT = 0;     // Викладачі
        public static int AOI = 0;     // Инженери
        public static int AOS = 0;     // Кількість студентів
        public Auditories Auditory = new Auditories();
        public int[] Students = new int[AOS];  // Масив студентів

        public int[] Teachers = new int[AOT];  // Масив викладачів

        public int[] Engineers = new int[AOI];  // Масив інженерів
        public University(string Names, int AOFs, int AOLs, int AOLAs, int AOTs, int AOIs)
        {
            Name = Names;
            AOF = AOFs;
            Auditory[0] = AOLs;
            Auditory[1] = AOLAs;
            AOE = AOTs + AOIs;
            AOT = AOTs;
            AOI = AOIs;
            Teachers = new int[AOT];
            for (int i = 0; i < AOT; i++) Teachers[i] = -1;
            Engineers = new int[AOI];
            for (int i = 0; i < AOI; i++) Engineers[i] = -1;
        }
        University(University a)
        {
            Name = a.Name;
            Students = a.Students;
            Auditory = a.Auditory;
            AOE = a.AOE;
            Auditory[0] = a.Auditory[0];
            Auditory[1] = a.Auditory[1];
            Teachers = a.Teachers;
            Engineers = a.Engineers;
        }
        public void Student(bool mode)
        {
            if (mode) //Add
            {
                AOS++;
                int[] temp = new int[AOS];
                int i = 0;
                while (i < AOS - 1) {
                    temp[i] = Students[i];
                    i++;
                }
                temp[i] = -1;
                Students = temp;
            }
            else //remove
            {
                AOS--;
                int[] temp = new int[AOS];
                int i = 0;
                int counter = 0;
                while (i <= AOS)
                {
                    if(i == Content.StudentNum) { i++; continue; }
                    temp[counter] = Students[i];
                    i++;
                    counter++;
                }
                Students = temp;
                
            }
        }
        public void Auditories(bool type, bool mode)
        {
            if (type) // Лабораторії
            {
                if (mode) //додати
                {
                    Auditory[0]++;
                }
                else
                {
                    Auditory[0]--;
                    for(int i = 0; i < Engineers.Length; i++)
                    {
                        if (Engineers[i] == Content.StudentNum) Engineers[i] = -1;
                    }
                }
            }
            else //Лекційні
            {
                if (mode) //найм
                {
                    Auditory[1]++;
                }
                else
                {
                    Auditory[1]--;
                    for (int i = 0; i < Engineers.Length; i++)
                    {
                        if (Engineers[i] == Content.StudentNum) Engineers[i] = -1;
                    }
                }
            }
        }

        public void Employ( bool Emp, bool mode)
        {
            if(Emp) // Викладач
            {
                if(mode) //найм
                {
                    AOT++;
                }
                else
                {
                    AOT--;
                }
            }   
            else //Інженер
            {
                if (mode) //найм
                {
                    AOI++;
                }
                else
                {
                    AOI--;
                }
            }
            AOE = AOT + AOI;
            if(AOT != Teachers.Length)
            {
                int[] temp = new int[AOT];
                if (AOT < Teachers.Length)
                {
                    for (int i = 0; i < AOT; i++)
                    {
                        temp[i] = Teachers[i];
                    }
                }
                if (AOT > Teachers.Length)
                {
                    for (int i = 0; i < AOT - 1; i++)
                    {
                        temp[i] = Teachers[i];
                    }
                    temp[AOT - 1] = -1;
                }
                Teachers = temp;
            }
            if(AOI != Engineers.Length)
            {
                int[] temp = new int[AOI];
                if (AOI < Engineers.Length)
                    for (int i = 0; i < AOI; i++)
                    {
                        temp[i] = Engineers[i];
                    }
                if (AOI > Engineers.Length)
                {
                    for (int i = 0; i < AOI - 1; i++)
                    {
                        temp[i] = Engineers[i];
                    }
                    temp[AOI - 1] = -1;
                }
                Engineers = temp;
            }

        }

        public static University operator +(University A, University B)
        {

            return A;
        }
        public override String ToString()
        {
            return String.Format("\tНазва:\n{0} \n\n\tФакультети: \n{1}\n\n\tКількість лабораторії \n{2}\n\n\tКількість лекційних аудиторій: \n{3}\n\n\tКількість співробітників(Викладачі/Інженери): \n{4} ({5}/{6})\n\n\tКількість студентів: \n{7}", Name, AOF, Auditory[0], Auditory[1],AOE, AOT, AOI, AOS);
        }

    }
}

public class UIEcomparer : IEqualityComparer<University>
{
    public bool Equals(University A, University B)
    {
        if (A.Name == B.Name)
            return true;
        return false;
    }
    public int GetHashCode(University A)
    {
        int hCode = A.Engineers.Length + A.Teachers.Length + A.AOF*A.Students.Length;
        return hCode.GetHashCode();
    }
}


internal static class Program
{
    
    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>
    ///   

    [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    
}
