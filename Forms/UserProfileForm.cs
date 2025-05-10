using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Exam.Forms
{
    public partial class UserProfileForm : Form
    {
        private void LoadUserControlIntoPanel()
        {
            LoginForm childForm = new ();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Size = panelForForm.Size;
            panelForForm.Controls.Add(childForm);
            childForm.Show();
        }
        private Timer time;
        public UserProfileForm()
        {
            InitializeComponent();
            PrintActualDate();
        }
        private void PrintActualDate()
        {
            time = new();
            time.Interval = 1000;
            time.Tick += Timer_Tick;
            time.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            labelData.Text = "Дата:" + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }
        private void linkLabelOrders_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label label)
                label.ForeColor = Color.Black;
        }
        private void linkLabelOrders_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label label)
                label.ForeColor = Color.Crimson;
        }

        private void labelOrders_Click(object sender, EventArgs e)
        {
            LoadUserControlIntoPanel();
        }
    }
}
