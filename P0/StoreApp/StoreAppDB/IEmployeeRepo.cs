using StoreAppLib.Models;

namespace StoreAppDB
{
    public interface IEmployeeRepo
    {
         void AddEmployeeAsync(Employees employee);
    }
}