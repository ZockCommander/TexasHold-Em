
namespace TexasHold_Em
{
    partial class f_greetings
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
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stats = new System.Windows.Forms.Button();
            this.btn_htp = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Location = new System.Drawing.Point(273, 31);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(174, 100);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stats
            // 
            this.btn_stats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.btn_stats.FlatAppearance.BorderSize = 0;
            this.btn_stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stats.ForeColor = System.Drawing.Color.White;
            this.btn_stats.Location = new System.Drawing.Point(273, 137);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(174, 100);
            this.btn_stats.TabIndex = 1;
            this.btn_stats.Text = "Stats";
            this.btn_stats.UseVisualStyleBackColor = false;
            this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
            // 
            // btn_htp
            // 
            this.btn_htp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.btn_htp.FlatAppearance.BorderSize = 0;
            this.btn_htp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_htp.ForeColor = System.Drawing.Color.White;
            this.btn_htp.Location = new System.Drawing.Point(273, 243);
            this.btn_htp.Name = "btn_htp";
            this.btn_htp.Size = new System.Drawing.Size(174, 100);
            this.btn_htp.TabIndex = 2;
            this.btn_htp.Text = "How to Play";
            this.btn_htp.UseVisualStyleBackColor = false;
            this.btn_htp.Click += new System.EventHandler(this.btn_htp_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(273, 349);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(174, 100);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_username.Location = new System.Drawing.Point(76, 9);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(0, 13);
            this.lbl_username.TabIndex = 4;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_name.Location = new System.Drawing.Point(12, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(58, 13);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "Username:";
            // 
            // f_greetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_htp);
            this.Controls.Add(this.btn_stats);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f_greetings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello";
            this.Load += new System.EventHandler(this.f_greetings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stats;
        private System.Windows.Forms.Button btn_htp;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_name;
    }
}