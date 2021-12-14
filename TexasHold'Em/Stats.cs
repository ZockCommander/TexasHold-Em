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
    public partial class f_stats : Form
    {
        public f_stats()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //Closes this form and opens the other one
            f_greetings greet = new f_greetings();
            this.Close();
            greet.Show();
        }

        private void f_stats_Load(object sender, EventArgs e)
        {
            //Checks in Database which player is logged in and puts his or her name in stats
            
            
        }

        //Calculates the amount of Exp based on random numbers for the ProgressBar
        private void CalculateAll(System.Windows.Forms.ProgressBar pb)
        {
            Random rd = new Random();
            int rand_num = rd.Next(1, 100);
            pb_lvl.Step = rand_num;
            int o = 100;
            pb_lvl.Maximum = o;
            int j = rand_num;
            int k = pb_lvl.Value;
            int l = pb_lvl.Maximum;
            int h = 100;
            int t = 1000;
            int zt = 10000;
            int ht = 100000;     
              
                pb_lvl.PerformStep();
           
                if (k == l)
                {
                    pb_lvl.Value = 0;
                    //trying to figure out how to increase the maximum of the progressbar and add the values down there
                    if (l < 1000)
                    {
                    //for (int Max = l + h, l = Max)

                    //{
                         
                    //    pb_lvl.Maximum = Max;
                    //    l = Max;
                    //}
                        pb_lvl.Increment(h);
                    MessageBox.Show(l.ToString(), "Hallo");
                    }
                    else if (l < 10000)
                    {
                        pb_lvl.Increment(t);
                    }
                    else if (l < 100000)
                    {
                        pb_lvl.Increment(zt);
                    }
                    else if (l < 1000000)
                    {
                        pb_lvl.Increment(ht);
                    }

                }
                       


        }

        private void t_ts1_Tick(object sender, EventArgs e)
        {
            if(t_ts1.Interval == 1000)
            {
                CalculateAll(pb_lvl);
            }
            
        }
    }


}

