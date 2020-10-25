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
            if (UIpg.openFileSelect(textBox1.Text, "PDFファイル(*.pdf)|*.pdf", ref selectedPaths))
            {
                foreach (string selectedPath in selectedPaths)
                {
                    // データ追加時、IndexNumは0を仮置き
                    dataGridView1.Rows.Add(0, Path.GetFileName(selectedPath), selectedPath);
                }
            }
            // IndexNum再採番
            redimIndexNum();
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
            // IndexNum再採番
            redimIndexNum();
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
            if (UIpg.writeFileSelect(textBox1.Text, "PDFファイル(*.pdf)|*.pdf", ref selectedPath)) textBox1.Text = selectedPath;
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
            // DataGridViewが0件なら、出力をしない
            if (dataGridView1.Rows.Count <= 0)
            {
                button4.Enabled = true;
                return;
            }
            string selectedPath = textBox1.Text;
            if (selectedPath == "")
            {
                // 結合後ファイル未決定の場合
                if (!UIpg.writeFileSelect(textBox1.Text, "PDFファイル(*.pdf)|*.pdf", ref selectedPath))
                {
                    button4.Enabled = true;
                    return;
                }
            }
            else if (File.Exists(selectedPath))
            {
                // 同名ファイル有、かつ上書き不可の場合
                if (MessageBox.Show(selectedPath + "\nは既にあります。\n上書きしますか？", "上書き確認", MessageBoxButtons.OKCancel) == DialogResult.No)
                {
                    button4.Enabled = true;
                    return;
                }
            }
            // 現在の登録中ファイル一覧を作成
            List<string> files = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                files.Add((string)row.Cells[2].Value);
            }
            // 結合実行
            MessageBox.Show(IOpg.pdfMerge(selectedPath, files.ToArray()) ? "結合成功" : "結合失敗");
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
                if (Path.GetExtension(selectedPath) == ".pdf")
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
            // DataGridViewが0～1件なら、並べ替えをしない
            if (dataGridView1.Rows.Count <= 1)
            {
                button5.Enabled = true;
                return;
            }
            List<DataGridViewRow> buffer = new List<DataGridViewRow>();
            // バッファに選択行を入れる + 一度削除
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                buffer.Add(row);
                dataGridView1.Rows.Remove(row);
            }
            // バッファは行番号昇順に並べなおす
            // SelectedRowsで並び順が行順と一致しないため
            buffer.Sort((a, b) => (int)(a.Cells[0].Value) - (int)(b.Cells[0].Value));
            // バッファのデータを挿入していく
            for (int i = 0; i < buffer.Count; i++)
            {
                dataGridView1.Rows.Insert(i, buffer[i]);
            }
            // IndexNum再採番
            redimIndexNum();
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
            // DataGridViewが0～1件なら、並べ替えをしない
            if (dataGridView1.Rows.Count <= 1)
            {
                button6.Enabled = true;
                return;
            }
            //List<DataGridViewRow> buffer = new List<DataGridViewRow>();
            //// バッファに選択行を入れる + 一度削除
            //foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //{
            //    buffer.Add(row);
            //    dataGridView1.Rows.Remove(row);
            //}
            //// バッファは行番号昇順に並べなおす
            //// SelectedRowsで並び順が行順と一致しないため
            //buffer.Sort((a, b) => (int)(a.Cells[0].Value) - (int)(b.Cells[0].Value));
            //// バッファのデータを挿入していく
            //for (int i = 0; i < buffer.Count; i++)
            //{
            //    dataGridView1.Rows.Insert(i, buffer[i]);
            //}
            // IndexNum再採番
            redimIndexNum();
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
            // DataGridViewが0～1件なら、並べ替えをしない
            if (dataGridView1.Rows.Count <= 1)
            {
                button7.Enabled = true;
                return;
            }
            //List<DataGridViewRow> buffer = new List<DataGridViewRow>();
            //// バッファに選択行を入れる + 一度削除
            //foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //{
            //    buffer.Add(row);
            //    dataGridView1.Rows.Remove(row);
            //}
            //// バッファは行番号昇順に並べなおす
            //// SelectedRowsで並び順が行順と一致しないため
            //buffer.Sort((a, b) => (int)(a.Cells[0].Value) - (int)(b.Cells[0].Value));
            //// バッファのデータを挿入していく
            //int rowcount = dataGridView1.RowCount;
            //for (int i = 0; i < buffer.Count; i++)
            //{
            //    dataGridView1.Rows.Add(buffer[i]);
            //}
            // IndexNum再採番
            redimIndexNum();
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
            // DataGridViewが0～1件なら、並べ替えをしない
            if (dataGridView1.Rows.Count <= 1)
            {
                button8.Enabled = true;
                return;
            }
            List<DataGridViewRow> buffer = new List<DataGridViewRow>();
            // バッファに選択行を入れる + 一度削除
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                buffer.Add(row);
                dataGridView1.Rows.Remove(row);
            }
            // バッファは行番号昇順に並べなおす
            // SelectedRowsで並び順が行順と一致しないため
            buffer.Sort((a, b) => (int)(a.Cells[0].Value) - (int)(b.Cells[0].Value));
            // バッファのデータを挿入していく
            int rowcount = dataGridView1.RowCount;
            for (int i = 0; i < buffer.Count; i++)
            {
                dataGridView1.Rows.Add(buffer[i]);
            }
            // IndexNum再採番
            redimIndexNum();
            button8.Enabled = true;
        }

        /// <summary>
        /// IndexNum再採番
        /// </summary>
        private void redimIndexNum()
        {
            int num = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[0].Value = num;
                num++;
            }
        }

        /// <summary>
        /// 結合設定読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confReadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedPath = "";
            // 読み込む結合設定を選択
            if (!UIpg.openFileSelect(textBox1.Text, "結合設定ファイル(*.dat)|*.dat", ref selectedPath)) return;
            // 結合設定を読み込む
            string[] readPaths = new string[1];
            if (!IOpg.readDat(selectedPath, ref readPaths)) return;
            // 一度datagridviewは削除
            dataGridView1.Rows.Clear();
            // datagridviewにデータ追加
            for(int i = 0; i < readPaths.Length; i++)
            {
                string path = readPaths[i];
                // 出力パス到達時
                if(path == "[OUTPUT]")
                {
                    // 一つ下の行のデータを出力先として設定
                    textBox1.Text = readPaths[i + 1];
                    break;
                }
                // データ追加時、IndexNumは0を仮置き
                dataGridView1.Rows.Add(0, Path.GetFileName(path), path);
            }
            // IndexNum再採番
            redimIndexNum();
        }

        /// <summary>
        /// 結合設定書き込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confWriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedPath = "";
            if (!UIpg.writeFileSelect(textBox1.Text, "結合設定ファイル(*.dat)|*.dat", ref selectedPath)) return;
            // 現在の登録中ファイル一覧を作成
            List<string> files = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                files.Add((string)row.Cells[2].Value);
            }
            // 出力ファイル情報追加
            files.Add("[OUTPUT]");
            files.Add(textBox1.Text);
            // 保存処理
            IOpg.writeDat(selectedPath, files.ToArray());
        }

        /// <summary>
        /// dataGridViewソート後処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            // IndexNum再採番
            redimIndexNum();
        }
    }
}