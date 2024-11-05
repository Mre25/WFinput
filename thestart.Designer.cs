namespace WFinput
{
    partial class thestart
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
            regisbutt = new Button();
            searchbutt = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // regisbutt
            // 
            regisbutt.Anchor = AnchorStyles.Top;
            regisbutt.Location = new Point(556, 332);
            regisbutt.Name = "regisbutt";
            regisbutt.Size = new Size(298, 76);
            regisbutt.TabIndex = 2;
            regisbutt.Text = "Registration";
            regisbutt.UseVisualStyleBackColor = true;
            regisbutt.Click += Buttclick;
            // 
            // searchbutt
            // 
            searchbutt.Anchor = AnchorStyles.Top;
            searchbutt.Location = new Point(556, 551);
            searchbutt.Name = "searchbutt";
            searchbutt.Size = new Size(298, 76);
            searchbutt.TabIndex = 3;
            searchbutt.Text = "Search";
            searchbutt.UseVisualStyleBackColor = true;
            searchbutt.Click += Buttclick;
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.None;
            label3.Anchor = AnchorStyles.Top;
            label3.Location = new Point(529, 445);
            label3.Name = "label3";
            label3.Size = new Size(356, 65);
            label3.TabIndex = 4;
            label3.Text = "OR";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // thestart
            // 
            AutoScaleDimensions = new SizeF(20F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 733);
            Controls.Add(label3);
            Controls.Add(searchbutt);
            Controls.Add(regisbutt);
            Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(8, 7, 8, 7);
            Name = "thestart";
            Text = "thestart";
            ResumeLayout(false);
        }

        #endregion
        private Button regisbutt;
        private Button searchbutt;
        private Label label3;
    }
}