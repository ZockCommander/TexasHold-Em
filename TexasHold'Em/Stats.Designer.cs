
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
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(836, 423);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(176, 91);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(40, 23);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // lbl_lvl
            // 
            this.lbl_lvl.AutoSize = true;
            this.lbl_lvl.Location = new System.Drawing.Point(40, 103);
            this.lbl_lvl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lvl.Name = "lbl_lvl";
            this.lbl_lvl.Size = new System.Drawing.Size(42, 17);
            this.lbl_lvl.TabIndex = 2;
            this.lbl_lvl.Text = "Level";
            // 
            // lbl_bal
            // 
            this.lbl_bal.AutoSize = true;
            this.lbl_bal.Location = new System.Drawing.Point(40, 177);
            this.lbl_bal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bal.Name = "lbl_bal";
            this.lbl_bal.Size = new System.Drawing.Size(59, 17);
            this.lbl_bal.TabIndex = 3;
            this.lbl_bal.Text = "Balance";
            // 
            // lbl_pg
            // 
            this.lbl_pg.AutoSize = true;
            this.lbl_pg.Location = new System.Drawing.Point(40, 265);
            this.lbl_pg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pg.Name = "lbl_pg";
            this.lbl_pg.Size = new System.Drawing.Size(100, 17);
            this.lbl_pg.TabIndex = 4;
            this.lbl_pg.Text = "Played Games";
            // 
            // Pb_lvl
            // 
            this.Pb_lvl.ForeColor = System.Drawing.Color.Lime;
            this.Pb_lvl.Location = new System.Drawing.Point(53, 139);
            this.Pb_lvl.Margin = new System.Windows.Forms.Padding(4);
            this.Pb_lvl.Maximum = 1000000;
            this.Pb_lvl.Name = "Pb_lvl";
            this.Pb_lvl.Size = new System.Drawing.Size(839, 26);
            this.Pb_lvl.TabIndex = 5;
            // 
            // lbl_pname
            // 
            this.lbl_pname.AutoSize = true;
            this.lbl_pname.Location = new System.Drawing.Point(63, 50);
            this.lbl_pname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pname.Name = "lbl_pname";
            this.lbl_pname.Size = new System.Drawing.Size(0, 17);
            this.lbl_pname.TabIndex = 6;
            // 
            // t_ts1
            // 
            this.t_ts1.Enabled = true;
            this.t_ts1.Interval = 1000;
            this.t_ts1.Tick += new System.EventHandler(this.Timer_ts1_Tick);
            // 
            // F_stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbl_pname);
            this.Controls.Add(this.Pb_lvl);
            this.Controls.Add(this.lbl_pg);
            this.Controls.Add(this.lbl_bal);
            this.Controls.Add(this.lbl_lvl);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_back);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_stats";
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
    }
}