namespace Comprehensive_Practice_1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.btnShowMax = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.lblLastName.Location = new System.Drawing.Point(30, 30);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(68, 55);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "姓";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.lblFirstName.Location = new System.Drawing.Point(655, 27);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(68, 55);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "名";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.lblScore1.Location = new System.Drawing.Point(41, 283);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(138, 55);
            this.lblScore1.TabIndex = 2;
            this.lblScore1.Text = "小考1";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.lblScore2.Location = new System.Drawing.Point(30, 389);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(138, 55);
            this.lblScore2.TabIndex = 3;
            this.lblScore2.Text = "小考2";
            // 
            // lblScore3
            // 
            this.lblScore3.AutoSize = true;
            this.lblScore3.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.lblScore3.Location = new System.Drawing.Point(30, 504);
            this.lblScore3.Name = "lblScore3";
            this.lblScore3.Size = new System.Drawing.Size(138, 55);
            this.lblScore3.TabIndex = 4;
            this.lblScore3.Text = "小考3";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.lblResult.Location = new System.Drawing.Point(548, 500);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(640, 67);
            this.lblResult.TabIndex = 12;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.txtLastName.Location = new System.Drawing.Point(140, 30);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 66);
            this.txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.txtFirstName.Location = new System.Drawing.Point(765, 27);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 66);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtScore1
            // 
            this.txtScore1.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.txtScore1.Location = new System.Drawing.Point(338, 280);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(150, 66);
            this.txtScore1.TabIndex = 7;
            // 
            // txtScore2
            // 
            this.txtScore2.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.txtScore2.Location = new System.Drawing.Point(338, 389);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(150, 66);
            this.txtScore2.TabIndex = 8;
            // 
            // txtScore3
            // 
            this.txtScore3.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.txtScore3.Location = new System.Drawing.Point(338, 501);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(150, 66);
            this.txtScore3.TabIndex = 9;
            // 
            // btnShowMax
            // 
            this.btnShowMax.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.btnShowMax.Location = new System.Drawing.Point(366, 671);
            this.btnShowMax.Name = "btnShowMax";
            this.btnShowMax.Size = new System.Drawing.Size(272, 163);
            this.btnShowMax.TabIndex = 10;
            this.btnShowMax.Text = "顯示最高分";
            this.btnShowMax.UseVisualStyleBackColor = true;
            this.btnShowMax.Click += new System.EventHandler(this.btnShowMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.btnExit.Location = new System.Drawing.Point(808, 637);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(303, 197);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 868);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScore3);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore3);
            this.Controls.Add(this.btnShowMax);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblScore3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.Button btnShowMax;
        private System.Windows.Forms.Button btnExit;
    }
}

