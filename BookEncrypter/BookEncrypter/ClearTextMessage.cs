using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEncrypter
{
    public class ClearTextMessage : Message
    {
        public ClearTextMessage(string s) : base(s) { }
        public ClearTextMessage() { }
        
        public CipherTextMessage Encode(CodeBook codebook)
        {
            CipherTextMessage result = new CipherTextMessage();
            List<string> wordlist = this.Text.Split(null).ToList();
            Random rand = new Random();
            foreach(string s in wordlist)
            {
                codebook.BookMap.TryGetValue(s, out List<int> value);
                if (value != null && value.Any())
                {
                    result.Text += value[rand.Next(value.Count)];
                    result.Text += ' ';
                }
                else
                {
                    result.Text += "-1";
                    result.Text += ' ';
                }
            }
            result.Text = result.Text.Trim();
            return result;
        }
    }
}
