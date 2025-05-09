using Exam.DataAccess.Models;
using Exam.Logic;
using Exam.Utils;
using Microsoft.VisualBasic.Logging;
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
    public partial class RecoveryPasswordForm : Form
    {
        private UserLogic userService = new();
        public RecoveryPasswordForm()
        {
            InitializeComponent();
        }

        private void buttonNextStepRecoveryAccount_Click(object sender, EventArgs e)
        { 
            RecoverResult isChangedPassword = userService.RecoverPassword(textBoxRecoveryEmail.Text, textBoxNewPassword.Text);
            if (isChangedPassword == RecoverResult.Success)
            {
                MessageBox.Show("успешно изменен пароль");
            }
            else
            {
                MessageBox.Show("пароль не изменен");

            }
        }
    }
}
