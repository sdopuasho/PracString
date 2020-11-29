using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3GAN
{
    class OperationOnStringMass
    {
        int Count = 0;
        public int CountFirstAndSecond(string[] MassString)
        {
            
            for (int i = 0; i < MassString.Length; i++)
            {
                int masslengt= MassString[i].Length-1;
                if (MassString[i].Substring(0,1) == MassString[i].Substring(masslengt, 1))
                {
                    Count++;
                }
            }
            
            return Count;
        }
        /*Продублировать слово с указанным номером. Номер считать г: клавиатуры.*/
        public string[] CopyChart(string[] MassString, int number)
        {
            string[] ResultArray = new string[MassString.Length+1];
            for (int i = 0; i < MassString.Length; i++)
            {
                if (i < number)
                {
                    ResultArray[i] = MassString[i];
                }
                else if (i == number)
                {
                    ResultArray[i] = MassString[i];
                    ResultArray[i+1] = MassString[i];
                }
                else
                {
                    ResultArray[i + 1] = MassString[i];
                }
            }
            return ResultArray;
        }
        /*Преобразовать текст по правилу: слова на четных местах переписать в обратном порядке, а слова на нечетных местах укоротить до четырех символов .*/
        public string[] ChangeForRule(string[] MassString)
        {
            string[] ResultMassOfString = new string[MassString.Length];
            for (int i = 0; i < MassString.Length; i++)
            {
                if (i % 2 == 0)
                {
                    char[] arr = MassString[i].ToCharArray();
                    Array.Reverse(arr);
                    string temp = new string(arr);
                    ResultMassOfString[i] = temp;
                }
                else
                {
                    if (MassString[i].Length < 4)
                    {
                        ResultMassOfString[i] = MassString[i];
                    }
                    else
                    {
                        ResultMassOfString[i] = MassString[i].Substring(0, 4);
                    }
                   
                }
            }
            return ResultMassOfString;
        }
    }
}
