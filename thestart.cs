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
            Button Buttclick = sender as Button;
            if (Buttclick == regisbutt)
            {

                registration regis = new registration();
                regis.Show();


            }
            else if (Buttclick == searchbutt)
            {
                search sear = new search();
                sear.Show();

            }
            else if (Buttclick == updateButt)
            {
                update upda = new update();
                upda.Show();

            }
            else if (Buttclick == deletebutt)
            {
                delete del = new delete();
                del.Show();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void thestart_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
