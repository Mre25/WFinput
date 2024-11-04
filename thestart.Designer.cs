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
            label2 = new Label();
            regisbutt = new Button();
            searchbutt = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.None;
            label2.Anchor = AnchorStyles.None;
            label2.Location = new Point(405, 52);
            label2.Name = "label2";
            label2.Size = new Size(449, 95);
            label2.TabIndex = 1;
            label2.Text = "Welcome\r\nWhat do you want to do?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // regisbutt
            // 
            regisbutt.Location = new Point(474, 232);
            regisbutt.Name = "regisbutt";
            regisbutt.Size = new Size(298, 76);
            regisbutt.TabIndex = 2;
            regisbutt.Text = "Registration";
            regisbutt.UseVisualStyleBackColor = true;
            // 
            // searchbutt
            // 
            searchbutt.Location = new Point(474, 451);
            searchbutt.Name = "searchbutt";
            searchbutt.Size = new Size(298, 76);
            searchbutt.TabIndex = 3;
            searchbutt.Text = "Search";
            searchbutt.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.None;
            label3.Anchor = AnchorStyles.None;
            label3.Location = new Point(447, 345);
            label3.Name = "label3";
            label3.Size = new Size(356, 65);
            label3.TabIndex = 4;
            label3.Text = "OR";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // thestart
            // 
            AutoScaleDimensions = new SizeF(20F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 617);
            Controls.Add(label3);
            Controls.Add(searchbutt);
            Controls.Add(regisbutt);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(8, 7, 8, 7);
            Name = "thestart";
            Text = "thestart";
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Button regisbutt;
        private Button searchbutt;
        private Label label3;
    }
}