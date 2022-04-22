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
            //If you play as Guest you are immidiately thrown to the playing groundss
            f_main main = new f_main("guest");
            this.Hide();
            main.Show();
           
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            //Closes every single form that exists in this Programm
            MessageBox.Show("I really appreciate you playing my game. Hoping to see you soon.", "Thanks for playing!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Dispose();
            Environment.Exit(0);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //Let's the Player login to the main menu if his account data is provided in the Database
            f_plogin plogin = new f_plogin();
            plogin.Show();

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //The new Player can create an Account which will automatically be saved into the Database
            f_pregister pregister = new f_pregister();
            pregister.Show();  
        }
    }
}
