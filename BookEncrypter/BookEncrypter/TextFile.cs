using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookEncrypter
{
    public class TextFile
    {
        private string _text;

        public TextFile()
        {
            readFromFile();
        }

        public TextFile(string s)
        {
            Text = s;
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

        public void readFromFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
            openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile.Title = "Select a text file to open";

            DialogResult result = openFile.ShowDialog();
            string fileName = null;

            if (result == DialogResult.OK)
            {
                fileName = openFile.FileName;
                if (String.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                        StreamReader fileReader = new StreamReader(input);
                        this.Text = fileReader.ReadToEnd();
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error reading from file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void writeToFile()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
            saveFile.Filter = "txt files (*.txt)|*.txt";
            saveFile.Title = "Select a location to save this file";

            DialogResult result = saveFile.ShowDialog();
            string fileName = null;

            if(result == DialogResult.OK)
            {
                fileName = saveFile.FileName;
                if (String.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        File.WriteAllText(fileName, this.Text);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error writing to file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void overWriteText(String s)
        {
            this.Text = s;
        }
    }
}
