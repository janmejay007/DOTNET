using HRLib;
using Taxation;
Console.WriteLine("Hello, World!");





Employee[] e=new Employee[3];
e[0]=new SalesEmployee(1, "a1", "b1", "a1@gmail.com", 12000, 1200, 1212, 1234);
e[1] = new Manager(2, "a2", "b2", "a2@gmail.com", 12300, 1200, 1200, 1200, 1323);
e[2] = new HRManager(3, "janmejay", "singh", "janmejay@gmail.com", 12000, 1200, 1212, 1234);

List<Employee> list = new List<Employee>();
list.Add(new SalesEmployee(1, "a1", "b1", "a1@gmail.com", 12000, 1200, 1212, 1234));

Console.WriteLine(e[0]);
Console.WriteLine(e[1]);
Console.WriteLine(e[2]);

TaxManager taxManager = new TaxManager();
Console.WriteLine(taxManager.PayIncomeTax(e[0].ComputeSalary()));
TaxOperation operation1 = new TaxOperation(taxManager.PayIncomeTax);

Console.WriteLine( operation1(e[0].ComputeSalary()));


bool flag = false;
int input=0;
do
{
    Console.WriteLine("Enter Choice");
    Console.WriteLine("1.Add Employee 2.Display 3.NetSalary");
    input = int.Parse(Console.ReadLine());
    switch (input)
    {
        case 1:
            Console.WriteLine("id fname lname email salary da ta hra");
            //  (int id, string fname, string lname, string email, double salary, double da, double ta, double hra
            Employee e1 = new HRManager(
                      int.Parse(Console.ReadLine()),
                      Console.ReadLine(),
                      Console.ReadLine(),
                      Console.ReadLine(),
                      double.Parse(Console.ReadLine()),
                      double.Parse(Console.ReadLine()),
                      double.Parse(Console.ReadLine()),
                      double.Parse(Console.ReadLine())
                  );
            list.Add(e1);

            break;
        case 2:
            Console.WriteLine("All Employee are ");
            foreach (var v in list)
            {
                Console.WriteLine(v);
            }
            break;
        case 3:
            Console.WriteLine("Show Net Salary");
            foreach (var v in list)
            {
                operation1(v.ComputeSalary());
            }
            break;
        case 4:
            Console.WriteLine("done");
            flag = true;
            break;
    }
} while (!flag);
   
