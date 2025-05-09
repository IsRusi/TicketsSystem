namespace Exam
{
    partial class TicketSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketSystem));
            textBoxFrom = new TextBox();
            textBoxWhere = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            searchRouteButton = new Button();
            labelFrom = new Label();
            labelWhere = new Label();
            panelSearchRouteBar = new Panel();
            labelDate = new Label();
            panel1 = new Panel();
            pictureLogin = new PictureBox();
            panelSearchRouteBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogin).BeginInit();
            SuspendLayout();
            // 
            // textBoxFrom
            // 
            textBoxFrom.Location = new Point(5, 28);
            textBoxFrom.Name = "textBoxFrom";
            textBoxFrom.PlaceholderText = "Откуда";
            textBoxFrom.Size = new Size(180, 31);
            textBoxFrom.TabIndex = 0;
            // 
            // textBoxWhere
            // 
            textBoxWhere.Location = new Point(275, 28);
            textBoxWhere.Name = "textBoxWhere";
            textBoxWhere.PlaceholderText = "Куда";
            textBoxWhere.Size = new Size(180, 31);
            textBoxWhere.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.MenuBar;
            dateTimePicker1.Cursor = Cursors.No;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(509, 26);
            dateTimePicker1.MaxDate = new DateTime(2025, 5, 4, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2024, 5, 4, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(126, 31);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2025, 5, 4, 0, 0, 0, 0);
            dateTimePicker1.CloseUp += DateTimePicker1_CloseUp;
            dateTimePicker1.ChangeUICues += dateTimePicker1_ChangeUICues;
            // 
            // searchRouteButton
            // 
            searchRouteButton.Location = new Point(674, 25);
            searchRouteButton.Name = "searchRouteButton";
            searchRouteButton.Size = new Size(112, 34);
            searchRouteButton.TabIndex = 2;
            searchRouteButton.Text = "найти";
            searchRouteButton.UseVisualStyleBackColor = true;
            // 
            // labelFrom
            // 
            labelFrom.AutoSize = true;
            labelFrom.Location = new Point(5, 0);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(70, 25);
            labelFrom.TabIndex = 3;
            labelFrom.Text = "Откуда";
            // 
            // labelWhere
            // 
            labelWhere.AutoSize = true;
            labelWhere.Location = new Point(275, 0);
            labelWhere.Name = "labelWhere";
            labelWhere.Size = new Size(50, 25);
            labelWhere.TabIndex = 3;
            labelWhere.Text = "Куда";
            // 
            // panelSearchRouteBar
            // 
            panelSearchRouteBar.BackColor = SystemColors.ScrollBar;
            panelSearchRouteBar.BorderStyle = BorderStyle.Fixed3D;
            panelSearchRouteBar.Controls.Add(labelDate);
            panelSearchRouteBar.Controls.Add(labelWhere);
            panelSearchRouteBar.Controls.Add(labelFrom);
            panelSearchRouteBar.Controls.Add(searchRouteButton);
            panelSearchRouteBar.Controls.Add(dateTimePicker1);
            panelSearchRouteBar.Controls.Add(textBoxWhere);
            panelSearchRouteBar.Controls.Add(textBoxFrom);
            panelSearchRouteBar.Location = new Point(44, 72);
            panelSearchRouteBar.Name = "panelSearchRouteBar";
            panelSearchRouteBar.Size = new Size(831, 78);
            panelSearchRouteBar.TabIndex = 4;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(509, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(49, 25);
            labelDate.TabIndex = 4;
            labelDate.Text = "Дата";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureLogin);
            panel1.Location = new Point(8, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 63);
            panel1.TabIndex = 5;
            // 
            // pictureLogin
            // 
            pictureLogin.Cursor = Cursors.Hand;
            pictureLogin.Image = Properties.Resources.login_icon;
            pictureLogin.ImageLocation = "";
            pictureLogin.InitialImage = null;
            pictureLogin.Location = new Point(875, 0);
            pictureLogin.Name = "pictureLogin";
            pictureLogin.Size = new Size(43, 41);
            pictureLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogin.TabIndex = 0;
            pictureLogin.TabStop = false;
            pictureLogin.Click += pictureLogin_Click;
            // 
            // TicketSystem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 450);
            Controls.Add(panel1);
            Controls.Add(panelSearchRouteBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TicketSystem";
            Text = "Система билетов";
            panelSearchRouteBar.ResumeLayout(false);
            panelSearchRouteBar.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxFrom;
        private TextBox textBoxWhere;
        private DateTimePicker dateTimePicker1;
        private Button searchRouteButton;
        private Label labelFrom;
        private Label labelWhere;
        private Panel panelSearchRouteBar;
        private Label labelDate;
        private Panel panel1;
        private PictureBox pictureLogin;
    }
}
