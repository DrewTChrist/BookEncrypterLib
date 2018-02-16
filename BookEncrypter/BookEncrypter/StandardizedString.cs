using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookEncrypter
{
    public class StandardizedString
    {
        private string _text;

        public StandardizedString(String s)
        {
            removePunctuation(ref s);
            removeSpaces(ref s);
            this.Text = s.Trim().ToLower();

        }

        public StandardizedString()
        {
            Text = "";
        }

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public void removePunctuation(ref string s)
        {
            s = Regex.Replace(s, @"[^\w\s]", "");
        }

        public void removeSpaces(ref string s)
        {
            s = Regex.Replace(s, @"\s+", " ");
        }
    }
}
