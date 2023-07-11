namespace Parent;
public class Employee{

private string firstName;
private string lastName;

public Employee(){
Console.WriteLine("inside constructor");
}

public void ComputeSalary(){
    Console.WriteLine("inside parent");
}

public Employee(string fname,string lname){
    this.firstName=fname;
    this.lastName=lname;
}

public string FirstName{
    get{return this.firstName;}
    set{this.firstName=value;}

}

public override string ToString(){
    return this.firstName+" "+this.lastName;
}



}