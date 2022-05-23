using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LR_1
{
    internal class Count
    {
        public string text;
        public static string sum = "";

        public Count (string text)  //Конструктор
            { this.text = text; }   //
        

        public int  CountText()
        {
            sum = Regex.Replace(text, "(?i)[^А-ЯЁA-ZяёА-ЯЁ]", "");
            return sum.Length;
        }
    }
}
