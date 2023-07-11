using Parent;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Employee e1=new Employee();

Manager m1=new Manager("surya","pratap",12000,1200,1100,340);

e1.ComputeSalary();
Console.WriteLine("Employee Calculating Salary"+m1.ComputeSalary());

Console.WriteLine(e1);
Console.WriteLine(m1);
