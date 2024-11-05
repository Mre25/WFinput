namespace WFinput
{
    partial class registration
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
            IDTB = new TextBox();
            NameTB = new TextBox();
            ID = new Label();
            Fullname = new Label();
            MajTB = new TextBox();
            Major = new Label();
            Academicyear = new Label();
            AcadeTB = new TextBox();
            MaleRB = new RadioButton();
            FemaleRB = new RadioButton();
            registbutt = new Button();
            Address = new Label();
            AddrTB = new TextBox();
            Phone = new Label();
            PhoneTB = new TextBox();
            SuspendLayout();
            // 
            // IDTB
            // 
            IDTB.Anchor = AnchorStyles.Bottom;
            IDTB.CausesValidation = false;
            IDTB.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            IDTB.Location = new Point(515, 55);
            IDTB.Name = "IDTB";
            IDTB.Size = new Size(502, 47);
            IDTB.TabIndex = 0;
            IDTB.TextAlign = HorizontalAlignment.Center;
            IDTB.Click += TBinput;
            // 
            // NameTB
            // 
            NameTB.Anchor = AnchorStyles.Bottom;
            NameTB.CausesValidation = false;
            NameTB.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            NameTB.Location = new Point(515, 136);
            NameTB.Name = "NameTB";
            NameTB.Size = new Size(502, 47);
            NameTB.TabIndex = 1;
            NameTB.TextAlign = HorizontalAlignment.Center;
            NameTB.Click += TBinput;
            // 
            // ID
            // 
            ID.Anchor = AnchorStyles.Bottom;
            ID.AutoSize = true;
            ID.CausesValidation = false;
            ID.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            ID.ImageAlign = ContentAlignment.MiddleLeft;
            ID.Location = new Point(178, 59);
            ID.Name = "ID";
            ID.Size = new Size(50, 41);
            ID.TabIndex = 2;
            ID.Text = "ID";
            ID.TextAlign = ContentAlignment.MiddleLeft;
            ID.Click += label1_Click;
            // 
            // Fullname
            // 
            Fullname.Anchor = AnchorStyles.Bottom;
            Fullname.AutoSize = true;
            Fullname.CausesValidation = false;
            Fullname.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Fullname.ImageAlign = ContentAlignment.MiddleLeft;
            Fullname.Location = new Point(175, 140);
            Fullname.Name = "Fullname";
            Fullname.Size = new Size(161, 41);
            Fullname.TabIndex = 3;
            Fullname.Text = "Full Name";
            Fullname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MajTB
            // 
            MajTB.Anchor = AnchorStyles.Bottom;
            MajTB.CausesValidation = false;
            MajTB.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            MajTB.Location = new Point(515, 223);
            MajTB.Name = "MajTB";
            MajTB.Size = new Size(502, 47);
            MajTB.TabIndex = 4;
            MajTB.TextAlign = HorizontalAlignment.Center;
            MajTB.Click += TBinput;
            // 
            // Major
            // 
            Major.Anchor = AnchorStyles.Bottom;
            Major.AutoSize = true;
            Major.CausesValidation = false;
            Major.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Major.ImageAlign = ContentAlignment.MiddleLeft;
            Major.Location = new Point(178, 227);
            Major.Name = "Major";
            Major.Size = new Size(102, 41);
            Major.TabIndex = 5;
            Major.Text = "Major";
            Major.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Academicyear
            // 
            Academicyear.Anchor = AnchorStyles.Bottom;
            Academicyear.AutoSize = true;
            Academicyear.CausesValidation = false;
            Academicyear.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Academicyear.ImageAlign = ContentAlignment.MiddleLeft;
            Academicyear.Location = new Point(178, 315);
            Academicyear.Name = "Academicyear";
            Academicyear.Size = new Size(222, 41);
            Academicyear.TabIndex = 7;
            Academicyear.Text = "Academic year";
            Academicyear.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AcadeTB
            // 
            AcadeTB.Anchor = AnchorStyles.Bottom;
            AcadeTB.CausesValidation = false;
            AcadeTB.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            AcadeTB.Location = new Point(515, 311);
            AcadeTB.Name = "AcadeTB";
            AcadeTB.Size = new Size(502, 47);
            AcadeTB.TabIndex = 6;
            AcadeTB.TextAlign = HorizontalAlignment.Center;
            AcadeTB.Click += TBinput;
            // 
            // MaleRB
            // 
            MaleRB.Anchor = AnchorStyles.Bottom;
            MaleRB.AutoSize = true;
            MaleRB.CausesValidation = false;
            MaleRB.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            MaleRB.Location = new Point(623, 580);
            MaleRB.Name = "MaleRB";
            MaleRB.Size = new Size(109, 45);
            MaleRB.TabIndex = 8;
            MaleRB.TabStop = true;
            MaleRB.Text = "Male";
            MaleRB.UseVisualStyleBackColor = true;
            MaleRB.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // FemaleRB
            // 
            FemaleRB.Anchor = AnchorStyles.Bottom;
            FemaleRB.AutoSize = true;
            FemaleRB.CausesValidation = false;
            FemaleRB.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            FemaleRB.Location = new Point(794, 580);
            FemaleRB.Name = "FemaleRB";
            FemaleRB.Size = new Size(139, 45);
            FemaleRB.TabIndex = 9;
            FemaleRB.TabStop = true;
            FemaleRB.Text = "Female";
            FemaleRB.UseVisualStyleBackColor = true;
            // 
            // registbutt
            // 
            registbutt.Anchor = AnchorStyles.Bottom;
            registbutt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            registbutt.BackgroundImageLayout = ImageLayout.Center;
            registbutt.CausesValidation = false;
            registbutt.FlatStyle = FlatStyle.System;
            registbutt.Location = new Point(653, 691);
            registbutt.Name = "registbutt";
            registbutt.Size = new Size(223, 95);
            registbutt.TabIndex = 10;
            registbutt.Text = "Registration";
            registbutt.UseVisualStyleBackColor = true;
            registbutt.Click += registbutt_Click;
            // 
            // Address
            // 
            Address.Anchor = AnchorStyles.Bottom;
            Address.AutoSize = true;
            Address.CausesValidation = false;
            Address.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Address.ImageAlign = ContentAlignment.MiddleLeft;
            Address.Location = new Point(178, 403);
            Address.Name = "Address";
            Address.Size = new Size(131, 41);
            Address.TabIndex = 12;
            Address.Text = "Address";
            Address.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddrTB
            // 
            AddrTB.Anchor = AnchorStyles.Bottom;
            AddrTB.CausesValidation = false;
            AddrTB.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            AddrTB.Location = new Point(515, 399);
            AddrTB.Name = "AddrTB";
            AddrTB.Size = new Size(502, 47);
            AddrTB.TabIndex = 11;
            AddrTB.TextAlign = HorizontalAlignment.Center;
            AddrTB.Click += TBinput;
            // 
            // Phone
            // 
            Phone.Anchor = AnchorStyles.Bottom;
            Phone.AutoSize = true;
            Phone.CausesValidation = false;
            Phone.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Phone.ImageAlign = ContentAlignment.MiddleLeft;
            Phone.Location = new Point(178, 492);
            Phone.Name = "Phone";
            Phone.Size = new Size(106, 41);
            Phone.TabIndex = 14;
            Phone.Text = "Phone";
            Phone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PhoneTB
            // 
            PhoneTB.Anchor = AnchorStyles.Bottom;
            PhoneTB.CausesValidation = false;
            PhoneTB.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            PhoneTB.Location = new Point(515, 488);
            PhoneTB.Name = "PhoneTB";
            PhoneTB.Size = new Size(502, 47);
            PhoneTB.TabIndex = 13;
            PhoneTB.TextAlign = HorizontalAlignment.Center;
            PhoneTB.Click += TBinput;
            // 
            // registration
            // 
            AutoScaleDimensions = new SizeF(20F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 874);
            Controls.Add(Phone);
            Controls.Add(PhoneTB);
            Controls.Add(Address);
            Controls.Add(AddrTB);
            Controls.Add(registbutt);
            Controls.Add(FemaleRB);
            Controls.Add(MaleRB);
            Controls.Add(Academicyear);
            Controls.Add(AcadeTB);
            Controls.Add(Major);
            Controls.Add(MajTB);
            Controls.Add(Fullname);
            Controls.Add(ID);
            Controls.Add(NameTB);
            Controls.Add(IDTB);
            Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(8, 7, 8, 7);
            Name = "registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            TransparencyKey = Color.LightGray;
            Load += registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IDTB;
        private TextBox NameTB;
        private Label ID;
        private Label Fullname;
        private TextBox MajTB;
        private Label Major;
        private Label Academicyear;
        private TextBox AcadeTB;
        private RadioButton MaleRB;
        private RadioButton FemaleRB;
        private Button registbutt;
        private Label Address;
        private TextBox AddrTB;
        private Label Phone;
        private TextBox PhoneTB;
    }
}