namespace WindowsFormsBingoBingoUI
{
    partial class Form2
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
            this.lblLotteryDraw = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBigSmall = new System.Windows.Forms.Label();
            this.lblOddEven = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSuperNum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lboxCNum = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lboxYNum = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lboxWin = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWin = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Money = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLotteryDraw
            // 
            this.lblLotteryDraw.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLotteryDraw.Location = new System.Drawing.Point(139, 9);
            this.lblLotteryDraw.Name = "lblLotteryDraw";
            this.lblLotteryDraw.Size = new System.Drawing.Size(492, 62);
            this.lblLotteryDraw.TabIndex = 3;
            this.lblLotteryDraw.Text = "11,12,13,14,15,16,17,18,19,20,11,12,13,14,15,16,17,18,19,20\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "開獎號碼:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(217, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "比大小:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(432, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "奇偶數:";
            // 
            // lblBigSmall
            // 
            this.lblBigSmall.AutoSize = true;
            this.lblBigSmall.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBigSmall.Location = new System.Drawing.Point(312, 73);
            this.lblBigSmall.Name = "lblBigSmall";
            this.lblBigSmall.Size = new System.Drawing.Size(86, 31);
            this.lblBigSmall.TabIndex = 7;
            this.lblBigSmall.Text = "比大小";
            // 
            // lblOddEven
            // 
            this.lblOddEven.AutoSize = true;
            this.lblOddEven.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOddEven.Location = new System.Drawing.Point(528, 73);
            this.lblOddEven.Name = "lblOddEven";
            this.lblOddEven.Size = new System.Drawing.Size(86, 31);
            this.lblOddEven.TabIndex = 8;
            this.lblOddEven.Text = "奇偶數";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(12, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 35);
            this.label6.TabIndex = 9;
            this.label6.Text = "超級獎號:";
            // 
            // lblSuperNum
            // 
            this.lblSuperNum.AutoSize = true;
            this.lblSuperNum.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSuperNum.Location = new System.Drawing.Point(138, 73);
            this.lblSuperNum.Name = "lblSuperNum";
            this.lblSuperNum.Size = new System.Drawing.Size(42, 31);
            this.lblSuperNum.TabIndex = 10;
            this.lblSuperNum.Text = "10";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lboxCNum);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lboxYNum);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lboxWin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 489);
            this.panel1.TabIndex = 12;
            // 
            // lboxCNum
            // 
            this.lboxCNum.BackColor = System.Drawing.Color.LightYellow;
            this.lboxCNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.lboxCNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxCNum.FormattingEnabled = true;
            this.lboxCNum.ItemHeight = 21;
            this.lboxCNum.Location = new System.Drawing.Point(0, 344);
            this.lboxCNum.Name = "lboxCNum";
            this.lboxCNum.Size = new System.Drawing.Size(619, 130);
            this.lboxCNum.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(0, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(619, 35);
            this.label7.TabIndex = 18;
            this.label7.Text = "電腦選號:";
            // 
            // lboxYNum
            // 
            this.lboxYNum.BackColor = System.Drawing.Color.LightYellow;
            this.lboxYNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.lboxYNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxYNum.FormattingEnabled = true;
            this.lboxYNum.ItemHeight = 21;
            this.lboxYNum.Location = new System.Drawing.Point(0, 179);
            this.lboxYNum.Name = "lboxYNum";
            this.lboxYNum.Size = new System.Drawing.Size(619, 130);
            this.lboxYNum.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(0, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(619, 35);
            this.label5.TabIndex = 16;
            this.label5.Text = "自選號碼:";
            // 
            // lboxWin
            // 
            this.lboxWin.BackColor = System.Drawing.Color.LightYellow;
            this.lboxWin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lboxWin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxWin.FormattingEnabled = true;
            this.lboxWin.ItemHeight = 21;
            this.lboxWin.Location = new System.Drawing.Point(0, 35);
            this.lboxWin.Name = "lboxWin";
            this.lboxWin.Size = new System.Drawing.Size(619, 109);
            this.lboxWin.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(619, 35);
            this.label4.TabIndex = 14;
            this.label4.Text = "獲獎號碼:";
            // 
            // btnWin
            // 
            this.btnWin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWin.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWin.ForeColor = System.Drawing.Color.Black;
            this.btnWin.Location = new System.Drawing.Point(466, 604);
            this.btnWin.Name = "btnWin";
            this.btnWin.Size = new System.Drawing.Size(166, 51);
            this.btnWin.TabIndex = 13;
            this.btnWin.Text = "自動對獎";
            this.btnWin.UseVisualStyleBackColor = false;
            this.btnWin.Click += new System.EventHandler(this.btnWin_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(13, 611);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 35);
            this.label8.TabIndex = 14;
            this.label8.Text = "中獎金額:";
            // 
            // lbl_Money
            // 
            this.lbl_Money.AutoSize = true;
            this.lbl_Money.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Money.Location = new System.Drawing.Point(139, 611);
            this.lbl_Money.Name = "lbl_Money";
            this.lbl_Money.Size = new System.Drawing.Size(170, 35);
            this.lbl_Money.TabIndex = 15;
            this.lbl_Money.Text = "00000000元";
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(644, 667);
            this.Controls.Add(this.lbl_Money);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblLotteryDraw);
            this.Controls.Add(this.btnWin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSuperNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblOddEven);
            this.Controls.Add(this.lblBigSmall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(1000, 0);
            this.MaximumSize = new System.Drawing.Size(660, 800);
            this.MinimumSize = new System.Drawing.Size(660, 600);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "對獎";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLotteryDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBigSmall;
        private System.Windows.Forms.Label lblOddEven;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSuperNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWin;
        private System.Windows.Forms.ListBox lboxCNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lboxYNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lboxWin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Money;
    }
}