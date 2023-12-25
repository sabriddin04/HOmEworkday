
using Domain.Models;
using Infrastucture.Service;

Service EmployeeServiceS=new Service();

var EmployeeSabr =new Employee();
EmployeeSabr.id=1;
EmployeeSabr.salary=2000;
EmployeeSabr.Firstname="SABriddin";
EmployeeSabr.Lastname="Turaev";
var EmployeeAkmal =new Employee();
EmployeeAkmal.id=2;
EmployeeAkmal.salary=1000;
EmployeeAkmal.Firstname="Akmal";
EmployeeAkmal.Lastname="Nazriev";

EmployeeServiceS.Add(EmployeeSabr);
EmployeeServiceS.Add(EmployeeAkmal);


foreach (var item in EmployeeServiceS.GetEmployees())
{
    System.Console.WriteLine(item.id);
    System.Console.WriteLine(item.Firstname);
    System.Console.WriteLine(item.Lastname);
    System.Console.WriteLine(item.salary);
    System.Console.WriteLine(item.BirthDate);
    System.Console.WriteLine("--------------------------------------------");
}

EmployeeServiceS.Update(1,"Sabrik","Turaev",10000);

foreach (var item in EmployeeServiceS.GetEmployees())
{
    System.Console.WriteLine(item.id);
     System.Console.WriteLine(item.Firstname);
    System.Console.WriteLine(item.Lastname);
    System.Console.WriteLine(item.salary);
    System.Console.WriteLine(item.BirthDate);
     System.Console.WriteLine("--------------------------------------------");
}

EmployeeServiceS.Delete(2);
foreach (var item in EmployeeServiceS.GetEmployees())
{
    System.Console.WriteLine(item.id);
     System.Console.WriteLine(item.Firstname);
    System.Console.WriteLine(item.Lastname);
    System.Console.WriteLine(item.salary);
    System.Console.WriteLine(item.BirthDate);
     System.Console.WriteLine("--------------------------------------------");
}
System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++");

var departsabr=new Department();
var departserv=new DepartmentService();
departsabr.Name="Sabriddinjon";
departsabr.id=1;
departsabr.Description="He is a good programmmist";
var departAkmal=new Department();

departAkmal.Name="Akmaljon";
departAkmal.id=2;
departAkmal.Description="He is a bad programmmist";


departserv.Add(departsabr);
departserv.Add(departAkmal);

foreach (var item in departserv.GetDepartments())
{
    System.Console.WriteLine(item.id);
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Description);
     System.Console.WriteLine("--------------------------------------------");
    
}
departserv.Update(2,"Aka","juraev");
foreach (var item in departserv.GetDepartments())
{
    System.Console.WriteLine(item.id);
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Description);
     System.Console.WriteLine("--------------------------------------------");
    
}
departserv.Delete(1);
foreach (var item in departserv.GetDepartments())
{
    System.Console.WriteLine(item.id);
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Description);
     System.Console.WriteLine("--------------------------------------------");
    
}
departserv.Delete(1);

foreach (var item in departserv.GetDepartments())
{
    System.Console.WriteLine(item.id);
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Description);
     System.Console.WriteLine("--------------------------------------------");
    
}
