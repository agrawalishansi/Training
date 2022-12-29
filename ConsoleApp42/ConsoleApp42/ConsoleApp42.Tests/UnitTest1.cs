using ConsoleApp42.HR;
using System;
using Xunit;

namespace ConsoleApp42.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void PerformWork_Adds_NumberOfHours()
        {
            //Arrange
            Employee employee = new Employee("Ishansi", "Agrawal", "ishansi@snowball.be", new DateTime(1979, 1, 16), 25);

            int numberOfHours = 3;
            //Act
            employee.PerformWork(numberOfHours);

            //Assert
            Assert.Equal(numberOfHours, employee.NumberOfHoursWorked);
        }

        [Fact]
        public void PerformWork_Adds_DefaultNumberOfHours_IfNoValueSpecified()
        {
            Employee employee = new Employee("Ishansi", "Agrawal", "ishansi@snowball.be", new DateTime(1979, 1, 16), 25);

            employee.PerformWork();

            Assert.Equal(1, employee.NumberOfHoursWorked);
        }
    }
}