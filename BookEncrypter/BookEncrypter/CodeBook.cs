using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEncrypter
{
    public class CodeBook
    {
        private List<string> _key;
        private Dictionary<string, List<int>> _bookmap;

        public CodeBook(string book)
        {
            BookMap = new Dictionary<string, List<int>>();
            Key = book.Split(null).ToList();
            foreach(string s in Key)
            {
                if (!BookMap.Keys.Contains(s))
                {
                    BookMap.Add(s, Enumerable.Range(0, Key.Count).Where(i => Key[i] == s).ToList());
                }
            }
        }

        public List<string> Key
        {
            get
            {
                return _key;
            }
            set
            {
                _key = value;
            }
        }

        public Dictionary<string, List<int>> BookMap
        {
            get
            {
                return _bookmap;
            }
            set
            {
                _bookmap = value;
            }
        }
    }
}
