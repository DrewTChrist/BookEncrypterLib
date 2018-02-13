using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEncrypter
{
    public class CipherTextMessage : Message
    {
        public CipherTextMessage(string s) : base(s) { }

        public CipherTextMessage() { }

        public ClearTextMessage Decode(CodeBook codebook)
        {
            ClearTextMessage result = new ClearTextMessage();
            List<int> numberlist = this.Text.Split(null).ToList().Select(int.Parse).ToList();
            foreach (int i in numberlist)
            {
                if(i == -1)
                {
                    result.Text += "-1";
                    result.Text += ' ';
                }
                else
                {
                    Random rand = new Random();
                    result.Text += codebook.BookMap.FirstOrDefault(x => x.Value.Contains(i)).Key;
                    result.Text += ' ';
                }

            }
            result.Text = result.Text.Trim();
            return result;
        }
    }
}
