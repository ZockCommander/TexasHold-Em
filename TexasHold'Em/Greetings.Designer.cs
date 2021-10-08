
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
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(273, 31);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(174, 100);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stats
            // 
            this.btn_stats.Location = new System.Drawing.Point(273, 137);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(174, 100);
            this.btn_stats.TabIndex = 1;
            this.btn_stats.Text = "Stats";
            this.btn_stats.UseVisualStyleBackColor = true;
            this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
            // 
            // btn_htp
            // 
            this.btn_htp.Location = new System.Drawing.Point(273, 243);
            this.btn_htp.Name = "btn_htp";
            this.btn_htp.Size = new System.Drawing.Size(174, 100);
            this.btn_htp.TabIndex = 2;
            this.btn_htp.Text = "How to Play";
            this.btn_htp.UseVisualStyleBackColor = true;
            this.btn_htp.Click += new System.EventHandler(this.btn_htp_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(273, 349);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(174, 100);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // f_greetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_htp);
            this.Controls.Add(this.btn_stats);
            this.Controls.Add(this.btn_start);
            this.Name = "f_greetings";
            this.Text = "Hello";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stats;
        private System.Windows.Forms.Button btn_htp;
        private System.Windows.Forms.Button btn_logout;
    }
}