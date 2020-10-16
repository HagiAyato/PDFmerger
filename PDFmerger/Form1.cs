using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFmerger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 結合ファイル名選択ボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            string[] selectedPaths = new string[1];
            if (UIpg.openFileSelect(textBox1.Text, ref selectedPaths))
            {
                foreach(string selectedPath in selectedPaths)
                {
                    dataGridView1.Rows.Add(selectedPath);
                }
            }
            button1.Enabled = true;
        }

        /// <summary>
        /// 結合ファイル名除外ボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button2.Enabled = true;
        }

        /// <summary>
        /// 保存ファイル名選択ボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            string selectedPath = textBox1.Text;
            if (UIpg.mergedFileSelect(textBox1.Text, ref selectedPath)) textBox1.Text = selectedPath;
            button3.Enabled = true;
        }

        /// <summary>
        /// ファイル結合実行ボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button4.Enabled = true;
        }
    }
}
