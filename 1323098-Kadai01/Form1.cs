using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MyFileLoad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //テキストファイルを作成する

            //テキストボックスから値をとりだす
            string path = textBox1.Text;
            string text = textBox2.Text;
            StreamWriter textFile;
            textFile = new StreamWriter(path, false, System.Text.Encoding.Default);
            textFile.WriteLine(text);
            textFile.WriteLine(string.Format("ファイルの作成時刻は {0} です", DateTime.Now.ToLongTimeString()));
            textFile.Close();
            MessageBox.Show("ファイルを作成しました", "完了");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            if (File.Exists(path) == false)
            {
                MessageBox.Show("ファイルがありません", "エラー");
                return;
            }
            StreamReader textFile;
            textFile = new StreamReader(path, System.Text.Encoding.Default);
            label1.Text = textFile.ReadToEnd();
            textFile.Close();

        }





    }
}
