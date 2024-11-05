using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

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
            if (new[]{ ID.Text,
                Fullname.Name,
                Major.Text,
                Academicyear.Text,
                Address.Text,
                Phone.Text }
                .Any(field =>String.IsNullOrWhiteSpace(field)))
                {
                MessageBox.Show("Please Fill In All Fields.");
                }
            else
            {
                MessageBox.Show("Registration has been completed successfully.");
            }
        }
    }
}
