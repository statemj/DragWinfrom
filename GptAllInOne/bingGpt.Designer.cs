namespace GptAllInOne
{
    partial class bingGpt
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bingGpt));
            heightBox = new Label();
            closeFromFn = new Label();
            clickMinimizedBtn = new Label();
            SuspendLayout();
            // 
            // heightBox
            // 
            heightBox.AutoSize = true;
            heightBox.Location = new Point(370, 191);
            heightBox.Name = "heightBox";
            heightBox.Size = new Size(15, 17);
            heightBox.TabIndex = 2;
            heightBox.Text = "0";
            // 
            // closeFromFn
            // 
            closeFromFn.AutoSize = true;
            closeFromFn.BackColor = Color.Transparent;
            closeFromFn.Cursor = Cursors.Hand;
            closeFromFn.Dock = DockStyle.Right;
            closeFromFn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            closeFromFn.ForeColor = Color.IndianRed;
            closeFromFn.Location = new Point(777, 0);
            closeFromFn.Name = "closeFromFn";
            closeFromFn.Size = new Size(22, 22);
            closeFromFn.TabIndex = 5;
            closeFromFn.Text = "×";
            closeFromFn.Click += clickExit;
            // 
            // clickMinimizedBtn
            // 
            clickMinimizedBtn.AutoSize = true;
            clickMinimizedBtn.BackColor = Color.Transparent;
            clickMinimizedBtn.Cursor = Cursors.Hand;
            clickMinimizedBtn.Dock = DockStyle.Right;
            clickMinimizedBtn.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            clickMinimizedBtn.ForeColor = Color.IndianRed;
            clickMinimizedBtn.Location = new Point(760, 0);
            clickMinimizedBtn.Name = "clickMinimizedBtn";
            clickMinimizedBtn.Padding = new Padding(0, 2, 0, 0);
            clickMinimizedBtn.Size = new Size(17, 22);
            clickMinimizedBtn.TabIndex = 6;
            clickMinimizedBtn.Text = "━";
            clickMinimizedBtn.Click += clickMinimized;
            // 
            // bingGpt
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(799, 450);
            Controls.Add(clickMinimizedBtn);
            Controls.Add(closeFromFn);
            Controls.Add(heightBox);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "bingGpt";
            ShowIcon = false;
            Text = "GptMsg";
            Load += Form1_Load;
            MouseLeave += bingGpt_MouseLeave;
            MouseMove += bingGpt_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label heightBox;
        private Label closeFromFn;
        private Label clickMinimizedBtn;
    }
}