
namespace WindowsFormsBingoBingoUI
{
    partial class Form3
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
            this.btnWin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lboxCNum = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lboxYNum = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWin
            // 
            this.btnWin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWin.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWin.ForeColor = System.Drawing.Color.Black;
            this.btnWin.Location = new System.Drawing.Point(466, 498);
            this.btnWin.Name = "btnWin";
            this.btnWin.Size = new System.Drawing.Size(166, 51);
            this.btnWin.TabIndex = 18;
            this.btnWin.Text = "確認並結帳";
            this.btnWin.UseVisualStyleBackColor = false;
            this.btnWin.Click += new System.EventHandler(this.btnWin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lboxCNum);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lboxYNum);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 415);
            this.panel1.TabIndex = 19;
            // 
            // lboxCNum
            // 
            this.lboxCNum.BackColor = System.Drawing.Color.LightYellow;
            this.lboxCNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.lboxCNum.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxCNum.FormattingEnabled = true;
            this.lboxCNum.ItemHeight = 26;
            this.lboxCNum.Location = new System.Drawing.Point(0, 230);
            this.lboxCNum.Name = "lboxCNum";
            this.lboxCNum.Size = new System.Drawing.Size(644, 160);
            this.lboxCNum.TabIndex = 19;
            this.lboxCNum.DoubleClick += new System.EventHandler(this.lboxCNum_DoubleClick);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(0, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(644, 35);
            this.label7.TabIndex = 18;
            this.label7.Text = "電腦選號:";
            // 
            // lboxYNum
            // 
            this.lboxYNum.BackColor = System.Drawing.Color.LightYellow;
            this.lboxYNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.lboxYNum.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxYNum.FormattingEnabled = true;
            this.lboxYNum.ItemHeight = 26;
            this.lboxYNum.Location = new System.Drawing.Point(0, 35);
            this.lboxYNum.Name = "lboxYNum";
            this.lboxYNum.Size = new System.Drawing.Size(644, 160);
            this.lboxYNum.TabIndex = 17;
            this.lboxYNum.DoubleClick += new System.EventHandler(this.lboxYNum_DoubleClick);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(644, 35);
            this.label5.TabIndex = 16;
            this.label5.Text = "自選號碼:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(644, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnWin);
            this.MaximumSize = new System.Drawing.Size(660, 600);
            this.MinimumSize = new System.Drawing.Size(660, 600);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "選號清單";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnWin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox lboxCNum;
        public System.Windows.Forms.ListBox lboxYNum;
    }
}