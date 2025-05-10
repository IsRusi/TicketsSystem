namespace Exam.Forms
{
    partial class UserProfileForm
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
            panelHeader = new Panel();
            labelUsersRole = new Label();
            labelData = new Label();
            labelName = new Label();
            panel1 = new Panel();
            labelExitFromAccount = new Label();
            labelProfileData = new Label();
            labelOrders = new Label();
            labelPassangers = new Label();
            labelProfileTitle = new Label();
            panelForForm = new Panel();
            panelHeader.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.ControlLight;
            panelHeader.Controls.Add(labelUsersRole);
            panelHeader.Controls.Add(labelData);
            panelHeader.Controls.Add(labelName);
            panelHeader.Location = new Point(-1, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(804, 42);
            panelHeader.TabIndex = 0;
            // 
            // labelUsersRole
            // 
            labelUsersRole.AutoSize = true;
            labelUsersRole.Location = new Point(438, 9);
            labelUsersRole.Name = "labelUsersRole";
            labelUsersRole.RightToLeft = RightToLeft.No;
            labelUsersRole.Size = new Size(55, 25);
            labelUsersRole.TabIndex = 3;
            labelUsersRole.Text = "Роль:";
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Location = new Point(13, 9);
            labelData.Name = "labelData";
            labelData.Size = new Size(0, 25);
            labelData.TabIndex = 2;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(689, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 25);
            labelName.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(labelExitFromAccount);
            panel1.Controls.Add(labelProfileData);
            panel1.Controls.Add(labelOrders);
            panel1.Controls.Add(labelPassangers);
            panel1.Controls.Add(labelProfileTitle);
            panel1.Location = new Point(1, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 408);
            panel1.TabIndex = 1;
            // 
            // labelExitFromAccount
            // 
            labelExitFromAccount.AutoSize = true;
            labelExitFromAccount.Cursor = Cursors.Hand;
            labelExitFromAccount.Location = new Point(24, 186);
            labelExitFromAccount.Name = "labelExitFromAccount";
            labelExitFromAccount.Size = new Size(64, 25);
            labelExitFromAccount.TabIndex = 1;
            labelExitFromAccount.Text = "Выход";
            labelExitFromAccount.MouseEnter += linkLabelOrders_MouseEnter;
            labelExitFromAccount.MouseLeave += linkLabelOrders_MouseLeave;
            // 
            // labelProfileData
            // 
            labelProfileData.AutoSize = true;
            labelProfileData.Cursor = Cursors.Hand;
            labelProfileData.Location = new Point(24, 126);
            labelProfileData.Name = "labelProfileData";
            labelProfileData.Size = new Size(152, 25);
            labelProfileData.TabIndex = 1;
            labelProfileData.Text = "Данные профиля";
            labelProfileData.MouseEnter += linkLabelOrders_MouseEnter;
            labelProfileData.MouseLeave += linkLabelOrders_MouseLeave;
            // 
            // labelOrders
            // 
            labelOrders.AutoSize = true;
            labelOrders.Cursor = Cursors.Hand;
            labelOrders.Location = new Point(24, 54);
            labelOrders.Name = "labelOrders";
            labelOrders.Size = new Size(70, 25);
            labelOrders.TabIndex = 1;
            labelOrders.Text = "Заказы";
            labelOrders.Click += labelOrders_Click;
            labelOrders.MouseEnter += linkLabelOrders_MouseEnter;
            labelOrders.MouseLeave += linkLabelOrders_MouseLeave;
            // 
            // labelPassangers
            // 
            labelPassangers.AutoSize = true;
            labelPassangers.Cursor = Cursors.Hand;
            labelPassangers.Location = new Point(24, 90);
            labelPassangers.Name = "labelPassangers";
            labelPassangers.Size = new Size(106, 25);
            labelPassangers.TabIndex = 1;
            labelPassangers.Text = "Пассажиры";
            labelPassangers.MouseEnter += linkLabelOrders_MouseEnter;
            labelPassangers.MouseLeave += linkLabelOrders_MouseLeave;
            // 
            // labelProfileTitle
            // 
            labelProfileTitle.AutoSize = true;
            labelProfileTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelProfileTitle.Location = new Point(24, 3);
            labelProfileTitle.Name = "labelProfileTitle";
            labelProfileTitle.Size = new Size(165, 28);
            labelProfileTitle.TabIndex = 0;
            labelProfileTitle.Text = "Личный кабинет";
            // 
            // panelForForm
            // 
            panelForForm.Location = new Point(196, 42);
            panelForForm.Name = "panelForForm";
            panelForForm.Size = new Size(606, 408);
            panelForForm.TabIndex = 2;
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForForm);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            Name = "UserProfileForm";
            Text = "Профиль";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelName;
        private Panel panel1;
        private Label labelPassangers;
        private Label labelProfileTitle;
        private Label labelUsersRole;
        private Label labelData;
        private Label labelExitFromAccount;
        private Label labelProfileData;
        private Label labelOrders;
        private Panel panelForForm;
    }
}