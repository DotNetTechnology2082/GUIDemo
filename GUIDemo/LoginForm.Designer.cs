namespace GUIDemo
{
    partial class LoginForm
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
            lblLoginForm = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnClear = new Button();
            domainUpDown1 = new DomainUpDown();
            SuspendLayout();
            // 
            // lblLoginForm
            // 
            lblLoginForm.AutoSize = true;
            lblLoginForm.Location = new Point(310, 56);
            lblLoginForm.Name = "lblLoginForm";
            lblLoginForm.Size = new Size(117, 30);
            lblLoginForm.TabIndex = 0;
            lblLoginForm.Text = "Login Form";
            lblLoginForm.Click += label1_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(102, 119);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(116, 30);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "User Name";
            lblUsername.Click += label1_Click_1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(102, 204);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(99, 30);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            lblPassword.Click += label2_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(310, 136);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(194, 35);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(310, 204);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(175, 35);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(294, 281);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(131, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(448, 281);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(149, 40);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(0, 0);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(210, 35);
            domainUpDown1.TabIndex = 7;
            domainUpDown1.Text = "domainUpDown1";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(domainUpDown1);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblLoginForm);
            Name = "LoginForm";
            Text = "Form1";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoginForm;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnClear;
        private DomainUpDown domainUpDown1;
    }
}
