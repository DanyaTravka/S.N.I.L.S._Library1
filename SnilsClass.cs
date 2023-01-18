using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snilsLibrary
{
    public class SnilsClass
    {
        public bool CheckMedicalCode(string textString)
        {
            var numbers = new List<int>();
            string number = "987654321";
            string snilsnumber = textString.Replace(" ", " ");
            if(snilsnumber.Length == 11)
            {
                for (int i = 0; i < snilsnumber.Length - 2; i++)
                {
                    int b = snilsnumber[i] - number[i];
                }
                return true;
            }
            return false;
        }
    }
}
