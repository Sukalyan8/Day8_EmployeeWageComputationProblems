using System;

namespace EmployeeWageComputationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(" Welcome to Employee Wage Computation Program on Main Branch");
            Console.WriteLine("_____________________________________________________________\n");

            //UC1_CheckEmployee uc1 = new UC1_CheckEmployee();
            //uc1.GetAttendance();

            //EmployeeWageComputationProblem.UC2_DailyEmployeeWage uc2 = new UC2_DailyEmployeeWage();
            //uc2.EmpDailyWage();

            //EmployeeWageComputationProblem.UC3_PartTimeEmployeeWage uc3 = new UC3_PartTimeEmployeeWage();
            //uc3.PartTimeEmpWage();

            //EmployeeWageComputationProblem.UC4_UsingSwitchCase uc4 = new UC4_UsingSwitchCase();
            //uc4.EmpWageUsingSwitch();

            //EmployeeWageComputationProblem.UC5_MonthlyWages uc5 = new UC5_MonthlyWages();
            //uc5.CalculateWages();

            //EmployeeWageComputationProblem.UC6_TotalWorkingHours uc6 = new UC6_TotalWorkingHours();
            //uc6.CalculateWageTill100HrsOr20IsReached();

            //UC7_RefactorTheCodeUsingClassMethod.ComputeEmpWage();

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the program number which is to be executed \n 1.UC-1, \n 2.UC-2, \n 3.UC-3, \n 4.UC-4, \n 5.UC-5, \n 6.UC-6, \n 7.UC-7, \n 8.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UC1_CheckEmployee uc1 = new UC1_CheckEmployee();
                        uc1.GetAttendance();
                        break;
                    case 2:
                        EmployeeWageComputationProblem.UC2_DailyEmployeeWage uc2 = new UC2_DailyEmployeeWage();
                        uc2.EmpDailyWage();
                        break;
                    case 3:
                        EmployeeWageComputationProblem.UC3_PartTimeEmployeeWage uc3 = new UC3_PartTimeEmployeeWage();
                        uc3.PartTimeEmpWage();
                        break;
                    case 4:
                        EmployeeWageComputationProblem.UC4_UsingSwitchCase uc4 = new UC4_UsingSwitchCase();
                        uc4.EmpWageUsingSwitch();
                        break;
                    case 5:
                        EmployeeWageComputationProblem.UC5_MonthlyWages uc5 = new UC5_MonthlyWages();
                        uc5.CalculateWages();
                        break;
                    case 6:
                        EmployeeWageComputationProblem.UC6_TotalWorkingHours uc6 = new UC6_TotalWorkingHours();
                        uc6.CalculateWageTill100HrsOr20IsReached();
                        break;
                    case 7:
                        UC7_RefactorTheCodeUsingClassMethod.ComputeEmpWage();
                        break;
                    case 8:
                        flag = false;
                        break;
                }
            }
        }
    }
}
