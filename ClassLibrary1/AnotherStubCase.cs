using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public interface ICustomerRepository
    {
        Customer GetById(int id);
        IEnumerable<Customer> GetAll();
        Customer SaveOrUpdate(Customer customer);
        void Delete(Customer customer);
    }
    public class CustomerViewModel
    {
        private Customer customer;
        private readonly ICustomerRepository repository;

        public CustomerViewModel(Customer customer, ICustomerRepository repository)
        {
            this.customer = customer;
            this.repository = repository;
        }

        public string Name
        {
            get { return customer.Name; }
            set
            {
                customer.Name = value;                
            }
        }

        public void Save()
        {
            customer = repository.SaveOrUpdate(customer);
        }
    }
}
