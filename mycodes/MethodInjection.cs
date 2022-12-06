using System;  
using System.Collections.Generic;  
using System.Text;  
using System.Data.SqlClient;
  
namespace Command  
{  
    
        




class ClassA    
{    
    
    private IService _service;  
    public void PrintMethod(IService service)  
    {  
       _service = service;  
        this._service.Print();  
    }  
}    
     
class Program    
{    
   static void Main(string[] args)    
   {    
      Service1 s1 = new Service1();    
      ClassA c1 = new ClassA();    
      //passing dependency    
      c1.PrintMethod(s1);    
      Service2 s2 = new Service2();    
      //passing dependency    
      c1.PrintMethod(s2);    
      Console.ReadLine();    
   }    
}    

        
    
}