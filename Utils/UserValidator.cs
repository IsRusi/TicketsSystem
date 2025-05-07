using System;
using System.Text.RegularExpressions;

public class UserValidator
{
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
