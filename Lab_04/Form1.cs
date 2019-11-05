using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Lab_05;

namespace Lab_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Список слов
        /// </summary>
        
        List<string> lst = new List<string>();
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fldlg = new OpenFileDialog();
            fldlg.Filter = "Текстовый файл |*.txt";
            if (fldlg.ShowDialog() == DialogResult.OK)
            {
                Stopwatch time = new Stopwatch();
                time.Start();
                string text = File.ReadAllText(fldlg.FileName);
                char[] separ = { '\n', ' ', '.', ',', '\t', '/', '?' };
                string[] words = text.Split(separ);
                foreach(string word in words)
                {
                    string wrd = word.Trim();
                    if (!lst.Contains(wrd)) lst.Add(wrd);
                }
                time.Stop();
                this.textBoxReadTime.Text = time.Elapsed.ToString();
                this.textBoxCount.Text = lst.Count().ToString();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл.");
            }
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string word = textBoxSearch.Text.Trim();
            if (!string.IsNullOrWhiteSpace(word) && lst.Count > 0)
            {
                word = word.ToUpper();
                List<string> res = new List<string>();
                int maxdst;
                if (!int.TryParse(this.textBoxDist.Text.Trim(), out maxdst))
                {
                    MessageBox.Show("Введены неверные данные.");
                }
                else
                {
                    Stopwatch t = new Stopwatch();
                    t.Start();
                    foreach (string wrd in lst)
                    {
                        int dst = Levenstain.Distance(wrd.ToUpper(), word);
                        if ( dst <= maxdst)
                        {
                            res.Add(wrd);
                        }
                    }
                    t.Stop();
                    this.textBoxTimeSearch.Text = t.Elapsed.ToString();
                    this.listBoxResult.BeginUpdate();
                    this.listBoxResult.Items.Clear();

                    foreach (string wrd in res)
                    {
                        this.listBoxResult.Items.Add(wrd);
                    }
                    this.listBoxResult.EndUpdate();
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }
        }

        private void LabelTimeSearch_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxTimeSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
