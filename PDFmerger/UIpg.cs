using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFmerger
{
    class UIpg
    {
        /// <summary>
        /// 開くファイル名(複数)の選択
        /// </summary>
        /// <param name="nowText">現在の選択中ファイル名</param>
        /// <param name="filter">フィルタ</param>
        /// <param name="selectedPaths">選択されたファイル名</param>
        /// <returns>true:選択OK false:キャンセル時・例外時など</returns>
        internal static bool openFileSelect(string nowText, string filter, ref string[] selectedPaths)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            // [ファイルの種類] ボックスに表示される選択肢を設定する
            dialog.Filter = filter;
            // 複数選択可能にする
            dialog.Multiselect = true;
            try
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedPaths = dialog.FileNames;
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "例外発生");
            }
            // キャンセル時・例外時など
            return false;
        }

        /// <summary>
        /// 開くファイルの選択(1件のみ)
        /// </summary>
        /// <param name="nowText">現在の選択中ファイル名</param>
        /// <param name="filter">フィルタ</param>
        /// <param name="selectedPaths">選択されたファイル名</param>
        /// <returns>true:選択OK false:キャンセル時・例外時など</returns>
        internal static bool openFileSelect(string nowText, string filter, ref string selectedPath)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            // [ファイルの種類] ボックスに表示される選択肢を設定する
            dialog.Filter = filter;
            // 複数選択可能にする
            dialog.Multiselect = false;
            try
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedPath = dialog.FileName;
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "例外発生");
            }
            // キャンセル時・例外時など
            return false;
        }

        /// <summary>
        /// 書き込むファイル名の選択
        /// </summary>
        /// <param name="nowText">現在の選択中ファイル名</param>
        /// <param name="filter">フィルタ</param>
        /// <param name="selectedPath">選択されたファイル名</param>
        /// <returns>true:選択OK false:キャンセル時・例外時など</returns>
        internal static bool writeFileSelect(string nowText, string filter, ref string selectedPath)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            // 拡張子を自動的に付加する
            dialog.AddExtension = true;
            // [ファイルの種類] ボックスに表示される選択肢を設定する
            dialog.Filter = filter;
            // 今選択しているファイル名を初期値とする
            dialog.FileName = nowText;
            try
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedPath = dialog.FileName;
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "例外発生");
            }
            // キャンセル時・例外時など
            return false;
        }
    }
}
