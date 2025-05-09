namespace Exam.Forms
{
    partial class LoginForm
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
            textBoxLoginUsers = new TextBox();
            textBoxPasswordUsers = new TextBox();
            buttonEnterToAccount = new Button();
            labelAuthoritation = new Label();
            panelAuthorization = new Panel();
            labelAttemptToLogin = new Label();
            linkToRecoveryPassword = new LinkLabel();
            linkToRegistration = new LinkLabel();
            panelAuthorization.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxLoginUsers
            // 
            textBoxLoginUsers.Location = new Point(25, 63);
            textBoxLoginUsers.Name = "textBoxLoginUsers";
            textBoxLoginUsers.PlaceholderText = "логин";
            textBoxLoginUsers.Size = new Size(258, 31);
            textBoxLoginUsers.TabIndex = 0;
            // 
            // textBoxPasswordUsers
            // 
            textBoxPasswordUsers.Location = new Point(25, 115);
            textBoxPasswordUsers.Name = "textBoxPasswordUsers";
            textBoxPasswordUsers.PasswordChar = '*';
            textBoxPasswordUsers.PlaceholderText = "пароль";
            textBoxPasswordUsers.Size = new Size(258, 31);
            textBoxPasswordUsers.TabIndex = 1;
            // 
            // buttonEnterToAccount
            // 
            buttonEnterToAccount.Location = new Point(25, 177);
            buttonEnterToAccount.Name = "buttonEnterToAccount";
            buttonEnterToAccount.Size = new Size(258, 34);
            buttonEnterToAccount.TabIndex = 2;
            buttonEnterToAccount.Text = "Вход";
            buttonEnterToAccount.UseVisualStyleBackColor = true;
            buttonEnterToAccount.Click += buttonEnterToAccount_Click;
            // 
            // labelAuthoritation
            // 
            labelAuthoritation.AutoSize = true;
            labelAuthoritation.Location = new Point(96, 21);
            labelAuthoritation.Name = "labelAuthoritation";
            labelAuthoritation.Size = new Size(120, 25);
            labelAuthoritation.TabIndex = 2;
            labelAuthoritation.Text = "Авторизация";
            // 
            // panelAuthorization
            // 
            panelAuthorization.BackColor = SystemColors.ControlLight;
            panelAuthorization.BorderStyle = BorderStyle.FixedSingle;
            panelAuthorization.Controls.Add(labelAttemptToLogin);
            panelAuthorization.Controls.Add(linkToRecoveryPassword);
            panelAuthorization.Controls.Add(linkToRegistration);
            panelAuthorization.Controls.Add(labelAuthoritation);
            panelAuthorization.Controls.Add(buttonEnterToAccount);
            panelAuthorization.Controls.Add(textBoxPasswordUsers);
            panelAuthorization.Controls.Add(textBoxLoginUsers);
            panelAuthorization.Location = new Point(245, 57);
            panelAuthorization.Name = "panelAuthorization";
            panelAuthorization.Size = new Size(321, 267);
            panelAuthorization.TabIndex = 3;
            // 
            // labelAttemptToLogin
            // 
            labelAttemptToLogin.AutoSize = true;
            labelAttemptToLogin.ForeColor = Color.Red;
            labelAttemptToLogin.Location = new Point(25, 149);
            labelAttemptToLogin.Name = "labelAttemptToLogin";
            labelAttemptToLogin.Size = new Size(158, 25);
            labelAttemptToLogin.TabIndex = 5;
            labelAttemptToLogin.Text = "неверный пароль";
            labelAttemptToLogin.Visible = false;
            // 
            // linkToRecoveryPassword
            // 
            linkToRecoveryPassword.AutoSize = true;
            linkToRecoveryPassword.LinkColor = Color.Black;
            linkToRecoveryPassword.Location = new Point(147, 223);
            linkToRecoveryPassword.Name = "linkToRecoveryPassword";
            linkToRecoveryPassword.Size = new Size(145, 25);
            linkToRecoveryPassword.TabIndex = 4;
            linkToRecoveryPassword.TabStop = true;
            linkToRecoveryPassword.Text = "Забыли пароль?";
            linkToRecoveryPassword.LinkClicked += linkToRecoverPassword_LinkClicked;
            // 
            // linkToRegistration
            // 
            linkToRegistration.AutoSize = true;
            linkToRegistration.LinkColor = Color.Black;
            linkToRegistration.Location = new Point(13, 223);
            linkToRegistration.Name = "linkToRegistration";
            linkToRegistration.Size = new Size(113, 25);
            linkToRegistration.TabIndex = 3;
            linkToRegistration.TabStop = true;
            linkToRegistration.Text = "Регистрация";
            linkToRegistration.LinkClicked += linkToRegistration_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelAuthorization);
            Name = "LoginForm";
            Text = "LoginForm";
            panelAuthorization.ResumeLayout(false);
            panelAuthorization.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxLoginUsers;
        private TextBox textBoxPasswordUsers;
        private Button buttonEnterToAccount;
        private Label labelAuthoritation;
        private Panel panelAuthorization;
        private LinkLabel linkToRegistration;
        private LinkLabel linkToRecoveryPassword;
        private Label labelAttemptToLogin;
    }
}