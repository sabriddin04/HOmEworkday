using Domain.Models;

namespace Infrastucture.Service;

public class DepartmentService
{
  
 List<Department> spiska=new List<Department>();

  public List<Department> GetDepartments(){
    return spiska;
  }

  public void Add( Department department){
     spiska.Add(department);
  }

  public string Update(int a,string fisrt,string last){

    foreach (var item in spiska)
    {
        if(a==item.id){
            item.Name=fisrt;
            item.Description=last;
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
