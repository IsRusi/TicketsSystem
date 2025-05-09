using Exam.DataAccess.Models;
using Exam.DataAccess.Repositories;
using Exam.DataAccess.Utils;
using Exam.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Exam.Forms
{
    public partial class RegistationForm : Form
    {
        private UserLogic userService = new();
        public RegistationForm()
        {
            InitializeComponent();
            InitializeRadioButtons();
        }

        private void InitializeRadioButtons()
        {
            radioButtonGenderMale.Checked = true;
        }
        private RegistrationData? GetRegistrationData()
        {
            var data = new RegistrationData
            {
                FirstName = textBoxName.Text,
                LastName = textBoxSecondName.Text,
                Surname = textBoxSurname.Text,
                Email = textBoxEmail.Text,
                Phone = textBoxTelephoneNumber.Text,
                Gender = radioButtonGenderMale.Checked ? radioButtonGenderMale.Text :
                         radioButtonGenderFemale.Checked ? radioButtonGenderFemale.Text : "",
                DocumentNumber = textBoxDocumentNumber.Text,
                BirthDate = dateTimePicker1.Value,
                Password = textBoxPassword.Text,
                ConfirmPassword = textBoxAgreePassword.Text
            };
            return data;
        }
        private void ClearData()
        {
            textBoxAgreePassword.Text = string.Empty;
            textBoxDocumentNumber.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxSecondName.Text = string.Empty;
            textBoxSurname.Text = string.Empty;
            textBoxTelephoneNumber.Text = string.Empty;
            dateTimePicker1.Value= DateTime.Today;
        }
        
        private void RegistrationFields()
        {
            var input = GetRegistrationData();
            if (input == null)
                return;

            var result = UserValidator.IsValidData(input);

            var isRegistrated =userService.Registration(input);
            if (isRegistrated == RegistrationResult.Success)
            {
                MessageBox.Show("вы успешно зарегистрировались");
                ClearData();
            }
            else if (isRegistrated == RegistrationResult.UserAlreadyExists)
                MessageBox.Show("такой пользователь уже существует");
        }
        private void linkLabelToAuthorization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            LoginForm loginForm = new();
            loginForm.Show();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            RegistrationFields();
        }
    }
}
