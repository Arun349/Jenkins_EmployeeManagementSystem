using Microsoft.AspNetCore.Http.HttpResults;
using Employee_Management_System;
using Employee_Management_System.Controllers;
using Employee_Management_System.Models;

namespace Employee_Management_System_TestProject
{
    public class Tests
    {
        private EmployeeController controller;
        [SetUp]
        public void Setup()
        {
            controller = new EmployeeController();
        }

        [Test]
        public void TestMethodForGetEmployee()
        {
            IEnumerable<EmployeeModel> result = controller.Getemployees();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(0));
        }
        [Test]
        public void TestMethodForPostEmployee()
        {
            var newItem = new EmployeeModel
            {
                Employee_Id = 1,
                Employee_Name = "test",
                Department = "test",
                Salary = "test"
            };
            var actionResult = controller.Postemployees(newItem);
            Assert.That(actionResult, Is.Not.Null);
        }
        [Test]
        public void TestMethodForPostEmployeeNull()
        {
            var newItem = new EmployeeModel
            {
                Employee_Id = 1,
                Employee_Name = null,
                Department = null,
                Salary = null
            };
            var actionResult = controller.Postemployees(newItem);
            Assert.IsNotInstanceOf<BadRequest>(actionResult);
        }
    }
}