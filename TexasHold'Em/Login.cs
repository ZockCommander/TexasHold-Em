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
    public partial class f_login : Form
    {
        public f_login()
        {
            InitializeComponent();
        }



        private void btn_Guest_Click(object sender, EventArgs e)
        {
            f_main main = new f_main();
            this.Hide();
            main.Show();
           
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I really appreciate you playing my game. Hoping to see you soon.", "Thanks for playing!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Dispose();
            Environment.Exit(0);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            f_plogin plogin = new f_plogin();
            this.Hide();
            plogin.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            f_pregister pregister = new f_pregister();
            this.Hide();
            pregister.Show();
        }
    }
}
