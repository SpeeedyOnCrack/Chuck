using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckNorrisAPI
{
    internal class LoadData
    {
        public void Load(string logFilePath, Label label, PictureBox picturebox)
        {
            if (File.Exists(logFilePath))
            {
                string firstLine = File.ReadLines(logFilePath).FirstOrDefault();
                string lastLine = File.ReadLines(logFilePath).LastOrDefault();
                if (!string.IsNullOrEmpty(firstLine))
                {
                    label.Text = firstLine;
                    picturebox.Load(lastLine);
                }
            }
            else
            {
                File.Create(logFilePath).Close();
            }
        }
    }
}
