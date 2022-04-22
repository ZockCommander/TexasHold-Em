
namespace TexasHold_Em
{
    partial class f_login
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
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_Guest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_login = new System.Windows.Forms.PictureBox();
            this.btn_quit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(56, 245);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(97, 36);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(56, 287);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(97, 36);
            this.btn_register.TabIndex = 1;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_Guest
            // 
            this.btn_Guest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.btn_Guest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Guest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Guest.FlatAppearance.BorderSize = 0;
            this.btn_Guest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guest.ForeColor = System.Drawing.Color.White;
            this.btn_Guest.Location = new System.Drawing.Point(56, 329);
            this.btn_Guest.Name = "btn_Guest";
            this.btn_Guest.Size = new System.Drawing.Size(97, 36);
            this.btn_Guest.TabIndex = 2;
            this.btn_Guest.Text = "Guest";
            this.btn_Guest.UseVisualStyleBackColor = false;
            this.btn_Guest.Click += new System.EventHandler(this.btn_Guest_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pb_login);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.btn_register);
            this.panel1.Controls.Add(this.btn_Guest);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 450);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::TexasHold_Em.Properties.Resources.play_as_guest_icon;
            this.pictureBox2.Location = new System.Drawing.Point(25, 329);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 36);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::TexasHold_Em.Properties.Resources.stocks_icon;
            this.pictureBox1.Location = new System.Drawing.Point(25, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 36);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pb_login
            // 
            this.pb_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_login.Image = global::TexasHold_Em.Properties.Resources.user_icon;
            this.pb_login.Location = new System.Drawing.Point(25, 245);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(35, 36);
            this.pb_login.TabIndex = 5;
            this.pb_login.TabStop = false;
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_quit.FlatAppearance.BorderSize = 0;
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.Image = global::TexasHold_Em.Properties.Resources.shutdown_def;
            this.btn_quit.Location = new System.Drawing.Point(726, 12);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(62, 47);
            this.btn_quit.TabIndex = 3;
            this.btn_quit.UseVisualStyleBackColor = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // f_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_quit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f_login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_Guest;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_login;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}