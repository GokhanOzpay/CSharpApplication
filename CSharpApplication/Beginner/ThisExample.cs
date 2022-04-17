using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class ThisExample
{
    public ThisExample()
    {
        Employee e1 = new Employee(101, "Sonoo", 890000f);
        e1.display();
    }


}
public class Employee
{
    public int id;
    public String name;
    public float salary;
    public Employee(int id, String name, float salary)
    {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " + salary);
    }
}
