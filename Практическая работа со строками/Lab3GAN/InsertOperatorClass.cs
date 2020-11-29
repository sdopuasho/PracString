using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3GAN
{
    class InsertOperatorClass
    {
        public string[] ClassInsert(string str)
        {
            string[] StrArray = str.Split(new[] { ' ', ']','[',',','(',')','.','!', '&' }, StringSplitOptions.RemoveEmptyEntries);
            return StrArray;
        }
    }
}
