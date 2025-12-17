namespace North_America
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.getCountriesButton = new System.Windows.Forms.Button();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // 註解: 設定表單標題為繁體中文，並擴大表單尺寸以容納較大字型與元件排列
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // 將客戶區大小增大以配合字型大小 18F 與元件調整
            this.ClientSize = new System.Drawing.Size(360, 300);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getCountriesButton);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.countriesListBox);
            this.Name = "Form1";
            // 表單顯示文字改為繁體中文
            this.Text = "北美洲";
            // 
            // outputDescriptionLabel
            // 
            // 標題說明：改為繁體中文並使用 18pt 粗體以利可讀性
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 位置微調以置於表單上方中央偏左
            this.outputDescriptionLabel.Location = new System.Drawing.Point(15, 14);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            // AutoSize = true，Size 由系統決定，TabIndex 保持
            this.outputDescriptionLabel.TabIndex = 5;
            // 將文字改為繁體中文
            this.outputDescriptionLabel.Text = "北美洲的國家";
            // 
            // countriesListBox
            // 
            // 國家列表：字型放大到 18pt，增加寬高以容納較大文字
            this.countriesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 位置與大小調整：放在標題下方並拉寬
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.ItemHeight = 29;
            this.countriesListBox.Location = new System.Drawing.Point(20, 52);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.Size = new System.Drawing.Size(320, 150);
            this.countriesListBox.TabIndex = 4;
            // 
            // getCountriesButton
            // 
            // 取得國家按鈕：文字改為繁體中文、字型 18pt、按鈕變寬以符合中文顯示
            this.getCountriesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getCountriesButton.Location = new System.Drawing.Point(40, 215);
            this.getCountriesButton.Name = "getCountriesButton";
            this.getCountriesButton.Size = new System.Drawing.Size(140, 50);
            this.getCountriesButton.TabIndex = 6;
            this.getCountriesButton.Text = "取得國家";
            this.getCountriesButton.UseVisualStyleBackColor = true;
            this.getCountriesButton.Click += new System.EventHandler(this.getCountriesButton_Click);
            // 
            // exitButton
            // 
            // 結束按鈕：文字改為繁體中文、字型 18pt、放置於取得按鈕右側
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(200, 215);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 50);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // openFile
            // 
            // openFile 保留原設定（未顯示文字屬性）
            // 
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button getCountriesButton;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.ListBox countriesListBox;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

