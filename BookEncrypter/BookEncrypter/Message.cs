using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEncrypter
{
    public class Message : StandardizedString
    {

        public Message(string s) : base(s) { }
        public Message() { }
    }
}
