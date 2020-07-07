using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectLab
{
    class Message:IMessage
    {
        public string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IMessage.Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Send()
        {
            Console.Write("Message Sent.");
        }

        public override string ToString()
        {
            //return base.ToString();
            return "Message Body: example text." ;
        }

        bool IMessage.Send()
        {
            throw new NotImplementedException();
        }
    }
}
