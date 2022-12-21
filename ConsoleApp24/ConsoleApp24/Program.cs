//linq inner join in c#


using System.Net;

namespace ConsoleApp24
{
    class Program
    {
        public static void Main(string[] args)
        {

            var JoinUsingMS = Employee.GetAllEmployees() //Outer Data Source

            .Join(

            Address.GetAllAddresses(),  //Inner Data Source

                           employee => employee.AddressId, //Inner Key Selector

                           address => address.ID, //Outer Key selector

                           (employee, address) => new //Projecting the data into a result set
                           {

                               EmployeeName = employee.Name,

                               AddressLine = address.AddressLine

                           }).ToList();

            foreach (var employee in JoinUsingMS)
            {

                Console.WriteLine("linq inner join in c#");

                Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");

            }

            Console.ReadLine();

            // left outer join using query syntax

            var QSOuterJoin = from emp in Employee.GetAllEmployees()

                              join add in Address.GetAllAddresses()
                              
                              on emp.AddressId equals add.ID
                              
                              into EmployeeAddressGroup
                              
                              from address in EmployeeAddressGroup.DefaultIfEmpty()
                              
                              select new { emp, address };

            foreach (var item in QSOuterJoin)
            
            {
             
                Console.WriteLine("left outer join using query syntax");
                
                Console.WriteLine($"Name : {item.emp.Name}, Address : {item.address?.AddressLine} ");
            
            }
            
            Console.ReadLine();


            //// left outer join using method syntax 
            
            //var MSOuterJOIN = Employee.GetAllEmployees()
            
            //                  .GroupJoin(
            
            //                        Address.GetAllAddresses(),
            
            //                        emp => emp.AddressId,
            
            //                        add => add.ID,
            
            //                        (emp, add) => new { emp, add }
            
            //                  )
            
            //                  .SelectMany(
            
            //                        x => x.add.DefaultIfEmpty(),
            
            //                        (employee, address) => new
            
            //                        {
            
            //                            EmployeeName = employee.emp.Name,
            
            //                            AddressLine = address == null ? "NA" : address.AddressLine
            
            //                        }
            
            //                   );
            
            //foreach (var item in MSOuterJOIN)
            
            //{
            
            //    Console.WriteLine("left outer join using method syntax ");
            
            //    Console.WriteLine($"Name : {item.emp.Name}, Address : {item.address?.AddressLine} ");
            
            //}
            
            //Console.ReadLine();




            List<Orders> orders = new List<Orders>();
            
            orders.Add(new Orders
            
            {
            
                OrderID = 101
              
                ,

                CustomerName = "AAA"
              
                ,
                
                OrderDate = DateTime.Now
              
                ,

                TotalAmount = 10
            
            });
            
            orders.Add(new Orders
            
            {
            
                OrderID = 102
              
                ,
                
                CustomerName = "BBB"
              
                ,
                
                OrderDate = DateTime.Now
              
                ,
                
                TotalAmount = 25
            
            });
            
            orders.Add(new Orders
            
            {
            
                OrderID = 103
              
                ,
                
                CustomerName = "CCC"
              
                ,
                
                OrderDate = DateTime.Now
              
                ,
                
                TotalAmount = 80
            
            });

            
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            
            orderDetails.Add(new OrderDetail
            
            {
            
                DetailID = 1
             
                ,
                
                ProductName = "A 1"
             
                ,
                
                Qty = 2
             
                ,
                
                Price = 5
             ,
                Amount = 10
             ,
                OrderID = 101
            });
            orderDetails.Add(new OrderDetail
            {
                DetailID = 2
              ,
                ProductName = "B 1"
              ,
                Qty = 5
              ,
                Price = 5
              ,
                Amount = 25
              ,
                OrderID = 102
            });
            // Inner Join
            var joinedListInner = (from ord in orders
                                   join detail in orderDetails on ord.OrderID equals detail.OrderID
                                   select new { ord.CustomerName, ord.OrderDate, detail.ProductName, detail.Amount });

            //Left Outer Join
            var joinedListLeftOuter = (from ord in orders
                                       join detail in orderDetails on ord.OrderID equals detail.OrderID into temp
                                       from detail in temp.DefaultIfEmpty()
                                       select new
                                       {
                                           ord.CustomerName
                                         ,
                                           ord.OrderDate
                                         ,
                                           ProductName = detail == null ? String.Empty : detail.ProductName
                                         ,
                                           Amount = detail == null ? null : detail.Amount
                                       });
            Console.WriteLine("left outer join", joinedListLeftOuter);
            Console.WriteLine("innter join", joinedListInner);
        }
    }
}