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
            //Checks if the passwords match, the name of the player is filled in and the passwords do not have an abnormal length and a minimum length
            if (tb_pwconfirm.Text == tb_pw.Text &&tb_pw.Text.Length >= 8 && tb_pwconfirm.Text.Length >= 8)
            {
                MessageBox.Show("You have succesfully registered yourself!", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f_login login = new f_login();
                this.Close();
            }
            else
            {
                MessageBox.Show("The passwords do not match or you didn't fill out every Box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void tb_pw_TextChanged(object sender, EventArgs e)
        {
            tb_pw.PasswordChar = '*';
            //sets * as the password you see from outside
            tb_pw.TextAlign = HorizontalAlignment.Left;
            //aligns the text on the left side of the box
        }

        private void tb_pwconfirm_TextChanged(object sender, EventArgs e)
        {          
            tb_pwconfirm.PasswordChar = '*';
            tb_pwconfirm.TextAlign = HorizontalAlignment.Left;
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            tb_name.MaxLength = 12;
        }
    }
}