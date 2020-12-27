using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace PDFmerger
{
    public partial class Version_dialog : Form
    {
        public Version_dialog()
        {
            InitializeComponent();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
            // バージョン名（AssemblyInformationalVersion属性）を取得
            string appVersion = fileVersionInfo.ProductVersion;
            // 製品名（AssemblyProduct属性）を取得
            string appProductName = fileVersionInfo.ProductName;
            // 会社名（AssemblyCompany属性）を取得
            string appCompanyName = fileVersionInfo.CompanyName;
            // Copyrightを取得
            string appCopyright = fileVersionInfo.LegalCopyright;
            // Descriptionを取得
            string appDescription = fileVersionInfo.Comments;
            // 表示登録
            this.Text = appProductName + "|バージョン情報";
            this.label1.Text = appCompanyName + " " + appProductName;
            this.label2.Text = "Verson " + appVersion;
            this.label3.Text = appCopyright;
            this.label4.Text = appDescription;
        }

        /// <summary>
        /// 自画面閉じ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            this.Close();
            button1.Enabled = true;
        }
    }
}
