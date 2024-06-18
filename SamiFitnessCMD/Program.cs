using SamiFitnessBL.Controller;
using SamiFitnessBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiFitnessCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение SamiFitness");
            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine();

            var userController = new UserController(name);
            if (userController.IsNewUser)
            {
                Console.Write("Введите пол: ");
                var gender = Console.ReadLine();
                DateTime birthDate;
                double weight;
                double height;

                while(true)
                {
                    Console.Write("Введите дату рождения (dd.MM.yyyy): ");
                    if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                    {
                        break;  
                    }
                    else 
                    {
                        Console.WriteLine("Неверный формат даты рождения");
                    }
                }

                userController.SetNewUserData()

            }
            Console.WriteLine(userController.CurrentUser);
            Console.ReadLine();
        }
        private static T double ParseDouble<T>(string name) where T: Double where T: DateTime
        {
            while (true)
            {
                Console.Write($"Введите {name}: ");
                if (double.TryParse(Console.ReadLine(), out T value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Неверный формат {name}");
                }
            }
        }
    }
}
