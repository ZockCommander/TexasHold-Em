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
    public partial class f_main : Form
    {
        public f_main()
        {
          // int playercount = 0;
           //t_pm = Timer per Move
            InitializeComponent();
        }

        private void Btn_leave_Click(object sender, EventArgs e)
        {
           //Checks if logged in player has an account or is logged in as a guest. If he is a guest he gets immidiately thrown back to start screen.
            f_greetings greeting = new f_greetings();
            this.Close();
            greeting.Show();
        } 

        private void Timer_pm_Tick(object sender, EventArgs e)
        {
          //Checks if the 30 sec have run out
            if(t_pm.Interval == 30000)
            {
                //If player1 does something time has to be reset and the pc starts if not after 30 sec pc starts
            }

        }
    }
}
