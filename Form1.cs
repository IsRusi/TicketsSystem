using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.IO;
using Exam.Data;
namespace Exam
{
    public partial class TicketSystem : Form
    {
        public TicketSystem()
        {

            DatabaseConnection connection =new();
            connection.OpenConnection();
            MessageBox.Show("works");
            connection.CloseConnection();
            InitializeComponent();
        }

        private void TicketSystem_Load(object sender, EventArgs e)
        {

        }
    }
}
