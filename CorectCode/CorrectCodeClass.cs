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
            int count2 = 0;
            int count = 0;
            int i = 0;
            while (i <= 9)
            {
                count = Convert.ToInt32(Char.GetNumericValue(candidat[i]));

              

                count2 += count;
                i++;
            }
            int last = Convert.ToInt32(Char.GetNumericValue(candidat.Last()));

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
