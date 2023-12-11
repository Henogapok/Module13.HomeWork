using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13.HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            Bank bank = new Bank();

            while (true)
            {
                Console.WriteLine("1. Встать в очередь");
                Console.WriteLine("2. Вызвать следующего клиента");
                Console.WriteLine("3. Выйти из программы");
                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        EnqueueClient(bank);
                        break;
                    case "2":
                        ServeNextClient(bank);
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                        break;
                }
            }
        }

        static void EnqueueClient(Bank bank)
        {
            Console.Write("Введите имя: ");
            string firstName = Console.ReadLine();

            Console.Write("Введите отчество: ");
            string secondName = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            string lastName = Console.ReadLine();

            Console.Write("Введите дату рождения (гггг-мм-дд): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
            {
                Client newClient = new Client
                {
                    FirstName = firstName,
                    SecondName = secondName,
                    LastName = lastName,
                    BirthDate = birthDate
                    // Добавьте остальные свойства, если необходимо
                };

                bank.Enqueue(newClient);
            }
            else
            {
                Console.WriteLine("Некорректный формат даты. Встать в очередь не удалось.");
            }
        }

        static void ServeNextClient(Bank bank)
        {
            Client servedClient = bank.Dequeue();
            if (servedClient != null)
            {
                // Реализуйте дополнительную логику обслуживания, если необходимо
            }
        }
    }
}
