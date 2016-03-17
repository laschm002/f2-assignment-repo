using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    
    class Manager : Person
    {
        public int employeeId;
        public string hireDate;
        public int securityLevel;
        public double salary;
        double bonus;
        double stockShares;

        public Manager(string NameFirst, string NameLast, string BirthDate, int Social, int EmployeeId, string HireDate, int SecurityLevel, double Salary, double Bonus, double StockShares)
        {
            nameFirst = NameFirst;
            nameLast = NameLast;
            birthDate = BirthDate;
            social = Social;
            employeeId = EmployeeId;
            hireDate = HireDate;
            securityLevel = SecurityLevel;
            salary = Salary;
            bonus = Bonus;
            stockShares = StockShares;
            






        }
    }
}
