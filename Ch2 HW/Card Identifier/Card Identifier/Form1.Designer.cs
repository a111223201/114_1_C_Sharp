namespace Card_Identifier
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
            this.jokerofBlack = new System.Windows.Forms.PictureBox();
            this.aceofSpades = new System.Windows.Forms.PictureBox();
            this.kingofSpades = new System.Windows.Forms.PictureBox();
            this.twoofClubs = new System.Windows.Forms.PictureBox();
            this.eightofDiamonds = new System.Windows.Forms.PictureBox();
            this.showLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jokerofBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceofSpades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingofSpades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoofClubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eightofDiamonds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(146, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click a Card to See Its name";
            // 
            // jokerofBlack
            // 
            this.jokerofBlack.Image = global::Card_Identifier.Properties.Resources.Joker_Black;
            this.jokerofBlack.Location = new System.Drawing.Point(636, 116);
            this.jokerofBlack.Name = "jokerofBlack";
            this.jokerofBlack.Size = new System.Drawing.Size(118, 162);
            this.jokerofBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jokerofBlack.TabIndex = 4;
            this.jokerofBlack.TabStop = false;
            this.jokerofBlack.Click += new System.EventHandler(this.jokerofBlack_Click);
            // 
            // aceofSpades
            // 
            this.aceofSpades.Image = global::Card_Identifier.Properties.Resources.Ace_Spades;
            this.aceofSpades.Location = new System.Drawing.Point(489, 116);
            this.aceofSpades.Name = "aceofSpades";
            this.aceofSpades.Size = new System.Drawing.Size(118, 162);
            this.aceofSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aceofSpades.TabIndex = 3;
            this.aceofSpades.TabStop = false;
            this.aceofSpades.Click += new System.EventHandler(this.aceofSpades_Click);
            // 
            // kingofSpades
            // 
            this.kingofSpades.Image = global::Card_Identifier.Properties.Resources.King_Spades;
            this.kingofSpades.Location = new System.Drawing.Point(341, 116);
            this.kingofSpades.Name = "kingofSpades";
            this.kingofSpades.Size = new System.Drawing.Size(118, 162);
            this.kingofSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kingofSpades.TabIndex = 2;
            this.kingofSpades.TabStop = false;
            this.kingofSpades.Click += new System.EventHandler(this.kingofSpades_Click);
            // 
            // twoofClubs
            // 
            this.twoofClubs.Image = global::Card_Identifier.Properties.Resources._2_Clubs;
            this.twoofClubs.Location = new System.Drawing.Point(194, 116);
            this.twoofClubs.Name = "twoofClubs";
            this.twoofClubs.Size = new System.Drawing.Size(118, 162);
            this.twoofClubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.twoofClubs.TabIndex = 1;
            this.twoofClubs.TabStop = false;
            this.twoofClubs.Click += new System.EventHandler(this.twoofClubs_Click);
            // 
            // eightofDiamonds
            // 
            this.eightofDiamonds.Image = global::Card_Identifier.Properties.Resources._8_Diamonds;
            this.eightofDiamonds.Location = new System.Drawing.Point(58, 116);
            this.eightofDiamonds.Name = "eightofDiamonds";
            this.eightofDiamonds.Size = new System.Drawing.Size(118, 162);
            this.eightofDiamonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eightofDiamonds.TabIndex = 0;
            this.eightofDiamonds.TabStop = false;
            this.eightofDiamonds.Click += new System.EventHandler(this.eightofDiamonds_Click);
            // 
            // showLabel
            // 
            this.showLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showLabel.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showLabel.Location = new System.Drawing.Point(241, 335);
            this.showLabel.Name = "showLabel";
            this.showLabel.Size = new System.Drawing.Size(339, 60);
            this.showLabel.TabIndex = 6;
            this.showLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jokerofBlack);
            this.Controls.Add(this.aceofSpades);
            this.Controls.Add(this.kingofSpades);
            this.Controls.Add(this.twoofClubs);
            this.Controls.Add(this.eightofDiamonds);
            this.Name = "Form1";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.jokerofBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceofSpades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingofSpades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoofClubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eightofDiamonds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox eightofDiamonds;
        private System.Windows.Forms.PictureBox twoofClubs;
        private System.Windows.Forms.PictureBox kingofSpades;
        private System.Windows.Forms.PictureBox aceofSpades;
        private System.Windows.Forms.PictureBox jokerofBlack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label showLabel;
    }
}

