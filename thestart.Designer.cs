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
            updateButt = new Button();
            deletebutt = new Button();
            SuspendLayout();
            // 
            // regisbutt
            // 
            regisbutt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            regisbutt.Location = new Point(543, 191);
            regisbutt.Name = "regisbutt";
            regisbutt.Size = new Size(379, 76);
            regisbutt.TabIndex = 2;
            regisbutt.Text = "Registration";
            regisbutt.UseVisualStyleBackColor = true;
            regisbutt.Click += Buttclick;
            // 
            // searchbutt
            // 
            searchbutt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            searchbutt.Location = new Point(543, 344);
            searchbutt.Name = "searchbutt";
            searchbutt.Size = new Size(379, 76);
            searchbutt.TabIndex = 3;
            searchbutt.Text = "Search";
            searchbutt.UseVisualStyleBackColor = true;
            searchbutt.Click += Buttclick;
            // 
            // updateButt
            // 
            updateButt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            updateButt.Location = new Point(543, 501);
            updateButt.Name = "updateButt";
            updateButt.Size = new Size(379, 76);
            updateButt.TabIndex = 4;
            updateButt.Text = "Update";
            updateButt.UseVisualStyleBackColor = true;
            updateButt.Click += Buttclick;
            // 
            // deletebutt
            // 
            deletebutt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            deletebutt.Location = new Point(543, 656);
            deletebutt.Name = "deletebutt";
            deletebutt.Size = new Size(379, 76);
            deletebutt.TabIndex = 5;
            deletebutt.Text = "Delete";
            deletebutt.UseVisualStyleBackColor = true;
            deletebutt.Click += Buttclick;
            // 
            // thestart
            // 
            AutoScaleDimensions = new SizeF(20F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 874);
            Controls.Add(deletebutt);
            Controls.Add(updateButt);
            Controls.Add(searchbutt);
            Controls.Add(regisbutt);
            Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(8, 7, 8, 7);
            Name = "thestart";
            Text = "thestart";
            Load += thestart_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button regisbutt;
        private Button searchbutt;
        private Button updateButt;
        private Button deletebutt;
    }
}