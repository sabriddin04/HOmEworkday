using Domain.Models;
namespace Infrastucture.Service;

public class Service
{
 List<Employee> spiska=new List<Employee>();

  public List<Employee> GetEmployees(){
    return spiska;
  }

  public void Add( Employee employee){
     spiska.Add(employee);
  }

  public string Update(int a,string fisrt,string last,decimal sal){

    foreach (var item in spiska)
    {
        if(a==item.id){
            item.Firstname=fisrt;
            item.Lastname=last;
            item.salary=sal;
            return $"УСПЕШНО ИЗМЕНИНО";


        }
    }
    return $"ТАКОГО ID НЕ СУШЕСТВУЕТ";
  }

  public void Delete(int a){

    
    foreach (var item in spiska)
    {
        if(a==item.id){
            spiska.Remove(item);
     
        }

    }
    }

}
