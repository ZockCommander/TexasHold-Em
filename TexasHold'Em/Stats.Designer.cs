
namespace TexasHold_Em
{
    partial class F_stats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_lvl = new System.Windows.Forms.Label();
            this.lbl_bal = new System.Windows.Forms.Label();
            this.lbl_pg = new System.Windows.Forms.Label();
            this.Pb_lvl = new System.Windows.Forms.ProgressBar();
            this.lbl_pname = new System.Windows.Forms.Label();
            this.t_ts1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_level = new System.Windows.Forms.Label();
            this.lbl_playedGames = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(627, 344);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(132, 74);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(30, 19);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // lbl_lvl
            // 
            this.lbl_lvl.AutoSize = true;
            this.lbl_lvl.ForeColor = System.Drawing.Color.White;
            this.lbl_lvl.Location = new System.Drawing.Point(30, 84);
            this.lbl_lvl.Name = "lbl_lvl";
            this.lbl_lvl.Size = new System.Drawing.Size(33, 13);
            this.lbl_lvl.TabIndex = 2;
            this.lbl_lvl.Text = "Level";
            // 
            // lbl_bal
            // 
            this.lbl_bal.AutoSize = true;
            this.lbl_bal.ForeColor = System.Drawing.Color.White;
            this.lbl_bal.Location = new System.Drawing.Point(30, 144);
            this.lbl_bal.Name = "lbl_bal";
            this.lbl_bal.Size = new System.Drawing.Size(46, 13);
            this.lbl_bal.TabIndex = 3;
            this.lbl_bal.Text = "Balance";
            // 
            // lbl_pg
            // 
            this.lbl_pg.AutoSize = true;
            this.lbl_pg.ForeColor = System.Drawing.Color.White;
            this.lbl_pg.Location = new System.Drawing.Point(30, 215);
            this.lbl_pg.Name = "lbl_pg";
            this.lbl_pg.Size = new System.Drawing.Size(75, 13);
            this.lbl_pg.TabIndex = 4;
            this.lbl_pg.Text = "Played Games";
            // 
            // Pb_lvl
            // 
            this.Pb_lvl.ForeColor = System.Drawing.Color.Lime;
            this.Pb_lvl.Location = new System.Drawing.Point(40, 113);
            this.Pb_lvl.Name = "Pb_lvl";
            this.Pb_lvl.Size = new System.Drawing.Size(629, 21);
            this.Pb_lvl.Step = 1;
            this.Pb_lvl.TabIndex = 5;
            // 
            // lbl_pname
            // 
            this.lbl_pname.AutoSize = true;
            this.lbl_pname.ForeColor = System.Drawing.Color.White;
            this.lbl_pname.Location = new System.Drawing.Point(47, 41);
            this.lbl_pname.Name = "lbl_pname";
            this.lbl_pname.Size = new System.Drawing.Size(0, 13);
            this.lbl_pname.TabIndex = 6;
            // 
            // t_ts1
            // 
            this.t_ts1.Enabled = true;
            this.t_ts1.Interval = 1000;
            this.t_ts1.Tick += new System.EventHandler(this.Timer_ts1_Tick);
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.ForeColor = System.Drawing.Color.White;
            this.lbl_level.Location = new System.Drawing.Point(72, 84);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(33, 13);
            this.lbl_level.TabIndex = 7;
            this.lbl_level.Text = "Level";
            // 
            // lbl_playedGames
            // 
            this.lbl_playedGames.AutoSize = true;
            this.lbl_playedGames.ForeColor = System.Drawing.Color.White;
            this.lbl_playedGames.Location = new System.Drawing.Point(124, 215);
            this.lbl_playedGames.Name = "lbl_playedGames";
            this.lbl_playedGames.Size = new System.Drawing.Size(75, 13);
            this.lbl_playedGames.TabIndex = 8;
            this.lbl_playedGames.Text = "Played Games";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.ForeColor = System.Drawing.Color.White;
            this.lbl_balance.Location = new System.Drawing.Point(82, 144);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(46, 13);
            this.lbl_balance.TabIndex = 9;
            this.lbl_balance.Text = "Balance";
            // 
            // F_stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.CancelButton = this.btn_back;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.lbl_playedGames);
            this.Controls.Add(this.lbl_level);
            this.Controls.Add(this.lbl_pname);
            this.Controls.Add(this.Pb_lvl);
            this.Controls.Add(this.lbl_pg);
            this.Controls.Add(this.lbl_bal);
            this.Controls.Add(this.lbl_lvl);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stats";
            this.Load += new System.EventHandler(this.F_stats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_lvl;
        private System.Windows.Forms.Label lbl_bal;
        private System.Windows.Forms.Label lbl_pg;
        private System.Windows.Forms.ProgressBar Pb_lvl;
        public System.Windows.Forms.Label lbl_pname;
        private System.Windows.Forms.Timer t_ts1;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.Label lbl_playedGames;
        private System.Windows.Forms.Label lbl_balance;
    }
}