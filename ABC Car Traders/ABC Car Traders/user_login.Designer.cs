namespace ABC_Car_Traders
{
    partial class user_login
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
            this.user_login_panel = new System.Windows.Forms.Panel();
            this.cancle_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_lb = new System.Windows.Forms.Label();
            this.user_login_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_login_panel
            // 
            this.user_login_panel.BackColor = System.Drawing.Color.LightGray;
            this.user_login_panel.Controls.Add(this.cancle_btn);
            this.user_login_panel.Controls.Add(this.login_btn);
            this.user_login_panel.Controls.Add(this.password_textbox);
            this.user_login_panel.Controls.Add(this.label2);
            this.user_login_panel.Controls.Add(this.email_textbox);
            this.user_login_panel.Controls.Add(this.label1);
            this.user_login_panel.Controls.Add(this.Login_lb);
            this.user_login_panel.Location = new System.Drawing.Point(507, 157);
            this.user_login_panel.Name = "user_login_panel";
            this.user_login_panel.Size = new System.Drawing.Size(430, 312);
            this.user_login_panel.TabIndex = 0;
            // 
            // cancle_btn
            // 
            this.cancle_btn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.cancle_btn.FlatAppearance.BorderSize = 0;
            this.cancle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancle_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancle_btn.Location = new System.Drawing.Point(45, 250);
            this.cancle_btn.Name = "cancle_btn";
            this.cancle_btn.Size = new System.Drawing.Size(342, 37);
            this.cancle_btn.TabIndex = 7;
            this.cancle_btn.Text = "Cancle";
            this.cancle_btn.UseVisualStyleBackColor = false;
            this.cancle_btn.Click += new System.EventHandler(this.cancle_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Crimson;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(45, 207);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(342, 37);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "Log in";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // password_textbox
            // 
            this.password_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.Location = new System.Drawing.Point(45, 157);
            this.password_textbox.Multiline = true;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(342, 30);
            this.password_textbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // email_textbox
            // 
            this.email_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.email_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_textbox.Location = new System.Drawing.Point(45, 88);
            this.email_textbox.Multiline = true;
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(342, 30);
            this.email_textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // Login_lb
            // 
            this.Login_lb.AutoSize = true;
            this.Login_lb.BackColor = System.Drawing.Color.Transparent;
            this.Login_lb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_lb.Location = new System.Drawing.Point(175, 22);
            this.Login_lb.Name = "Login_lb";
            this.Login_lb.Size = new System.Drawing.Size(109, 32);
            this.Login_lb.TabIndex = 1;
            this.Login_lb.Text = "Sign in";
            this.Login_lb.Click += new System.EventHandler(this.Login_lb_Click);
            // 
            // user_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.login_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 557);
            this.Controls.Add(this.user_login_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "user_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "user_login";
            this.user_login_panel.ResumeLayout(false);
            this.user_login_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel user_login_panel;
        private System.Windows.Forms.Label Login_lb;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancle_btn;
        private System.Windows.Forms.Button login_btn;
    }
}