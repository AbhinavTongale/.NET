﻿
/* 

                Assingment - 3  
  Create the following classes
Employee
   Prop	
	string Name -> no blanks
	int EmpNo -> readonly, autogenerated
	short DeptNo -> > 0
	abstract decimal Basic 
   Methods
	abstract decimal CalcNetSalary()


Manager : Employee
   Prop
	string Designation -> cant be blank
	

GeneralManager : Manager
   Prop
 	string Perks -> no validations

CEO : Employee
      Make CalNetSalary() a sealed method

NOTE : Overloaded constructors in all classes calling their base class constructor 
All classes must implement IDbFunctions interface
All classes to override the abstract members defined in the base class(Employee). Basic property to have different validation in different classes.


*/






namespace Assignment3
{
    internal abstract class Program
    {
        public decimal basic;
        public static void Main()
        {
            Main1();
            Main2();
            Main3();
        }

        public static void Main1()
        {
            CEO Objceo = new CEO();
            decimal totalsalary = Objceo.CalcNetSalary(100000);
            Console.WriteLine("Ceo salary is= " + totalsalary);

        }
        public static void Main2()
        {
            GeneralManager Objceo = new GeneralManager();
            decimal totalsalary = Objceo.CalcNetSalary(80000);
            Console.WriteLine("GeneralManager salary is= " + totalsalary);
        }
        public static void Main3()
        {
            Manager Objceo = new Manager();
            decimal totalsalary = Objceo.CalcNetSalary(50000);
            Console.WriteLine("Manager salary is= " + totalsalary);
        }
        public abstract class Employee
        {
            private string name;
            public string Name
            {
                set
                {
                    if (value != null)
                        name = value;
                }
                get
                {
                    return name;
                }
            }
            private int empNo;
            public int EmpNo
            {
                get
                {
                    return empNo;
                }
            }
            private short deptNo;
            public short DeptNo
            {
                set
                {
                    if (value > 0)
                        deptNo = value;
                }
                get
                {
                    return deptNo;
                }
            }
            public abstract decimal CalcNetSalary(decimal basic);
        }
        public class Manager : Employee
        {
            private string designation;
            public string Designation
            {
                set
                {
                    if (value != null)
                        designation = value;
                }
                get
                {
                    return designation;
                }
            }
            public override decimal CalcNetSalary(decimal Basic)
            {
                decimal basic = Basic;
                decimal DA = (basic) * (12 / 100);
                decimal TA = 3000;
                decimal HRA = 6000;
                decimal tax = basic * (15 / 100);
                decimal NetSalary = basic + HRA + TA + DA - tax;
                return NetSalary;
            }
        }
        public class GeneralManager : Employee
        {
            private string perks;
            public string Perks
            {
                set
                {
                    perks = value;
                }
                get
                {
                    return perks;
                }
            }
            public override decimal CalcNetSalary(decimal Basic)
            {
                decimal basic = Basic;
                decimal DA = (basic) * (12 / 100);
                decimal TA = 3000;
                decimal HRA = 6000;
                decimal tax = basic * (30 / 100);
                decimal NetSalary = basic + HRA + TA + DA - tax;
                return NetSalary;
            }
        }
        public class CEO : Employee
        {
            public sealed override decimal CalcNetSalary(decimal Basic)
            {
                decimal basic = Basic;
                decimal DA = (basic) * (12 / 100);
                decimal TA = 3000;
                decimal HRA = 6000;
                decimal tax = basic * (15 / 100);
                decimal NetSalary = basic + HRA + TA + DA - tax;
                return NetSalary;
            }
        }

    }
}
