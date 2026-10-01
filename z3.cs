/*
using System;
using System.Collections.Generic;
using System.IO;

namespace EnterpriseEquipmentDemo
{
    class Equipment
    {
        public string ModelName { get; set; }
        public string SerialNumber { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Equipment> registrationQueue = new List<Equipment>
            {
                new Equipment { ModelName = "Сервер SRV-200", SerialNumber = "SN-99482" },
                new Equipment { ModelName = "Коммутатор SW-10", SerialNumber = "" }, // Ошибка: пустой серийник!
                new Equipment { ModelName = "Маршрутизатор RT-5", SerialNumber = "SN-11023" }
            };

            Console.WriteLine("Запуск процедуры регистрации нового оборудования...");
            RegisterEquipmentBatch(registrationQueue);

            Console.WriteLine("Процедура регистрации завершена.");
        }

        static void RegisterEquipmentBatch(List<Equipment> items)
        {
            foreach (var item in items)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(item.SerialNumber))
                    {
                        throw new ArgumentException("Серийный номер оборудования не указан");
                    }

                    RegisterInSystem(item);
                }
                catch (ArgumentException ex)
                {
                    string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "equipment_errors.log");
                    string line = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}]  Model: {item.ModelName} | Error: {ex.Message}";
                    Console.WriteLine($"[ОШИБКА] {line}");
                    File.AppendAllText(logPath, line + Environment.NewLine);
                }
            }
        }

        static void RegisterInSystem(Equipment eq)
        {
            Console.WriteLine($"[СИСТЕМА] Оборудование '{eq.ModelName}' (S/N: {eq.SerialNumber}) успешно внесено в реестр.");
        }
    }
}
*/