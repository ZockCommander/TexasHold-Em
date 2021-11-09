
namespace TexasHold_Em
{
    partial class f_stats
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
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_lvl = new System.Windows.Forms.Label();
            this.lbl_bal = new System.Windows.Forms.Label();
            this.lbl_pg = new System.Windows.Forms.Label();
            this.pb_lvl = new System.Windows.Forms.ProgressBar();
            this.lbl_pname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(627, 344);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(132, 74);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(30, 19);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // lbl_lvl
            // 
            this.lbl_lvl.AutoSize = true;
            this.lbl_lvl.Location = new System.Drawing.Point(30, 84);
            this.lbl_lvl.Name = "lbl_lvl";
            this.lbl_lvl.Size = new System.Drawing.Size(33, 13);
            this.lbl_lvl.TabIndex = 2;
            this.lbl_lvl.Text = "Level";
            // 
            // lbl_bal
            // 
            this.lbl_bal.AutoSize = true;
            this.lbl_bal.Location = new System.Drawing.Point(30, 144);
            this.lbl_bal.Name = "lbl_bal";
            this.lbl_bal.Size = new System.Drawing.Size(46, 13);
            this.lbl_bal.TabIndex = 3;
            this.lbl_bal.Text = "Balance";
            // 
            // lbl_pg
            // 
            this.lbl_pg.AutoSize = true;
            this.lbl_pg.Location = new System.Drawing.Point(30, 215);
            this.lbl_pg.Name = "lbl_pg";
            this.lbl_pg.Size = new System.Drawing.Size(75, 13);
            this.lbl_pg.TabIndex = 4;
            this.lbl_pg.Text = "Played Games";
            // 
            // pb_lvl
            // 
            this.pb_lvl.ForeColor = System.Drawing.Color.Lime;
            this.pb_lvl.Location = new System.Drawing.Point(40, 113);
            this.pb_lvl.Name = "pb_lvl";
            this.pb_lvl.Size = new System.Drawing.Size(629, 21);
            this.pb_lvl.TabIndex = 5;
            // 
            // lbl_pname
            // 
            this.lbl_pname.AutoSize = true;
            this.lbl_pname.Location = new System.Drawing.Point(47, 41);
            this.lbl_pname.Name = "lbl_pname";
            this.lbl_pname.Size = new System.Drawing.Size(0, 13);
            this.lbl_pname.TabIndex = 6;
            // 
            // f_stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_pname);
            this.Controls.Add(this.pb_lvl);
            this.Controls.Add(this.lbl_pg);
            this.Controls.Add(this.lbl_bal);
            this.Controls.Add(this.lbl_lvl);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_back);
            this.Name = "f_stats";
            this.Text = "Stats";
            this.Load += new System.EventHandler(this.f_stats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_lvl;
        private System.Windows.Forms.Label lbl_bal;
        private System.Windows.Forms.Label lbl_pg;
        private System.Windows.Forms.ProgressBar pb_lvl;
        public System.Windows.Forms.Label lbl_pname;
    }
}