namespace Cups_To_Ounces
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
            this.bannerLabel = new System.Windows.Forms.Label();
            this.cupsPromptLabel = new System.Windows.Forms.Label();
            this.cupsTextBox = new System.Windows.Forms.TextBox();
            this.ouncesLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bannerLabel
            // 
            // 標題標籤：顯示應用程式名稱，使用粗體 18pt 字型，自動調整大小
            this.bannerLabel.AutoSize = true;
            this.bannerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerLabel.Location = new System.Drawing.Point(18, 12);
            this.bannerLabel.Name = "bannerLabel";
            this.bannerLabel.Size = new System.Drawing.Size(300, 29);
            this.bannerLabel.TabIndex = 0;
            this.bannerLabel.Text = "杯數轉換為液體盎司"; // 繁體中文標題
            // 
            // cupsPromptLabel
            // 
            // 輸入提示標籤：告知使用者輸入杯數，使用 18pt 字型
            this.cupsPromptLabel.AutoSize = true;
            this.cupsPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cupsPromptLabel.Location = new System.Drawing.Point(20, 60);
            this.cupsPromptLabel.Name = "cupsPromptLabel";
            this.cupsPromptLabel.Size = new System.Drawing.Size(72, 29);
            this.cupsPromptLabel.TabIndex = 1;
            this.cupsPromptLabel.Text = "杯數："; // 繁體中文
            // 
            // cupsTextBox
            // 
            // 輸入文字方塊：讓使用者輸入杯數，字型調整為 18pt，大小與位置適度放大
            this.cupsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cupsTextBox.Location = new System.Drawing.Point(100, 57);
            this.cupsTextBox.Name = "cupsTextBox";
            this.cupsTextBox.Size = new System.Drawing.Size(180, 35);
            this.cupsTextBox.TabIndex = 2;
            // 
            // ouncesLabel
            // 
            // 輸出顯示標籤：顯示轉換後的盎司數，使用單線邊框以突出顯示，字型為 18pt
            this.ouncesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ouncesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouncesLabel.Location = new System.Drawing.Point(100, 100);
            this.ouncesLabel.Name = "ouncesLabel";
            this.ouncesLabel.Size = new System.Drawing.Size(180, 36);
            this.ouncesLabel.TabIndex = 3;
            this.ouncesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescriptionLabel
            // 
            // 輸出描述標籤：標示輸出欄位用途，使用 18pt 字型
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(20, 106);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(72, 29);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "盎司："; // 繁體中文
            // 
            // convertButton
            // 
            // 轉換按鈕：按下後執行轉換邏輯，使用 18pt 字型並放大按鈕尺寸以利按壓
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(60, 150);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(120, 45);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "轉換"; // 繁體中文
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            // 離開按鈕：按下後關閉表單，使用 18pt 字型
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(200, 150);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 45);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "離開"; // 繁體中文
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 表單設定：調整整體大小以容納放大的字型與元件
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 220);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.ouncesLabel);
            this.Controls.Add(this.cupsTextBox);
            this.Controls.Add(this.cupsPromptLabel);
            this.Controls.Add(this.bannerLabel);
            this.Name = "Form1";
            this.Text = "杯數轉盎司"; // 繁體中文視窗標題
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // 以下是表單中使用的元件變數宣告
        // 每個欄位皆加入繁體中文註解，說明用途

        private System.Windows.Forms.Label bannerLabel; // 標題：顯示應用程式名稱
        private System.Windows.Forms.Label cupsPromptLabel; // 輸入提示：告知使用者輸入杯數
        private System.Windows.Forms.TextBox cupsTextBox; // 輸入框：使用者輸入杯數
        private System.Windows.Forms.Label ouncesLabel; // 輸出顯示：顯示轉換後的盎司數
        private System.Windows.Forms.Label outputDescriptionLabel; // 輸出說明：標示盎司欄位
        private System.Windows.Forms.Button convertButton; // 轉換按鈕：執行轉換
        private System.Windows.Forms.Button exitButton; // 離開按鈕：關閉應用程式
    }
}

