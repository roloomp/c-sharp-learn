/*
using System;
using System.Collections.Generic;
using System.IO;

namespace EnterpriseDirectoryDemo
{
    // Модель данных сотрудника
    class Employee
    {
        public string FullName { get; set; }
        public string Department { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> incomingPayloads = new List<Employee>
            {
                new Employee { FullName = "Иванов И.И.", Department = "IT" },
                null,
                new Employee { FullName = null, Department = "HR" },
                new Employee { FullName = "Петров П.П.", Department = "Finance" }
            };

            Console.WriteLine("Запуск пакетной обработки профилей сотрудников...");
            ProcessDirectoryUpdate(incomingPayloads);

            Console.WriteLine("Пакетная обработка завершена.");
        }

        static void ProcessDirectoryUpdate(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                try
                {
                    Employee emp = employees[i];

                    string uppercaseName = emp.FullName.ToUpper();

                    string formattedRecord = string.Concat("Сотрудник: ", uppercaseName, " [Департамент: ", emp.Department, "]");

                    Console.WriteLine($"[БАЗА ДАННЫХ] Запись успешно создана: {formattedRecord}");
                }
                catch (NullReferenceException ex)
                {
                    string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "directory_errors.log");
                    string line = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Problemo Index: {i}. Error: {ex.Message}";
                    Console.WriteLine($"[ERROR] {line}");
                    File.AppendAllText(logPath, line + Environment.NewLine);
                }
            }
        }
    }
}
*/