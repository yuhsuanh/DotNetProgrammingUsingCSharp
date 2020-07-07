using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectLab
{
    class SMS:Message
    {
        public string recipientMobileNumber;
        public override string ToString()
        {
            //return base.ToString();
            return "Message Body: Hello";
        }
    }
}
