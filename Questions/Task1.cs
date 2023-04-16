using System;
		
public class Employee
{
	private string firstName; //field
	public string FirstName{ //property
		get{return firstName;}
		set{firstName = value;}
	}
	
	private string lastName;
	public string LastName{
		get{return lastName;}
		set{lastName = value;}
	}
	
	private double salary;
	public double Salary{
		get{return salary;}
		set{salary = value;}
	}
	
	public Employee(string fname, string lname, double salaryAmt){
		firstName = fname;
		lastName = lname;
		salary = salaryAmt;
	}
	
	public void ShowFullName(){
		Console.WriteLine("Name: "+firstName+" "+lastName);
	}
	
	public void incrementSalary(double s){
		salary = salary + s;
	}
	
	public static void Main()
	{
		
		Employee emp = new Employee("Ram","Bahadur",20000);
		emp.ShowFullName();
		Console.WriteLine("Salary: "+emp.Salary);
		emp.firstName = "Hari";
		emp.incrementSalary(5000);
		emp.ShowFullName();
		Console.WriteLine("Salary: "+emp.Salary);
		
	}
}