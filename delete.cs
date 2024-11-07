using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WFinput
{


    public partial class delete : Form
    {
        string connectionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=YourUsername;Password=YourPassword;";

        public delete()
        {
            InitializeComponent();
        }

        private void deletebutt_Click(object sender, EventArgs e)
        {
            bool isIdValid = Regex.IsMatch(IDTB.Text, @"^\d+$");
            if (!isIdValid)
            {
                MessageBox.Show("ID is numeric."); // رسالة خطأ
            }
        }
    }
}
