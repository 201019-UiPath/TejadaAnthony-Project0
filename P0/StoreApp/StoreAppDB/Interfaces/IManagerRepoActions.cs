using StoreAppDB.Models;

namespace StoreAppDB.Interfaces
{
    public interface IManagerRepoActions
    {
        void AddEmployeeAsync(Manager manager);
    }
}