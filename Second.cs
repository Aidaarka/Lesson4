using System;
using System.Collections.Generic;

namespace ConsoleApp1.Second
{
    struct User
    {
        public string Login;
        public string Password;
    }

    class Verification
    {
        static void Main()
        {
            Dictionary<User, User> users = new Dictionary<User, User>
            {
                { new User() { Password = "qwert" }, new User() { Login = "petrov111" } },
                { new User() { Password = "12345" }, new User() { Login = "petrov222" } },
                { new User() { Password = "54321" }, new User() { Login = "petrov333" } },
                { new User() { Password = "67890" }, new User() { Login = "petrov444" } },
                { new User() { Password = "09876" }, new User() { Login = "petrov555" } }
            };

            Console.Write("Введите логин: ");
            string logIn = Console.ReadLine();

            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();

            foreach (KeyValuePair<User, User> keyValue in users)
            {
                if(password == keyValue.Key.Password && logIn == keyValue.Value.Login)
                {
                    Console.WriteLine($"Вход для пользователя {keyValue.Value.Login} разрешен.");
                }
            }
        }
    }
}
