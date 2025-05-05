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
            panelAuthorization.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxLoginUsers
            // 
            textBoxLoginUsers.Location = new Point(10, 63);
            textBoxLoginUsers.Name = "textBoxLoginUsers";
            textBoxLoginUsers.PlaceholderText = "логин";
            textBoxLoginUsers.Size = new Size(252, 31);
            textBoxLoginUsers.TabIndex = 0;
            // 
            // textBoxPasswordUsers
            // 
            textBoxPasswordUsers.Location = new Point(10, 118);
            textBoxPasswordUsers.Name = "textBoxPasswordUsers";
            textBoxPasswordUsers.PlaceholderText = "пароль";
            textBoxPasswordUsers.Size = new Size(252, 31);
            textBoxPasswordUsers.TabIndex = 0;
            // 
            // buttonEnterToAccount
            // 
            buttonEnterToAccount.Location = new Point(10, 165);
            buttonEnterToAccount.Name = "buttonEnterToAccount";
            buttonEnterToAccount.Size = new Size(252, 34);
            buttonEnterToAccount.TabIndex = 1;
            buttonEnterToAccount.Text = "Вход";
            buttonEnterToAccount.UseVisualStyleBackColor = true;
            // 
            // labelAuthoritation
            // 
            labelAuthoritation.AutoSize = true;
            labelAuthoritation.Location = new Point(75, 18);
            labelAuthoritation.Name = "labelAuthoritation";
            labelAuthoritation.Size = new Size(120, 25);
            labelAuthoritation.TabIndex = 2;
            labelAuthoritation.Text = "Авторизация";
            // 
            // panelAuthorization
            // 
            panelAuthorization.BackColor = SystemColors.ControlLight;
            panelAuthorization.BorderStyle = BorderStyle.FixedSingle;
            panelAuthorization.Controls.Add(labelAuthoritation);
            panelAuthorization.Controls.Add(buttonEnterToAccount);
            panelAuthorization.Controls.Add(textBoxPasswordUsers);
            panelAuthorization.Controls.Add(textBoxLoginUsers);
            panelAuthorization.Location = new Point(257, 60);
            panelAuthorization.Name = "panelAuthorization";
            panelAuthorization.Size = new Size(270, 234);
            panelAuthorization.TabIndex = 3;
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
    }
}