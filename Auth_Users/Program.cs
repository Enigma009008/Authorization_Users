using Auth_Users.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Auth_Users
{
    class Program
    {
        public static string username { get; set; }
        public static string password { get; set; }
        public static byte count { get; set; }
       
        static void Main(string[] args)
        {

            while (count != 3)
            {


                GetInfo();
                ObservableCollection<DataUsers> Users = new ObservableCollection<DataUsers>
            {
                new DataUsers(username:"Murad", password: "123"),
                new DataUsers(username:"Admin", password: "666"),
                new DataUsers(username:"User", password: "999"),

            };

                var auth_users = Users.FirstOrDefault(x => x.Username == username && x.Password == password);

                if (auth_users != null)
                {
                    Console.WriteLine("Здравствуйте, вы успешно авторизовались! ");
                    break;
                }
                else
                {
                    Console.WriteLine("Пользователь не найден!");
                    count++;
                    if (count == 3)
                    {
                        Console.WriteLine("Ваши попытки закончились!");
                        break;
                    }
                }
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
