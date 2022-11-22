using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorectCodeLibrary
{
    public class CorrectCodeClass
    {
        /// <summary>
        /// Проверка "кода" на правильность введённых чисел
        /// </summary>
        /// <param name="candidate">
        /// Строка, содержащая "код"
        /// </param>
        /// <returns>
        /// возвращает true or false
        /// </returns>
        public static bool IsCorrectCode(string candidate)
        {
            var candidat = candidate.Where(x=>char.IsDigit(x)).ToArray();

            if (candidat.Length < 10 || candidat.Any(x=>char.IsLetter(x))||candidat.Length>=11)
            {
                return false;
            }
            for (int i = 0; i < candidat.Length; i++)
            {
                int count=0;
                while(i==9)
                {
                 count = Convert.ToInt32(candidat[i]);
                }
                
                int last = Convert.ToInt32(candidat[9]);
                int count2 = 0;
                count2 += count;
                
                    if (count2 % 10 == 0 && last == 0)
                    {
                        return true;
                    }
                    if (count2 % 3 == 0 && last == 1)
                    {
                        return true;
                    }
                    if (last == 9)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                
            }
            return false;
        }
    }
}
