using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFinput
{
    public partial class thestart : Form
    {
        public thestart()
        {
            InitializeComponent();
        }



        


        private void Buttclick(object sender, EventArgs e)
        {
            Button  Buttclick = sender as Button;
            if (Buttclick == regisbutt) {

                registration regis = new registration();
                regis.Show();
                this.Hide();

            }else if (Buttclick == searchbutt)
            {
                search sear = new search();
                sear.Show();
                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
