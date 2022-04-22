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
    public partial class f_htp : Form
    {
        private string username;
        public f_htp(string name)
        {
            username = name;
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            f_greetings greetings = new f_greetings(username);
            this.Close();
            greetings.Show();
        }
    }
}
