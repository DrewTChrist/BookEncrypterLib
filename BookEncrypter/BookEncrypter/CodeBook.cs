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
            Key = book.Split(null).ToList();
            BookMap = Key.Select((n, i) => new { Value = n, Index = i }).GroupBy(a => a.Value).ToDictionary(g => g.Key, g => g.Select(a => a.Index).ToList());
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
