namespace Exam.Forms
{
    partial class RegistationForm
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
            buttonRegistration = new Button();
            textBoxName = new TextBox();
            labelFirstName = new Label();
            labelRegistration = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelAgreePassword = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxSecondName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxEmail = new TextBox();
            textBoxTelephoneNumber = new TextBox();
            textBoxDocumentNumber = new TextBox();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            radioButtonGenderFemale = new RadioButton();
            radioButtonGenderMale = new RadioButton();
            linkLabelToAuthorization = new LinkLabel();
            labelPassword = new Label();
            label8 = new Label();
            textBoxAgreePassword = new TextBox();
            textBoxPassword = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonRegistration
            // 
            buttonRegistration.Location = new Point(241, 488);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(186, 36);
            buttonRegistration.TabIndex = 10;
            buttonRegistration.Text = "Зарегистрироватьcя";
            buttonRegistration.UseVisualStyleBackColor = true;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(214, 60);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(213, 31);
            textBoxName.TabIndex = 0;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(138, 60);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(47, 25);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "Имя";
            // 
            // labelRegistration
            // 
            labelRegistration.AutoSize = true;
            labelRegistration.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelRegistration.Location = new Point(152, 0);
            labelRegistration.Name = "labelRegistration";
            labelRegistration.Size = new Size(153, 32);
            labelRegistration.TabIndex = 2;
            labelRegistration.Text = "Регистрация";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 103);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 2;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 151);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 2;
            label2.Text = "Отчество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 184);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 2;
            label3.Text = "Пол";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 303);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 2;
            label4.Text = "Email";
            // 
            // labelAgreePassword
            // 
            labelAgreePassword.AutoSize = true;
            labelAgreePassword.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAgreePassword.Location = new Point(-3, 390);
            labelAgreePassword.Name = "labelAgreePassword";
            labelAgreePassword.Size = new Size(195, 21);
            labelAgreePassword.TabIndex = 2;
            labelAgreePassword.Text = "Подтверждение пароля";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(104, 258);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 2;
            label6.Text = "Телефон";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 217);
            label7.Name = "label7";
            label7.Size = new Size(137, 25);
            label7.TabIndex = 2;
            label7.Text = "Дата рождения";
            // 
            // textBoxSecondName
            // 
            textBoxSecondName.Location = new Point(214, 103);
            textBoxSecondName.Name = "textBoxSecondName";
            textBoxSecondName.Size = new Size(213, 31);
            textBoxSecondName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(214, 145);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(213, 31);
            textBoxSurname.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(214, 303);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(213, 31);
            textBoxEmail.TabIndex = 6;
            // 
            // textBoxTelephoneNumber
            // 
            textBoxTelephoneNumber.Location = new Point(214, 258);
            textBoxTelephoneNumber.Name = "textBoxTelephoneNumber";
            textBoxTelephoneNumber.Size = new Size(213, 31);
            textBoxTelephoneNumber.TabIndex = 5;
            // 
            // textBoxDocumentNumber
            // 
            textBoxDocumentNumber.Location = new Point(214, 420);
            textBoxDocumentNumber.Name = "textBoxDocumentNumber";
            textBoxDocumentNumber.Size = new Size(213, 31);
            textBoxDocumentNumber.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(radioButtonGenderFemale);
            panel1.Controls.Add(radioButtonGenderMale);
            panel1.Controls.Add(linkLabelToAuthorization);
            panel1.Controls.Add(labelRegistration);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(labelAgreePassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelFirstName);
            panel1.Controls.Add(textBoxAgreePassword);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxDocumentNumber);
            panel1.Controls.Add(textBoxTelephoneNumber);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBoxSurname);
            panel1.Controls.Add(textBoxSecondName);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(buttonRegistration);
            panel1.Location = new Point(17, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 534);
            panel1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(214, 217);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(213, 31);
            dateTimePicker1.TabIndex = 4;
            // 
            // radioButtonGenderFemale
            // 
            radioButtonGenderFemale.AutoSize = true;
            radioButtonGenderFemale.Location = new Point(329, 182);
            radioButtonGenderFemale.Name = "radioButtonGenderFemale";
            radioButtonGenderFemale.Size = new Size(53, 29);
            radioButtonGenderFemale.TabIndex = 3;
            radioButtonGenderFemale.TabStop = true;
            radioButtonGenderFemale.Text = "Ж";
            radioButtonGenderFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenderMale
            // 
            radioButtonGenderMale.AutoSize = true;
            radioButtonGenderMale.Location = new Point(232, 182);
            radioButtonGenderMale.Name = "radioButtonGenderMale";
            radioButtonGenderMale.Size = new Size(53, 29);
            radioButtonGenderMale.TabIndex = 3;
            radioButtonGenderMale.TabStop = true;
            radioButtonGenderMale.Text = "М";
            radioButtonGenderMale.UseVisualStyleBackColor = true;
            // 
            // linkLabelToAuthorization
            // 
            linkLabelToAuthorization.AutoSize = true;
            linkLabelToAuthorization.ImageAlign = ContentAlignment.BottomCenter;
            linkLabelToAuthorization.LinkColor = Color.Black;
            linkLabelToAuthorization.Location = new Point(48, 494);
            linkLabelToAuthorization.Name = "linkLabelToAuthorization";
            linkLabelToAuthorization.Size = new Size(167, 25);
            linkLabelToAuthorization.TabIndex = 11;
            linkLabelToAuthorization.TabStop = true;
            linkLabelToAuthorization.Text = "Уже есть профиль?";
            linkLabelToAuthorization.LinkClicked += linkLabelToAuthorization_LinkClicked;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(114, 346);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(74, 25);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Пароль";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 420);
            label8.Name = "label8";
            label8.Size = new Size(161, 25);
            label8.TabIndex = 2;
            label8.Text = "Номер документа";
            // 
            // textBoxAgreePassword
            // 
            textBoxAgreePassword.Location = new Point(214, 383);
            textBoxAgreePassword.MaxLength = 3276;
            textBoxAgreePassword.Name = "textBoxAgreePassword";
            textBoxAgreePassword.PasswordChar = '*';
            textBoxAgreePassword.Size = new Size(213, 31);
            textBoxAgreePassword.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(214, 346);
            textBoxPassword.MaxLength = 3276;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(213, 31);
            textBoxPassword.TabIndex = 7;
            // 
            // RegistationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 558);
            Controls.Add(panel1);
            Name = "RegistationForm";
            Text = "RegistationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRegistration;
        private TextBox textBoxName;
        private Label labelFirstName;
        private Label labelRegistration;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelAgreePassword;
        private Label label6;
        private Label label7;
        private TextBox textBoxSecondName;
        private TextBox textBoxSurname;
        private TextBox textBoxEmail;
        private TextBox textBoxTelephoneNumber;
        private TextBox textBoxDocumentNumber;
        private Panel panel1;
        private LinkLabel linkLabelToAuthorization;
        private RadioButton radioButtonGenderFemale;
        private RadioButton radioButtonGenderMale;
        private DateTimePicker dateTimePicker1;
        private Label labelPassword;
        private Label label8;
        private TextBox textBoxPassword;
        private TextBox textBoxAgreePassword;
    }
}