using System;
using ClassLibrary1;
using ClassLibrary1.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class AnotherStubCaseTest
    {
        [TestMethod]
        public void TestAnotherInterface()
        {
            //var stub = new StubICustomerRepository
            //{
            //    GetAll = () => new[]
            //                      {
            //                        new Customer {Id = 1, Name = "John", Email = "John@contoso.com"},
            //                        new Customer {Id = 2, Name = "Peter", Email = "Peter@contoso.com"}
            //                     }
            //};

            // Arrange
            var savedCustomer = default(Customer); // null
            var repository = new StubICustomerRepository
            {
                SaveOrUpdateCustomer = customer => savedCustomer = customer
            };
            var actualCustomer = new Customer { Id = 1, Name = "Sample Customer" };
            var viewModel = new CustomerViewModel(actualCustomer, repository);

            // Act
            viewModel.Save();

            // Assert
            Assert.IsNotNull(savedCustomer);
            Assert.IsTrue(savedCustomer.Id == 1);
            Assert.IsTrue( savedCustomer.Name == "Sample Customer");
        }
    }
}
