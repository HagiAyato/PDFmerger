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
        /// 開くファイル名の選択
        /// </summary>
        /// <param name="nowText">現在の選択中ファイル名</param>
        /// <param name="selectedPath">選択されたファイル名</param>
        /// <returns>true:選択OK false:キャンセル時・例外時など</returns>
        internal static bool openFileSelect(string nowText, ref string[] selectedPath)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            // [ファイルの種類] ボックスに表示される選択肢を設定する
            dialog.Filter = "PDFファイル(*.pdf)|*.pdf";
            // 複数選択可能にする
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedPath = dialog.FileNames;
                return true;
            }
            // キャンセル時・例外時など
            return false;
        }

        /// <summary>
        /// マージ後ファイル名の選択
        /// </summary>
        /// <param name="nowText">現在の選択中ファイル名</param>
        /// <param name="selectedPath">選択されたファイル名</param>
        /// <returns>true:選択OK false:キャンセル時・例外時など</returns>
        internal static bool mergedFileSelect(string nowText, ref string selectedPath)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            // 拡張子を自動的に付加する
            dialog.AddExtension = true;
            // [ファイルの種類] ボックスに表示される選択肢を設定する
            dialog.Filter = "PDFファイル(*.pdf)|*.pdf";
            // 今選択しているファイル名を初期値とする
            dialog.FileName = nowText;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedPath = dialog.FileName;
                return true;
            }
            // キャンセル時・例外時など
            return false;
        }
    }
}
