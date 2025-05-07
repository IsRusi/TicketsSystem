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
        private (string FirstName, string LastName, string Surname, string Email, string Phone, string Gender, string DocumentNumber, DateTime BirthDate, string Password)? GetRegistrationData()
        {
            var firstName = textBoxName.Text;
            var lastName = textBoxSecondName.Text;
            var surname = textBoxSurname.Text;
            var email = textBoxEmail.Text;
            var phone = textBoxTelephoneNumber.Text;
            var gender = radioButtonGenderMale.Checked ? radioButtonGenderMale.Text :
                         radioButtonGenderFemale.Checked ? radioButtonGenderFemale.Text : string.Empty;
            var documentNumber = textBoxDocumentNumber.Text;
            var birthDate = dateTimePicker1.Value;

            if (!UserValidator.IsValidName(firstName))
                return ShowError("Введите корректное имя.");
            if (!UserValidator.IsValidName(lastName))
                return ShowError("Введите корректную фамилию.");
            if (!UserValidator.IsValidName(surname))
                return ShowError("Введите корректное отчество.");
            if (string.IsNullOrEmpty(gender))
                return ShowError("Выберите пол.");
            if (!UserValidator.IsValidPhone(phone))
                return ShowError("Введите корректный номер телефона.");
            if (!UserValidator.IsValidEmail(email))
                return ShowError("Введите корректный Email.");
            if (!UserValidator.IsValidDocumentNumber(documentNumber))
                return ShowError("Введите корректный номер документа (например, AB1234567).");
            if (!UserValidator.IsValidBirthDate(birthDate))
                return ShowError("Введите корректную дату рождения.");

            var password = textBoxPassword.Text;
            var confirmPassword = textBoxAgreePassword.Text;
            if (password != confirmPassword)
                return ShowError("Пароли не совпадают.");
            if (string.IsNullOrWhiteSpace(password))
                return ShowError("Введите пароль.");

            var hashedPassword = CryptPassword.Sha256(password);
            return (firstName, lastName, surname, email, phone, gender, documentNumber, birthDate, hashedPassword);
        }

        private (string, string, string, string, string, string, string, DateTime, string)? ShowError(string message)
        {
            MessageBox.Show(message);
            return null;
        }

        private void RegistrationFields()
        {
            var input = GetRegistrationData();
            if (input == null)
                return;

            var (firstName, lastName, surname, email, phone, gender, documentNumber, birthDate, password) = input.Value;

            var passanger = new Passanger
            {
                FirstName = firstName,
                LastName = lastName,
                Surname = surname,
                Email = email,
                Phone = phone,
                Gender = gender,
                DocumentNumber = documentNumber,
                BirthDate = birthDate
            };

            var user = new User
            {
                PasswordHash = password,
                FailedLoginAttempts = 0,
                IsLocked = false
            };

            MessageBox.Show(userService.Registration(user, passanger).ToString());
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
