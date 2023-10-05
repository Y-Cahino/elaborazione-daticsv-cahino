using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elaborazione_daticsv_cahino
{
    internal class funzioni
    {
        public int campi(string filename, char delim)
        {
            StreamReader sr = new StreamReader(filename);
            string s = sr.ReadLine();
            sr.Close();
            return s.Split(delim).Length;
        }
    }
}
