namespace Domain.Customers;

public interface ICustomerRepository
{
    Task<Customer?> GetByIdAsync(CustomerId customerId);
    Task Add(Customer customer);
}