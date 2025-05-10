using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.IO;
using Exam.DataAccess;
using Exam.Forms;
namespace Exam
{
    public partial class TicketSystem : Form
    {
        public TicketSystem()
        {
            InitializeComponent();
            UserProfileForm userProfileForm= new UserProfileForm();
            userProfileForm.ShowDialog();
            InitializeMinDateTimePicker();
            InitializeMaxDateTimePicker();
            InitializeDateCustomFormat();
        }

        private void InitializeMaxDateTimePicker()
        {
            DateTime nextMonth = DateTime.Today.AddMonths(1);
            dateTimePicker1.MaxDate = new DateTime(nextMonth.Year, nextMonth.Month,
                              DateTime.DaysInMonth(nextMonth.Year, nextMonth.Month));
        }
        private void InitializeMinDateTimePicker()
        {
            DateTime tempDate = new(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker1.MinDate = tempDate;
        }
        private void InitializeDateCustomFormat()
        {
            dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }
        private void DateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.CustomFormat = null;
        }

        private void dateTimePicker1_ChangeUICues(object sender, UICuesEventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.CustomFormat = null;
        }

        private void pictureLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm=new();
            loginForm.ShowDialog();
        }
    }
}
