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
    public partial class F_stats : Form
    {
        public F_stats()
        {
            InitializeComponent();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            //Closes this form and opens the other one
            f_greetings greet = new f_greetings();
            this.Close();
            greet.Show();
        }

        private void F_stats_Load(object sender, EventArgs e)
        {
            //Checks in Database which player is logged in and puts his or her name in stats
            
            
        }

        //Calculates the amount of Exp based on random numbers for the ProgressBar
        private void CalculateAll(System.Windows.Forms.ProgressBar pb)
        {
            pb.Value = 0;
            Random rd = new Random();
            int rand_num = rd.Next(1, 100);
            Pb_lvl.Step = rand_num;
            int o = 100;
            Pb_lvl.Maximum = o;
            int j = rand_num;
            int k = Pb_lvl.Value;
            int l = Pb_lvl.Maximum;
            int h = 100;
            int t = 1000;
            int zt = 10000;
            int ht = 100000;     
              
                Pb_lvl.PerformStep();
           
                if (k == l)
                {
                    Pb_lvl.Value = 0;
                    //trying to figure out how to increase the maximum of the progressbar and add the values down there
                    if (l < 1000)
                    {
                    Pb_lvl.Value = j;
                    //for (int Max = l + h, l = Max)

                    //{
                         
                    //    pb_lvl.Maximum = Max;
                    //    l = Max;
                    //}
                        Pb_lvl.Increment(h);
                    MessageBox.Show(l.ToString(), "Hallo");
                    }
                    else if (l < 10000)
                    {
                        Pb_lvl.Increment(t);
                    }
                    else if (l < 100000)
                    {
                        Pb_lvl.Increment(zt);
                    }
                    else if (l < 1000000)
                    {
                        Pb_lvl.Increment(ht);
                    }

                }
                       


        }

        private void Timer_ts1_Tick(object sender, EventArgs e)
        {
            if(t_ts1.Interval == 1000)
            {
                CalculateAll(Pb_lvl);
            }
            
        }
    }


}

