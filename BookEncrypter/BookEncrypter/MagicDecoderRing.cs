using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEncrypter
{
    public class MagicDecoderRing
    {
        private CodeBook _book;
        private ClearTextMessage _cleartext;
        private CipherTextMessage _ciphertext;

        public MagicDecoderRing()
        {
            StandardizedString bookString = new StandardizedString(new TextFile().Text);
            this.Book = new CodeBook(bookString.Text);
        }

        public  CodeBook Book
        {
            get
            {
                return _book;
            }
            set
            {
                _book = value;
            }
        }

        public ClearTextMessage ClearText
        {
            get
            {
                return _cleartext;
            }
            set
            {
                _cleartext = value;
            }
        }

        public CipherTextMessage CipherText
        {
            get
            {
                return _ciphertext;
            }
            set
            {
                _ciphertext = value;
            }
        }

        public void addClearTextMessage()
        {
            ClearTextMessage message = new ClearTextMessage(new TextFile().Text);
            ClearText = message;
        }

        public void addCipherTextMessage()
        {
            CipherTextMessage message = new CipherTextMessage(new TextFile().Text);
            CipherText = message;
        }

        public void Encode()
        {
            this.CipherText = this.ClearText.Encode(this.Book);
            this.ClearText.Text = null;
        }

        public void Decode()
        {
            this.ClearText = this.CipherText.Decode(this.Book);
            this.CipherText.Text = null;
        }

        public void saveClearText()
        {
            TextFile filetosave = new TextFile(this.ClearText.Text);
            filetosave.writeToFile();
            this.ClearText.Text = null;
        }

        public void saveCipherText()
        {
            TextFile filetosave = new TextFile(this.CipherText.Text);
            filetosave.writeToFile();
            this.CipherText.Text = null;
        }
    }
}
