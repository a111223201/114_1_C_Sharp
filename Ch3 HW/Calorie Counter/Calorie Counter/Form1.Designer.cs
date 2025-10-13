namespace Calorie_Counter
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ApplePictureBox = new System.Windows.Forms.PictureBox();
            this.OrangePictureBox = new System.Windows.Forms.PictureBox();
            this.BananaPictureBox = new System.Windows.Forms.PictureBox();
            this.Result = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrangePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BananaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(545, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Calories";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Calorie_Counter.Properties.Resources.Pear;
            this.pictureBox4.Location = new System.Drawing.Point(279, 218);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 128);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // ApplePictureBox
            // 
            this.ApplePictureBox.Image = global::Calorie_Counter.Properties.Resources.Apple;
            this.ApplePictureBox.Location = new System.Drawing.Point(279, 38);
            this.ApplePictureBox.Name = "ApplePictureBox";
            this.ApplePictureBox.Size = new System.Drawing.Size(128, 128);
            this.ApplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ApplePictureBox.TabIndex = 2;
            this.ApplePictureBox.TabStop = false;
            this.ApplePictureBox.Click += new System.EventHandler(this.ApplePictureBox_Click);
            // 
            // OrangePictureBox
            // 
            this.OrangePictureBox.Image = global::Calorie_Counter.Properties.Resources.Orange;
            this.OrangePictureBox.Location = new System.Drawing.Point(73, 218);
            this.OrangePictureBox.Name = "OrangePictureBox";
            this.OrangePictureBox.Size = new System.Drawing.Size(128, 128);
            this.OrangePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OrangePictureBox.TabIndex = 1;
            this.OrangePictureBox.TabStop = false;
            this.OrangePictureBox.Click += new System.EventHandler(this.OrangePictureBox_Click);
            // 
            // BananaPictureBox
            // 
            this.BananaPictureBox.Image = global::Calorie_Counter.Properties.Resources.Banana;
            this.BananaPictureBox.Location = new System.Drawing.Point(73, 38);
            this.BananaPictureBox.Name = "BananaPictureBox";
            this.BananaPictureBox.Size = new System.Drawing.Size(128, 128);
            this.BananaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BananaPictureBox.TabIndex = 0;
            this.BananaPictureBox.TabStop = false;
            this.BananaPictureBox.Click += new System.EventHandler(this.BananaPictureBox_Click);
            // 
            // Result
            // 
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Result.Location = new System.Drawing.Point(545, 102);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(223, 44);
            this.Result.TabIndex = 5;
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reset.Location = new System.Drawing.Point(603, 277);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(117, 56);
            this.reset.TabIndex = 6;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(626, 357);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(94, 69);
            this.exit.TabIndex = 7;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.ApplePictureBox);
            this.Controls.Add(this.OrangePictureBox);
            this.Controls.Add(this.BananaPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrangePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BananaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BananaPictureBox;
        private System.Windows.Forms.PictureBox OrangePictureBox;
        private System.Windows.Forms.PictureBox ApplePictureBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button exit;
    }
}

