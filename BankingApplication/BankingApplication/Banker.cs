using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class Banker : Person
    {
        public int employeeId;
        public string hireDate;
        public int securityLevel;
        public double salary;

        public Banker(string NameFirst, string NameLast, string BirthDate, int Social, int EmployeeId, string HireDate, int SecurityLevel, double Salary)
        {
            nameFirst = NameFirst;
            nameLast = NameLast;
            birthDate = BirthDate;
            social = Social;
            hireDate = HireDate;
            employeeId = EmployeeId;
            securityLevel = SecurityLevel;
            salary = Salary;
        }
    }
}
