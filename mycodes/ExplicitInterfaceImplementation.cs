using System;  
using System.Collections.Generic;  
using System.Text;  
using System.Data.SqlClient;
  
namespace CommandTypeEnumeration  
{  
    

public interface IControl
{
    void Paint();
}
public interface ISurface
{
    void Paint();
}
public class SampleClass : IControl, ISurface

{
    static void Main(string[] args)  
        {  
    // Both ISurface.Paint and IControl.Paint call this method.
    public void Paint()
    {
        Console.WriteLine("Paint method in SampleClass");
    }
}
}
}