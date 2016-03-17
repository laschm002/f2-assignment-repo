using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class Teller : Person
    {
        public int employeeId;
        public int securityLevel;
        double wage;

        public Teller(string NameFirst, string NameLast, string BirthDate, int Social, int EmployeeId, string HireDate, int SecurityLevel, double Wage)
        {
            nameFirst = NameFirst;
            nameLast = NameLast;
            birthDate = BirthDate;
            social = Social;
            employeeId = EmployeeId;
            securityLevel = SecurityLevel;
            wage = Wage;
        }

    }
    }

       

    

