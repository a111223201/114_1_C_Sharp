namespace GroupBoxDemo
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
            this.groupBoxDemo = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxDemo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDemo
            // 
            this.groupBoxDemo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxDemo.Controls.Add(this.button2);
            this.groupBoxDemo.Controls.Add(this.textBox1);
            this.groupBoxDemo.Controls.Add(this.button1);
            this.groupBoxDemo.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxDemo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxDemo.Location = new System.Drawing.Point(49, 66);
            this.groupBoxDemo.Name = "groupBoxDemo";
            this.groupBoxDemo.Size = new System.Drawing.Size(283, 298);
            this.groupBoxDemo.TabIndex = 0;
            this.groupBoxDemo.TabStop = false;
            this.groupBoxDemo.Text = "groupBoxDemo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 46);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.Location = new System.Drawing.Point(465, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 201);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 73);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(34, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 69);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxDemo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxDemo.ResumeLayout(false);
            this.groupBoxDemo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDemo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

