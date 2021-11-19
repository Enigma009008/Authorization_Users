using Auth_Users.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Auth_Users
{
    class Program
    {
        public static string username;
        public static string password;

        private static List<DataUsers> _DataUsers { get; set; }
        static void Main(string[] args)
        {

            GetInfo();


            _DataUsers = new List<DataUsers>
            {
                new DataUsers(username:"Murad", password: "123"),
                new DataUsers(username:"Admin", password: "666"),
                new DataUsers(username:"User", password: "999"),

            };

            var auth_users = _DataUsers.FirstOrDefault(x => x.Username == username && x.Password == password);

            if (auth_users == null)
            {
                Console.WriteLine("Неверные данные,попробуйте заново");
            }
            else
            {
                Console.WriteLine("Авторизация прошла успешно!");
            }
        }


        public static void GetInfo()
        {
            Console.WriteLine("Введите логин:");
            username = Console.ReadLine();
            Console.WriteLine("Введите пароль:");
            password = Console.ReadLine();
        }
    }
}
