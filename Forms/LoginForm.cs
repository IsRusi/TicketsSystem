using Exam.DataAccess.Repositories;
using Exam.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam.Forms
{
    public partial class LoginForm : Form
    {
        private UserLogic logic=new();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void buttonEnterToAccount_Click(object sender, EventArgs e)
        {

            LoginResult isLogin =logic.Login(textBoxLoginUsers.Text,textBoxPasswordUsers.Text);
           if(isLogin == LoginResult.UserLocked)
            {
                labelAttemptToLogin.Visible = false;
                MessageBox.Show("вы заблокированы");
            }
            else if(isLogin == LoginResult.UserNotFound)
            {
                labelAttemptToLogin.Visible = true;
                labelAttemptToLogin.Text = "аккаунт не найден";
            }
            else if (isLogin == LoginResult.WrongPassword)
            {
                labelAttemptToLogin.Visible = true;
                labelAttemptToLogin.Text = "неверный пароль";
            }
           //if(!isLogin)
           // {
           // MessageBox.Show(isLogin.ToString());
           // }
           // else
           // {
           //     this.Close();
           // }
        }
    }
}
