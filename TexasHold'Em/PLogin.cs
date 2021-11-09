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
    public partial class f_plogin : Form
    {
        public f_plogin()
        {
            InitializeComponent();
            
        }

        private void btn_plogin_Click(object sender, EventArgs e)
        {
            //Checks if login data is provided in Database. If it's not saved it throws an error otherwise you will be logged in to the main screen
            f_greetings greetings = new f_greetings();
            greetings.Show();
            this.Close();
            this.Dispose();
          
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
