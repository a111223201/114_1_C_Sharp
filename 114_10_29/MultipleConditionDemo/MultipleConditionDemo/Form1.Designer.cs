namespace MultipleConditionDemo
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // 新增的元件宣告
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Button JudgeButton;
        private System.Windows.Forms.Label labelGrade; // 顯示成績等級的 Label

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelScore = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.JudgeButton = new System.Windows.Forms.Button();
            this.labelGrade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(41, 43);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(122, 55);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "成績:";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScore.Location = new System.Drawing.Point(175, 32);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(205, 66);
            this.textBoxScore.TabIndex = 1;
            // 
            // JudgeButton
            // 
            this.JudgeButton.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JudgeButton.Location = new System.Drawing.Point(458, 315);
            this.JudgeButton.Name = "JudgeButton";
            this.JudgeButton.Size = new System.Drawing.Size(236, 75);
            this.JudgeButton.TabIndex = 2;
            this.JudgeButton.Text = "等級判斷";
            this.JudgeButton.UseVisualStyleBackColor = true;
            this.JudgeButton.Click += new System.EventHandler(this.JudgeButton_Click);
            // 
            // labelGrade
            // 
            this.labelGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGrade.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrade.Location = new System.Drawing.Point(175, 149);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(359, 71);
            this.labelGrade.TabIndex = 3;
            this.labelGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "等級:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.JudgeButton);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.labelScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}

