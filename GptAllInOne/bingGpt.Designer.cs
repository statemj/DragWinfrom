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
            closeFromFn = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // closeFromFn
            // 
            closeFromFn.AutoSize = true;
            closeFromFn.BackColor = Color.Transparent;
            closeFromFn.Cursor = Cursors.Hand;
            closeFromFn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            closeFromFn.ForeColor = Color.IndianRed;
            closeFromFn.Location = new Point(776, 2);
            closeFromFn.Name = "closeFromFn";
            closeFromFn.Size = new Size(22, 22);
            closeFromFn.TabIndex = 0;
            closeFromFn.Text = "×";
            closeFromFn.Click += clickExit;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(757, 6);
            label1.Name = "label1";
            label1.Size = new Size(15, 17);
            label1.TabIndex = 1;
            label1.Text = "━";
            label1.Click += clickMinimized;
            // 
            // bingGpt
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(799, 450);
            Controls.Add(label1);
            Controls.Add(closeFromFn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "bingGpt";
            ShowIcon = false;
            Text = "GptMsg";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label closeFromFn;
        private Label label1;
    }
}