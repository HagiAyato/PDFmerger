using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            // ファイルを選択し、それをすべてDataGridViewに入れる
            if (UIpg.openFileSelect(textBox1.Text, ref selectedPaths))
            {
                foreach (string selectedPath in selectedPaths)
                {
                    dataGridView1.Rows.Add(Path.GetFileName(selectedPath), selectedPath);
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
            //DataGridView1で選択されているすべての行を削除する
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
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

        /// <summary>
        /// ファイルドラッグアンドドロップ時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            // ドロップされたファイルをPDFファイルのみすべてDataGridViewに入れる
            foreach (string selectedPath in (string[])e.Data.GetData(DataFormats.FileDrop, false))
            {
                if(Path.GetExtension(selectedPath) == ".pdf")
                dataGridView1.Rows.Add(Path.GetFileName(selectedPath), selectedPath);
            }
        }

        /// <summary>
        /// DataGridView領域内にマウスポインタが入った際の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // エクスプローラのファイルドロップであればドロップ受付
                e.Effect = DragDropEffects.All;
            }
            else
            {
                // 上記以外ならドロップ拒否
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// ▲一番上へボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            List<DataGridViewRow> buffer = new List<DataGridViewRow>();
            // バッファに選択行を入れる + 一度削除
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                buffer.Add(row);
                dataGridView1.Rows.Remove(row);
            }
            // バッファのデータを挿入していく
            for(int i = 0;i < buffer.Count; i++)
            {
                dataGridView1.Rows.Insert(i, buffer[i]);
            }
            button5.Enabled = true;
        }

        /// <summary>
        /// △一行上へボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            //// 挿入index決定
            //int insindex = Math.Max(dataGridView1.SelectedRows[0].Index, 0);
            //List<DataGridViewRow> buffer = new List<DataGridViewRow>();
            //// バッファに選択行を入れる + 一度削除
            //foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //{
            //    buffer.Add(row);
            //    dataGridView1.Rows.Remove(row);
            //}
            //// バッファのデータを挿入していく
            //for (int i = 0; i < buffer.Count; i++)
            //{
            //    dataGridView1.Rows.Insert(insindex + i, buffer[i]);
            //}
            button6.Enabled = true;
        }

        /// <summary>
        /// ▽一行下へボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            button7.Enabled = true;
        }

        /// <summary>
        /// ▼一番下へボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            List<DataGridViewRow> buffer = new List<DataGridViewRow>();
            // バッファに選択行を入れる + 一度削除
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                buffer.Add(row);
                dataGridView1.Rows.Remove(row);
            }
            // バッファのデータを挿入していく
            int rowcount = dataGridView1.RowCount;
            for (int i = 0; i < buffer.Count; i++)
            {
                dataGridView1.Rows.Insert(rowcount + i, buffer[i]);
            }
            button8.Enabled = true;
        }
    }
}
