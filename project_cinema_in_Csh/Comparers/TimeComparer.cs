using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace project_cinema_in_Csh.Comparers
{
    class TimeComparer : IComparer
    {
       

        public int Compare(object x, object y)
        {
            string valueStr1 = x.ToString();
            string valueStr2 = y.ToString();

            int switcher = 0;

            string word1 = "";
            string word2 = "";

            int firstFalue, secondFalue, i = 0;



            while (switcher!= 2 )
            {
                if (valueStr1[i] == ':')
                {
                    switcher++;
                }
                if (switcher == 1 && valueStr1[i] != ' ' && valueStr1[i] != ':') 
                {
                    word1 += valueStr1[i];
                }
               
                
                i++;
            }

            switcher = i = 0;

            while (switcher != 2)
            {
                if (valueStr2[i] == ':')
                {
                    switcher++;
                }
                if (switcher == 1 && valueStr2[i] != ' ' && valueStr2[i] != ':')
                {
                    word2 += valueStr2[i];
                }
               
               
                i++;
            }

            firstFalue = int.Parse(word1);
            secondFalue = int.Parse(word2);


            if (firstFalue > secondFalue) return 1;
            else if (firstFalue < secondFalue) return -1;
            else return 0;
        }
    }
}
