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
    public partial class f_pregister : Form
    {
        public f_pregister()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (tb_pwconfirm.Text == tb_pw.Text)
            {
                MessageBox.Show("You have succesfully registered yourself!", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            f_login login = new f_login();
            this.Close();
        }


    }
}