using System;  
using System.Collections.Generic;  
using System.Text;  
using System.Data.SqlClient;
  
namespace CommandType  
{  
 
public interface ICar
{
    void GetSpeed();
    void GetMileage();
    public void SendCommand() {
      Console.WriteLine("command sent via interface");
    }
    public class MorrisGarage : ICar
{
    static void Main(string[] args)  
        {  

    public void GetMileage()
    {
        Console.WriteLine("10 KM Per Liter"); 
    }
 
    public void GetSpeed()
    {
        Console.WriteLine("200 KMPH");
    }
 
    public void SendCommand()
    {
        Console.WriteLine("Command Sent via Morris Garage Class");
    }
}
}
}
}