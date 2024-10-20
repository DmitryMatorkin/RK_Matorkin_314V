using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desktop.validation
{
    static class Validate
    {
        // Метод для проверки на пустую строку
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsValidName(this string name)
        {
            return !name.IsNullOrEmpty() && name.Length >= 3;
        }

        public static bool IsValidEmail(this string email)
        {
            return !email.IsNullOrEmpty() && Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool IsValidPassword(this string password)
        {
            return !password.IsNullOrEmpty() && password.Length >= 6;
        }
        public static void ValidatePasswords(string password, string password2, List<string> errors)
        {
           password != password2)
            {
                errors.Add("Пароли не совпадают!");
            }
        }
    }
}