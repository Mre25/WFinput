﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WFinput
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void searchbutt_Click(object sender, EventArgs e)
        {
            bool isIdValid = Regex.IsMatch(IDTB.Text, @"^\d+$");
            if (!isIdValid)
            {
                MessageBox.Show("ID is numeric."); // رسالة خطأ
            }
        }
    }
}
