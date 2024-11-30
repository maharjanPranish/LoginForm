namespace LoginForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginBtn = new Button();
            username = new TextBox();
            password = new TextBox();
            heading = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginBtn.Font = new Font("Times New Roman", 9F);
            loginBtn.Location = new Point(369, 291);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(72, 34);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // username
            // 
            username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            username.Font = new Font("Times New Roman", 9F);
            username.Location = new Point(343, 166);
            username.Name = "username";
            username.PlaceholderText = "Enter your username...";
            username.Size = new Size(210, 21);
            username.TabIndex = 1;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            password.Font = new Font("Times New Roman", 9F);
            password.Location = new Point(343, 212);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Enter your password heere...";
            password.Size = new Size(210, 21);
            password.TabIndex = 2;
            // 
            // heading
            // 
            heading.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            heading.AutoSize = true;
            heading.Font = new Font("Times New Roman", 15F);
            heading.Location = new Point(322, 90);
            heading.Name = "heading";
            heading.Size = new Size(168, 22);
            heading.TabIndex = 3;
            heading.Text = "SNMV Login Portal";
            heading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Times New Roman", 9F);
            usernameLabel.Location = new Point(266, 169);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(58, 15);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Times New Roman", 9F);
            passwordLabel.Location = new Point(266, 215);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 450);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(heading);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(loginBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private Button loginBtn;
        private TextBox username;
        private TextBox password;
        private Label heading;
        private Label usernameLabel;
        private Label passwordLabel;
    }
}
