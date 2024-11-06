using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq;
using System.Data.SqlClient;


namespace WFinput
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void registration_Load(object sender, EventArgs e)
        {

        }

        private void TBinput(object sender, EventArgs e)
        {

        }

        private void registbutt_Click(object sender, EventArgs e)
        {
            var fields = new[] { IDTB.Text, NameTB.Text, PhoneTB.Text };

            // التحقق من أن IDTB يحتوي على أرقام فقط
            bool isIdValid = Regex.IsMatch(IDTB.Text, @"^\d+$"); // حقل ID يحتوي على أرقام فقط

            // تحقق من جميع الحقول والـ RadioButtons
            if (!isIdValid ||
                fields.Any(field => String.IsNullOrWhiteSpace(field)) ||
                !(MaleRB.Checked || FemaleRB.Checked))
            {
                MessageBox.Show("Please Fill In All Fields and ensure ID is numeric."); // رسالة خطأ
            }
            else
            {
                MessageBox.Show("Registration has been completed successfully."); // رسالة نجاح
            }
        }
    }
}
