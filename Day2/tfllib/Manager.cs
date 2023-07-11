
namespace Parent;

public class Manager:Employee{
    private double salary;
    private int da;
    private int ta;
    private int fa;

    public Manager(string fname,string lname,double salary,int da,int ta,int fa):base(fname,lname){
       
        this.salary=salary;
        this.da=da;
        this.fa=fa;
        this.ta=ta;
    }
 double totalsal;

    public double ComputeSalary(){
       totalsal=salary+da+ta+fa;
        return totalsal;
    }

    public override string ToString(){
        return base.ToString()+""+this.totalsal;
    }

}