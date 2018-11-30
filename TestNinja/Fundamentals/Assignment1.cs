using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestNinja.Fundamentals
{
    public class Assignment1
    { 
        public int MatchingWords(string a, string b)
        {
            //екі сөздің ұзындығын салыстырамыз
            if (a.Length==b.Length)
                //екі сөз ұзындығы бір-біріне тең болса "1" мәнін қайтарады
                return 1;

            if (a.Length!=b.Length)
                //екі сөз ұзындығы бір-біріне тең болмаса "0" мәнін қайтарады
                return 0;
            return 1;
        }
    }
}