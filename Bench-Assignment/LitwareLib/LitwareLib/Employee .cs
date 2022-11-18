using System;

namespace LitwareLib
{
    public class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;



        public Employee(int empNo,string empName,double salary)
        {
           
                this.EmpNo=empNo;
                this.EmpName=empName;
                this.Salary=salary;
            try
            {
                if (Salary < 5000)
                {
                    this.HRA=Salary*(0.10);
                    this.TA = Salary * (0.05);
                    this.DA = Salary * (0.15);
                }
                else if (Salary < 10000)
                {
                    this.HRA = Salary * (0.15);
                    this.TA = Salary * (0.10);
                    this.DA = Salary * (0.20);
                }
                else if(Salary < 15000)
                {
                    this.HRA = (Salary * (0.20));
                    this.TA = (Salary * (0.15));
                    this.DA = (Salary * (0.25));

                }
                else if (Salary < 20000)
                {
                    this.HRA = Salary * (0.25);
                    this.TA = (Salary * (0.20));
                    this.DA = (Salary * (0.30));
                }
                else if (Salary >= 20000)
                {
                    this.HRA = (Salary * (0.30));
                    this.TA = (Salary * (0.25));
                    this.DA = (Salary * (0.35));
                }
                this.GrossSalary = Salary + HRA + TA + DA;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public void CalculateSalary()
        {
            this.PF = this.GrossSalary*0.10;
            this.TDS = this.GrossSalary * 0.18;
            this.NetSalary = this.GrossSalary - (this.PF + this.TDS);

            Console.WriteLine("Gross Salary is : " + this.GrossSalary);
        }
    }
}
