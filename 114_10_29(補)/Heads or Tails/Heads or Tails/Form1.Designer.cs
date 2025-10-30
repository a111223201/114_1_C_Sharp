namespace Heads_or_Tails
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
            this.Tail = new System.Windows.Forms.PictureBox();
            this.Head = new System.Windows.Forms.PictureBox();
            this.ShowHeads = new System.Windows.Forms.Button();
            this.ShowTails = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Head)).BeginInit();
            this.SuspendLayout();
            // 
            // Tail
            // 
            this.Tail.Image = global::Heads_or_Tails.Properties.Resources.Tails1;
            this.Tail.Location = new System.Drawing.Point(428, 55);
            this.Tail.Name = "Tail";
            this.Tail.Size = new System.Drawing.Size(250, 225);
            this.Tail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tail.TabIndex = 1;
            this.Tail.TabStop = false;
            this.Tail.Visible = false;
            // 
            // Head
            // 
            this.Head.Image = global::Heads_or_Tails.Properties.Resources.Heads1;
            this.Head.Location = new System.Drawing.Point(96, 55);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(250, 225);
            this.Head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Head.TabIndex = 0;
            this.Head.TabStop = false;
            this.Head.Visible = false;
            // 
            // ShowHeads
            // 
            this.ShowHeads.Location = new System.Drawing.Point(71, 341);
            this.ShowHeads.Name = "ShowHeads";
            this.ShowHeads.Size = new System.Drawing.Size(193, 63);
            this.ShowHeads.TabIndex = 2;
            this.ShowHeads.Text = "Show Heads";
            this.ShowHeads.UseVisualStyleBackColor = true;
            this.ShowHeads.Click += new System.EventHandler(this.ShowHeads_Click);
            // 
            // ShowTails
            // 
            this.ShowTails.Location = new System.Drawing.Point(320, 341);
            this.ShowTails.Name = "ShowTails";
            this.ShowTails.Size = new System.Drawing.Size(193, 63);
            this.ShowTails.TabIndex = 3;
            this.ShowTails.Text = "Show Tails";
            this.ShowTails.UseVisualStyleBackColor = true;
            this.ShowTails.Click += new System.EventHandler(this.ShowTails_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(565, 341);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(193, 63);
            this.exit.TabIndex = 4;
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
            this.Controls.Add(this.ShowTails);
            this.Controls.Add(this.ShowHeads);
            this.Controls.Add(this.Tail);
            this.Controls.Add(this.Head);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Tail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Head)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Head;
        private System.Windows.Forms.PictureBox Tail;
        private System.Windows.Forms.Button ShowHeads;
        private System.Windows.Forms.Button ShowTails;
        private System.Windows.Forms.Button exit;
    }
}

