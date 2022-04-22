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
            if(tb_name.Text != "" && tb_pw.Text != "")
            {
                // get hashed pw from database according to username
                string password = SQLManager.getPassword(tb_name.Text);

                if (password == Hasher.getHash(tb_pw.Text))
                {
                    // Passwords matched               
                    MessageBox.Show("Great! You're logging in!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f_greetings greetings = new f_greetings(tb_name.Text);
                    greetings.Show();
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("It seems you used a wrong password. Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("You didn't fill out the required fields. Please do so to proceed.", "HEY!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }
        #region Textboxes
        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            tb_name.MaxLength = 12;
        }

        private void tb_pw_TextChanged(object sender, EventArgs e)
        {
            tb_pw.PasswordChar = '*';
            tb_pw.TextAlign = HorizontalAlignment.Left;
        }
        #endregion
    }
}
