using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanRolleriveMaasHesaplama
{
    enum EmployeeRole
    {
        Manager,
        Developer,
        Designer,
        Tester
    }

    class SalaryCalculator
    {
        public static double GetSalary(EmployeeRole role)
        {
            switch (role)
            {
                case EmployeeRole.Manager:
                    return 10000; // TL olarak maaş
                case EmployeeRole.Developer:
                    return 8000;
                case EmployeeRole.Designer:
                    return 7000;
                case EmployeeRole.Tester:
                    return 6000;
                default:
                    throw new ArgumentOutOfRangeException(nameof(role), "Geçersiz çalışan rolü.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRole employee = EmployeeRole.Developer;
            Console.WriteLine($"Çalışan rolü: {employee}");
            Console.WriteLine($"Maaş: {SalaryCalculator.GetSalary(employee):C}");
            Console.ReadKey();
        }
    }
}
