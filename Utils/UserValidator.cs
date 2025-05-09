using Exam.DataAccess.Models;
using Exam.DataAccess.Repositories;
using Exam.DataAccess.Utils;
using Exam.Utils;
using System;
using System.Text.RegularExpressions;

public class UserValidator
{
    private static RegistrationData? ShowError(string message)
    {
        MessageBox.Show(message);
        return null;
    }
    public static RegistrationData? IsValidData(RegistrationData data)
    {
        if (!IsValidName(data.FirstName))
            return ShowError("Введите корректное имя.");
        if (!IsValidName(data.LastName))
            return ShowError("Введите корректную фамилию.");
        if (!IsValidName(data.Surname))
            return ShowError("Введите корректное отчество.");
        if (string.IsNullOrEmpty(data.Gender))
            return ShowError("Выберите пол.");
        if (!IsValidBirthDate(data.BirthDate))
            return ShowError("Введите корректную дату рождения.");
        if (!IsValidPhone(data.Phone))
            return ShowError("Введите корректный номер телефона.");
        if (!IsValidEmail(data.Email))
            return ShowError("Введите корректный Email.");
        var password = data.Password;
        var confirmPassword = data.ConfirmPassword;
        if (password != confirmPassword)
            return ShowError("Пароли не совпадают.");
        if (string.IsNullOrWhiteSpace(password))
            return ShowError("Введите пароль.");
        if (!IsValidDocumentNumber(data.DocumentNumber))
            return ShowError("Введите корректный номер документа (например, AB1234567).");

        var hashedPassword = CryptPassword.Sha256(password);
        return data;
    }
   
    public static bool IsDigitsInString(string text)
    {
        foreach(var letter in text)
        {
            if(char.IsDigit(letter))
            {
                return true;
            }
        }
        return false;
    }
    public static bool IsValidName(string name) =>
        !string.IsNullOrWhiteSpace(name) && name.Length >= 2 && !IsDigitsInString(name);

    public static bool IsValidGender(bool? isMaleSelected, bool? isFemaleSelected) =>
        isMaleSelected == true || isFemaleSelected == true;

    public static bool IsValidEmail(string email) =>
        !string.IsNullOrWhiteSpace(email) &&
        Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

    public static bool IsValidPhone(string phone) =>
        Regex.IsMatch(phone, @"^\+\d{10,15}$");  

    public static bool IsValidDocumentNumber(string document) =>
        Regex.IsMatch(document, @"^[A-ZА-Я]{2}\d{7}$", RegexOptions.IgnoreCase); 

    public static bool IsValidBirthDate(DateTime birthDate)=>birthDate < DateTime.Today && birthDate > DateTime.Today.AddYears(-120);
   
}
