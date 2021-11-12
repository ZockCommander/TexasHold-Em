using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexasHold_Em
{
    public partial class f_stats : Form
    {
        public f_stats()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //Closes this form and opens the other one
            f_greetings greet = new f_greetings();
            this.Close();
            greet.Show();
        }

        private void f_stats_Load(object sender, EventArgs e)
        {
            //Checks in Database which player is logged in and puts his or her name in stats
            
            
        }

        private void pb_lvl_Click(object sender, EventArgs e)
        {

        }
    }
}
