using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringReverseClass
{
    public class StringReverseYu_HsuanHuang
    {
        public StringReverseYu_HsuanHuang()
        { }
        public StringReverseYu_HsuanHuang(string forwardString)
        {
            originalString = forwardString;
        }

        private string originalString;
        public string OriginalString
        {
            get => originalString;
            set
            {
                if(value.ToLower().Contains("shit"))
                {
                    originalString = "Please try again.";
                }
                else
                {
                    originalString = value;
                }
            }
        }


        public string StringReverse()
        {
            char[] charArray = originalString.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                sb.Append(originalString.ElementAt(i));
            }
            return sb.ToString();

            /*
            char[] charArray = originalString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
            */
        }
    }
}
