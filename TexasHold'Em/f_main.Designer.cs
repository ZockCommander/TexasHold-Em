
namespace TexasHold_Em
{
    partial class f_main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_call = new System.Windows.Forms.Button();
            this.btn_fold = new System.Windows.Forms.Button();
            this.btn_bet = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_leave = new System.Windows.Forms.Button();
            this.t_pm = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_call
            // 
            this.btn_call.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.btn_call.FlatAppearance.BorderSize = 0;
            this.btn_call.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_call.ForeColor = System.Drawing.Color.White;
            this.btn_call.Location = new System.Drawing.Point(246, 530);
            this.btn_call.Name = "btn_call";
            this.btn_call.Size = new System.Drawing.Size(147, 105);
            this.btn_call.TabIndex = 0;
            this.btn_call.Text = "Call";
            this.btn_call.UseVisualStyleBackColor = false;
            // 
            // btn_fold
            // 
            this.btn_fold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.btn_fold.FlatAppearance.BorderSize = 0;
            this.btn_fold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fold.ForeColor = System.Drawing.Color.White;
            this.btn_fold.Location = new System.Drawing.Point(399, 530);
            this.btn_fold.Name = "btn_fold";
            this.btn_fold.Size = new System.Drawing.Size(147, 105);
            this.btn_fold.TabIndex = 2;
            this.btn_fold.Text = "Fold";
            this.btn_fold.UseVisualStyleBackColor = false;
            // 
            // btn_bet
            // 
            this.btn_bet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.btn_bet.FlatAppearance.BorderSize = 0;
            this.btn_bet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bet.ForeColor = System.Drawing.Color.White;
            this.btn_bet.Location = new System.Drawing.Point(552, 530);
            this.btn_bet.Name = "btn_bet";
            this.btn_bet.Size = new System.Drawing.Size(147, 105);
            this.btn_bet.TabIndex = 3;
            this.btn_bet.Text = "Bet";
            this.btn_bet.UseVisualStyleBackColor = false;
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.btn_check.FlatAppearance.BorderSize = 0;
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check.ForeColor = System.Drawing.Color.White;
            this.btn_check.Location = new System.Drawing.Point(705, 530);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(147, 105);
            this.btn_check.TabIndex = 4;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = false;
            // 
            // btn_leave
            // 
            this.btn_leave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.btn_leave.FlatAppearance.BorderSize = 0;
            this.btn_leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leave.ForeColor = System.Drawing.Color.White;
            this.btn_leave.Location = new System.Drawing.Point(858, 530);
            this.btn_leave.Name = "btn_leave";
            this.btn_leave.Size = new System.Drawing.Size(147, 105);
            this.btn_leave.TabIndex = 5;
            this.btn_leave.Text = "Leave";
            this.btn_leave.UseVisualStyleBackColor = false;
            this.btn_leave.Click += new System.EventHandler(this.Btn_leave_Click);
            // 
            // t_pm
            // 
            this.t_pm.Enabled = true;
            this.t_pm.Interval = 30000;
            this.t_pm.Tick += new System.EventHandler(this.Timer_pm_Tick);
            // 
            // f_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1246, 647);
            this.ControlBox = false;
            this.Controls.Add(this.btn_leave);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btn_bet);
            this.Controls.Add(this.btn_fold);
            this.Controls.Add(this.btn_call);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_call;
        private System.Windows.Forms.Button btn_fold;
        private System.Windows.Forms.Button btn_bet;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_leave;
        private System.Windows.Forms.Timer t_pm;
    }
}

