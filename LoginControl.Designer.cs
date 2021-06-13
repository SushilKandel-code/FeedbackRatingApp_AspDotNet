namespace FeedbackRatingApplicaiton
{
    partial class LoginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.loginBoard = new System.Windows.Forms.Panel();
            this.Login = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.LoginMessage = new System.Windows.Forms.Label();
            this.loginBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Username.Location = new System.Drawing.Point(17, 53);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(128, 31);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Password.Location = new System.Drawing.Point(17, 118);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(123, 31);
            this.Password.TabIndex = 0;
            this.Password.Text = "Password";
            // 
            // textUsername
            // 
            this.textUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.Location = new System.Drawing.Point(21, 81);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(309, 37);
            this.textUsername.TabIndex = 1;
            // 
            // loginBoard
            // 
            this.loginBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginBoard.Controls.Add(this.Login);
            this.loginBoard.Controls.Add(this.Username);
            this.loginBoard.Controls.Add(this.textPassword);
            this.loginBoard.Controls.Add(this.textUsername);
            this.loginBoard.Controls.Add(this.Password);
            this.loginBoard.Location = new System.Drawing.Point(204, 102);
            this.loginBoard.Name = "loginBoard";
            this.loginBoard.Size = new System.Drawing.Size(347, 268);
            this.loginBoard.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Maroon;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login.Location = new System.Drawing.Point(108, 196);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(146, 41);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(21, 149);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(309, 37);
            this.textPassword.TabIndex = 2;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // LoginMessage
            // 
            this.LoginMessage.AutoSize = true;
            this.LoginMessage.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginMessage.Location = new System.Drawing.Point(220, 30);
            this.LoginMessage.Name = "LoginMessage";
            this.LoginMessage.Size = new System.Drawing.Size(322, 39);
            this.LoginMessage.TabIndex = 0;
            this.LoginMessage.Text = "Login to Add Criteria ";
            // 
            // LoginUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.loginBoard);
            this.Controls.Add(this.LoginMessage);
            this.MaximumSize = new System.Drawing.Size(755, 550);
            this.MinimumSize = new System.Drawing.Size(755, 550);
            this.Name = "LoginUserControl";
            this.Size = new System.Drawing.Size(755, 550);
            this.loginBoard.ResumeLayout(false);
            this.loginBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Panel loginBoard;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label LoginMessage;
    }
}
