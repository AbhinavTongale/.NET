
/*
using Assingment1;

Create a Class Employee with the following specifications


Properties
----------
string Name -> no blank names should be allowed
int EmpNo -> must be greater than 0
decimal Basic -> must be between some range
short DeptNo -> must be > 0

Methods
-------
decimal GetNetSalary() -> returns calculated net salary (Use any formula to get net salary based on Basic salary)


Create constructors to accept initial values for Employee obj
eg
Employee o1 = new Employee(1, "Amol", 123465, 10);
Employee o2 = new Employee(1, "Amol", 123465);
Employee o3 = new Employee(1, "Amol");
Employee o4 = new Employee(1);
Employee o5 = new Employee();    */


using System.Xml.Linq;


namespace Assingment1
{
    internal class Employee
    {

       
        public Employee(int Ids = 0, string name = "null", int basic = 0, int deptNO = 0)
        {
            this.EmpNo = empNo;
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = (short)deptNO;

            Console.WriteLine(Ids + " " + name + " " + basic + " " + deptNo);
            Console.WriteLine(name);
            Console.WriteLine(basic);
            Console.WriteLine(deptNO);
        }



        private string name;
        public string Name
        {
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("no blank name is allowed");
                }
            }
            get
            {
                return name;
            }


        }

        private int empNo;
        public int EmpNo
        {
            set
            {
                if (value > 0)
                {
                    empNo = value;
                }
            }
            get
            {
                return empNo;
            }

        }

        private decimal basic;
        public decimal Basic
        {
            set
            {
                if (value > 0 && value < 100)
                {
                    basic = value;
                }
            }
            get
            {
                return basic;
            }

        }

        private short deptNo;
        public short DeptNo
        {
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
            }
            get
            {
                return deptNo;
            }


        }





        static void Main(string[] args)
        {
            Console.WriteLine("==================================================================================");
            Employee obj = new Employee();
            obj.name = "Test";
            obj.DeptNo = 1;
            obj.EmpNo = 2;
            obj.Basic = 3;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.EmpNo);
            Console.WriteLine(obj.Basic);
            Console.WriteLine(obj.DeptNo);
            Console.WriteLine("---------------------------------------------------------");
            decimal result = Employee.GetNetSalary();
            Console.WriteLine("netsalary is = " + result);
            Console.WriteLine("---------------------------------------------------------");
            Employee o1 = new Employee(1, "Abhi", 123465, 10);
            Employee o2 = new Employee(1, "Abhi", 123465);
            Employee o3 = new Employee(1, "Abhi");
            Employee o4 = new Employee(1);
            Employee o5 = new Employee();
            Console.WriteLine("---------------------------------------------------------");

        }

        public static Decimal GetNetSalary()
        {
            decimal Basicsalary = 10000;
            decimal DA = (Basicsalary) * (12 / 100);
            decimal TA = 3000;
            decimal HRA = 6000;
            decimal tax = Basicsalary * (15 / 100);

            decimal NetSalary = Basicsalary + HRA + TA + DA - tax;

            return NetSalary;

        }

    }
}

