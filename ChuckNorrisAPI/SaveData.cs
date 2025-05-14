using System;
using System.IO;
using System.Windows.Forms;

namespace ChuckNorrisAPI
{
    internal class SaveData
    {
        public void Save(string logFilePath, string value, string icon_url)
        {
            string searchQuery = value;
            string searchQuery1 = icon_url;
            if (!string.IsNullOrEmpty(searchQuery) && !string.IsNullOrEmpty(searchQuery1))
            {
                File.AppendAllText(logFilePath, searchQuery + Environment.NewLine);
                File.AppendAllText(logFilePath, searchQuery1 + Environment.NewLine);
            }
        }
    }
}
