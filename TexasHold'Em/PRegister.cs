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

        private void Btn_register_Click(object sender, EventArgs e)
        {
            //Checks if the passwords match, the name of the player is filled in and the passwords do not have an abnormal length and a minimum length
            if (tb_pwconfirm.Text == tb_pw.Text &&tb_pw.Text.Length >= 8 && tb_pwconfirm.Text.Length >= 8)
            {
                if (SQLManager.doesUserExist(tb_name.Text))
                {
                    MessageBox.Show("This username already exists!", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    SQLManager.newUser(tb_name.Text, Hasher.getHash(tb_pw.Text));
                    MessageBox.Show("You have succesfully registered yourself!", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f_login login = new f_login();
                    this.Close();
                    login.Show();
                }
            }
            else if(tb_pwconfirm.Text == tb_pw.Text && tb_pw.Text.Length < 8 && tb_pwconfirm.Text.Length < 8)
            {
                MessageBox.Show("The password is too short", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("The passwords do not match or you didn't fill out every single box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void Tb_pw_TextChanged(object sender, EventArgs e)
        {
            tb_pw.PasswordChar = '*';
            //sets * as the password you see from outside
            tb_pw.TextAlign = HorizontalAlignment.Left;
            //aligns the text on the left side of the box         
        }

        private void Tb_pwconfirm_TextChanged(object sender, EventArgs e)
        {          
            tb_pwconfirm.PasswordChar = '*';
            tb_pwconfirm.TextAlign = HorizontalAlignment.Left;
        }

        private void Tb_name_TextChanged(object sender, EventArgs e)
        {
            tb_name.MaxLength = 12;
        }
    }
}