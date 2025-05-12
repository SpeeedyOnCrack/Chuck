using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckNorrisAPI
{
    internal class SaveData
    {
        public void Save(string logFilePath, TextBox )
        {
            string searchQuery = textBox2.Text;
            if (!string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Uloženo!");
                File.AppendAllText(logFilePath, searchQuery + Environment.NewLine);
            }
        }
    }
}
