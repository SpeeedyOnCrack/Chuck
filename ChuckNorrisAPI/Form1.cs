using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckNorrisAPI
{
    public partial class Form1 : Form
    {
        SaveData saveData = new SaveData();
        LoadData loadData = new LoadData();
        public Form1()
        {
            InitializeComponent();
            LoadLastSearch();
        }
        private void LoadLastSearch()
        {
            loadData.Load("ChuckNorissFacts.txt", label2, pictureBox1);
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            var apiHandler = new ApiHandler();
            Vtipy fact = await apiHandler.GetFact();


            if (fact != null)
            {
                if (!string.IsNullOrEmpty(fact.icon_url))
                {
                    pictureBox1.Load(fact.icon_url);
                }

                label2.Text = $"{fact.value}";



                saveData.Save("ChuckNorissFacts.txt", fact.value, fact.icon_url);
            }
            else
            {
                MessageBox.Show("Nepodařilo se načíst.");
            }
        }
    }
}
