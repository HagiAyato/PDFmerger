﻿namespace PDFmerger
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ファイル読み込みToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ファイル書き出しToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IndexNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexNum,
            this.FileName,
            this.UpdateDate,
            this.Size0,
            this.Size,
            this.FilePath});
            this.dataGridView1.Location = new System.Drawing.Point(25, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(630, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "PDFmerger -PDF 結合ツール-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "+ 追加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(673, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "- 削除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 378);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(630, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(661, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "ファイルパス変更";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.button4.Location = new System.Drawing.Point(570, 418);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 56);
            this.button4.TabIndex = 2;
            this.button4.Text = "結合・出力";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(673, 150);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 30);
            this.button5.TabIndex = 2;
            this.button5.Text = "▲一番上へ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(673, 186);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 30);
            this.button6.TabIndex = 2;
            this.button6.Text = "△一行上へ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(673, 222);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 30);
            this.button7.TabIndex = 2;
            this.button7.Text = "▽一行下へ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(673, 258);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(115, 30);
            this.button8.TabIndex = 2;
            this.button8.Text = "▼一番下へ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ファイルToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 設定ファイルToolStripMenuItem
            // 
            this.設定ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ファイル読み込みToolStripMenuItem,
            this.設定ファイル書き出しToolStripMenuItem});
            this.設定ファイルToolStripMenuItem.Name = "設定ファイルToolStripMenuItem";
            this.設定ファイルToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.設定ファイルToolStripMenuItem.Text = "結合設定";
            // 
            // 設定ファイル読み込みToolStripMenuItem
            // 
            this.設定ファイル読み込みToolStripMenuItem.Name = "設定ファイル読み込みToolStripMenuItem";
            this.設定ファイル読み込みToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.設定ファイル読み込みToolStripMenuItem.Text = "結合設定読み込み";
            this.設定ファイル読み込みToolStripMenuItem.Click += new System.EventHandler(this.confReadToolStripMenuItem_Click);
            // 
            // 設定ファイル書き出しToolStripMenuItem
            // 
            this.設定ファイル書き出しToolStripMenuItem.Name = "設定ファイル書き出しToolStripMenuItem";
            this.設定ファイル書き出しToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.設定ファイル書き出しToolStripMenuItem.Text = "結合設定書き出し";
            this.設定ファイル書き出しToolStripMenuItem.Click += new System.EventHandler(this.confWriteToolStripMenuItem_Click);
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報ToolStripMenuItem});
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ";
            // 
            // バージョン情報ToolStripMenuItem
            // 
            this.バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem";
            this.バージョン情報ToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.バージョン情報ToolStripMenuItem.Text = "バージョン情報";
            this.バージョン情報ToolStripMenuItem.Click += new System.EventHandler(this.versionInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(25, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "出力ファイルパス";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(21, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "結合PDFリスト";
            // 
            // IndexNum
            // 
            this.IndexNum.HeaderText = "№";
            this.IndexNum.MinimumWidth = 30;
            this.IndexNum.Name = "IndexNum";
            this.IndexNum.ReadOnly = true;
            this.IndexNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IndexNum.Width = 30;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "ファイル名";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 150;
            // 
            // UpdateDate
            // 
            this.UpdateDate.HeaderText = "更新日";
            this.UpdateDate.Name = "UpdateDate";
            this.UpdateDate.ReadOnly = true;
            this.UpdateDate.Width = 120;
            // 
            // Size0
            // 
            this.Size0.HeaderText = "ファイルサイズ(数値)";
            this.Size0.Name = "Size0";
            this.Size0.ReadOnly = true;
            this.Size0.Visible = false;
            // 
            // Size
            // 
            this.Size.HeaderText = "ファイルサイズ";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Size.Width = 80;
            // 
            // FilePath
            // 
            this.FilePath.HeaderText = "ファイルパス";
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Width = 350;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 487);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PDFmerger";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ファイル読み込みToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ファイル書き出しToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
    }
}

