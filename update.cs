﻿using System;
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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void IDTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Load(object sender, EventArgs e)
        {

        }

        private void updatebutt_Click(object sender, EventArgs e)
        {
            bool isIdValid = Regex.IsMatch(IDTB.Text, @"^\d+$");
            if (!isIdValid)
            {
                MessageBox.Show("ID is numeric."); // رسالة خطأ
            }
        }
    }
}
