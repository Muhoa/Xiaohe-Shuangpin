namespace Little_Crane_Shuangpin
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TipText = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.LinkTipText = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TipText
            // 
            this.TipText.AutoSize = true;
            this.TipText.Location = new System.Drawing.Point(58, 9);
            this.TipText.Name = "TipText";
            this.TipText.Size = new System.Drawing.Size(47, 12);
            this.TipText.TabIndex = 3;
            this.TipText.Text = "TipText";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(130, 62);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(117, 24);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "AddButton";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(14, 62);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(110, 23);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "OpenButton";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Visible = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // LinkTipText
            // 
            this.LinkTipText.AutoSize = true;
            this.LinkTipText.Location = new System.Drawing.Point(59, 31);
            this.LinkTipText.Name = "LinkTipText";
            this.LinkTipText.Size = new System.Drawing.Size(71, 12);
            this.LinkTipText.TabIndex = 5;
            this.LinkTipText.TabStop = true;
            this.LinkTipText.Text = "LinkTipText";
            this.LinkTipText.Visible = false;
            this.LinkTipText.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkTipText_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(259, 97);
            this.Controls.Add(this.LinkTipText);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.TipText);
            this.Controls.Add(this.AddButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "小鹤双拼";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TipText;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.LinkLabel LinkTipText;
    }
}

