namespace Exam.Forms
{
    partial class RecoveryPasswordForm
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
            textBoxRecoveryEmail = new TextBox();
            labelRecoveryPassword = new Label();
            panel1 = new Panel();
            buttonNextStepRecoveryAccount = new Button();
            textBoxNewPassword = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxRecoveryEmail
            // 
            textBoxRecoveryEmail.Location = new Point(56, 54);
            textBoxRecoveryEmail.Name = "textBoxRecoveryEmail";
            textBoxRecoveryEmail.PlaceholderText = "Имя ящика";
            textBoxRecoveryEmail.Size = new Size(246, 31);
            textBoxRecoveryEmail.TabIndex = 0;
            // 
            // labelRecoveryPassword
            // 
            labelRecoveryPassword.AutoSize = true;
            labelRecoveryPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRecoveryPassword.Location = new Point(56, 8);
            labelRecoveryPassword.Name = "labelRecoveryPassword";
            labelRecoveryPassword.Size = new Size(246, 28);
            labelRecoveryPassword.TabIndex = 1;
            labelRecoveryPassword.Text = "Восстановление аккаунта";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(buttonNextStepRecoveryAccount);
            panel1.Controls.Add(labelRecoveryPassword);
            panel1.Controls.Add(textBoxNewPassword);
            panel1.Controls.Add(textBoxRecoveryEmail);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(95, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 213);
            panel1.TabIndex = 2;
            // 
            // buttonNextStepRecoveryAccount
            // 
            buttonNextStepRecoveryAccount.Location = new Point(56, 163);
            buttonNextStepRecoveryAccount.Name = "buttonNextStepRecoveryAccount";
            buttonNextStepRecoveryAccount.Size = new Size(246, 34);
            buttonNextStepRecoveryAccount.TabIndex = 2;
            buttonNextStepRecoveryAccount.Text = "Продолжить";
            buttonNextStepRecoveryAccount.UseVisualStyleBackColor = true;
            buttonNextStepRecoveryAccount.Click += buttonNextStepRecoveryAccount_Click;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(56, 100);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.PasswordChar = '*';
            textBoxNewPassword.PlaceholderText = "Введите новый пароль";
            textBoxNewPassword.Size = new Size(246, 31);
            textBoxNewPassword.TabIndex = 1;
            // 
            // RecoveryPasswordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 247);
            Controls.Add(panel1);
            Name = "RecoveryPasswordForm";
            Text = "Восстановление пароля";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxRecoveryEmail;
        private Label labelRecoveryPassword;
        private Panel panel1;
        private Button buttonNextStepRecoveryAccount;
        private TextBox textBoxNewPassword;
    }
}