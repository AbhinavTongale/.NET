/*

Create a Class Employee with the following specifications

Properties
----------
string Name -> no blank names should be allowed
int EmpNo ->  must be readonly and autogenerated
decimal Basic -> must be between some range
short DeptNo -> must be > 0

Methods
-------
decimal GetNetSalary() -> returns calculated net salary (Use any formula to get net salary based on Basic salary)


Create constructors to accept initial values for Employee obj
Employee o1 = new Employee("Amol",123465, 10);
Employee o2 = new Employee("Amol",123465);
Employee o3 = new Employee("Amol");
Employee o4 = new Employee();

EmpNo must be autogenerated ... i.e.
first object should automatically get EmpNo 1
second object should automatically get EmpNo 2
third object should automatically get EmpNo 3
...and so on...

Test Cases
Employee o1 = new Employee()
Employee o2 = new Employee()
Employee o3 = new Employee()
cw(o1.EmpNo)
cw(o2.EmpNo)
cw(o3.EmpNo)

cw(o3.EmpNo)
cw(o2.EmpNo)
cw(o1.EmpNo)
*/




using System.Xml.Linq;


namespace Assignment2
{
    
    internal class Employee
    {
        private static int nextEmpNo = 1;

        
using System.Xml.Linq;

public Employee(string name = "null", int basic = 0, int deptNO = 0)
{
    this.empNo = nextEmpNo;
    nextEmpNo++;
    this.Name = name;
    this.Basic = basic;
    this.DeptNo = (short)deptNO;

    Console.WriteLine(empNo + " " + name + " " + basic + " " + deptNo);
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
    Console.WriteLine("--------------------");
    Employee obj = new Employee();
    obj.name = "Test";
    obj.DeptNo = 1;
    obj.Basic = 3;
    Console.WriteLine("--------------------");
    Console.WriteLine(obj.Name);
    Console.WriteLine(obj.empNo);
    Console.WriteLine(obj.Basic);
    Console.WriteLine(obj.DeptNo);
    Console.WriteLine("--------------------");
    decimal result = Employee.GetNetSalary();
    Console.WriteLine("netsalary is = " + result);
    Console.WriteLine("--------------------");
    Employee o1 = new Employee("Abhi", 123465, 10);
    Employee o2 = new Employee("Abhi", 123465);
    Employee o3 = new Employee("Abhi");
    Employee o4 = new Employee();
    Employee o5 = new Employee();
    Console.WriteLine("--------------------");

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
