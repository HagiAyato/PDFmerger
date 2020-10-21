using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFmerger
{
    class IOpg
    {
        /// <summary>
        /// 結合設定を読み込み
        /// </summary>
        /// <param name="filePath">結合設定のパス</param>
        /// <param name="dataPaths">読み込んだ結果=結合対象PDF</param>
        /// <returns></returns>
        internal static bool readDat(string filePath, ref string[] dataPaths)
        {
            List<string> lines = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(filePath, Encoding.GetEncoding("SHIFT_JIS")))
                {
                    while (reader.EndOfStream == false)
                    {
                        lines.Add(reader.ReadLine());
                    }

                }
                dataPaths = lines.ToArray();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "例外発生");
            }
            // キャンセル時・例外時など
            return false;
        }

        /// <summary>
        /// 結合設定を書き込み
        /// </summary>
        /// <param name="filePath">結合設定のパス</param>
        /// <param name="dataPaths">書き込むデータ=結合対象PDF</param>
        /// <returns></returns>
        internal static bool writeDat(string filePath, string[] dataPaths)
        {
            List<string> lines = new List<string>();
            try
            {
                // 書き込むファイルを開く　※同名ファイルがある場合は上書き
                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.GetEncoding("SHIFT_JIS")))
                {
                    foreach (string path in dataPaths)
                    {
                        writer.WriteLine(path);
                    }

                }
                dataPaths = lines.ToArray();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "例外発生");
            }
            // キャンセル時・例外時など
            return false;
        }

        /// <summary>
        /// PDF結合処理
        /// </summary>
        /// <param name="selectedPath"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        internal static bool pdfMerge(string selectedPath, string[] v)
        {
            throw new NotImplementedException();
        }
    }
}
