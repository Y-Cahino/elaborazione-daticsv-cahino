using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elaborazione_daticsv_cahino
{
    internal class funzioni
    {
        public int campi(string filename, char lim)
        {
            StreamReader sr = new StreamReader(filename);
            string s = sr.ReadLine();
            sr.Close();
            return s.Split(lim).Length;
        }
        public void RandeLog(string filename, string filename1, char delim)
        {
            Random r = new Random();
            StreamWriter sw = new StreamWriter(filename, append: false);
            StreamReader sr = new StreamReader(filename1);
            string s = sr.ReadLine();
            int i = 0;
            while (s != null)
            {
                if (i == 0)
                {
                    sw.WriteLine(s + delim + "MioValore" + delim + "Cancellazione logica");
                }
                else
                {
                    sw.WriteLine(s + delim + r.Next(10, 20) + delim + "true");
                }
                s = sr.ReadLine();
                i++;
            }
            sr.Close();
            sw.Close();
        }
        public string Long(string filename1, char delim)
        {
            string longest = string.Empty;
            StreamReader sr = new StreamReader(filename1);
            string s;
            int i = 0;
            string[] temp = new string[campi(filename1, delim)];
            while ((s = sr.ReadLine()) != null)
            {
                temp = s.Split(delim);
                if (i != 0)
                {
                    for (int j = 0; j < temp.Length; j++)
                    {
                        if (longest.Length < temp[j].Length)
                        {
                            longest = temp[j];
                        }
                    }
                }
                i++;
            }
            sr.Close();

            return longest;
        }
        public void spnec(string filename, string filename1)
        {
            string s;
            StreamWriter sw = new StreamWriter(@"temporaneo.csv");
            StreamReader sr = new StreamReader(filename1);
            int i = 0;
            while ((s = sr.ReadLine()) != null)
            {
                if (i == 0)
                {
                    sw.WriteLine(s.PadRight(220));
                }
                else
                {
                    sw.WriteLine(s);
                }
                i++;
            }
            sw.Close();
            sr.Close();
            File.Replace(@"temporaneo.csv", filename, @"backup.csv");
            File.Delete(@"backup.csv");
        }
    }
}
