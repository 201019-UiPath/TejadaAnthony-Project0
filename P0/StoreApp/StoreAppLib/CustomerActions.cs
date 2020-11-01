using StoreAppDB.Models;
using StoreAppDB.Interfaces;
using StoreAppDB;
namespace StoreAppLib
{
    public class CustomerActions
    {
        private StoreAppContext context;
        private ICustomerRepoActions repoActions;

        public CustomerActions(StoreAppContext context, ICustomerRepoActions repo)
        {
            this.repoActions = repo;
            this.context = context;

        }

        public bool CustomerExists(string email, string password) {

             return repoActions.CheckIfCustomerExists(email, password);

        }

        public void AddCustomer(Customer newCustomer) {

            repoActions.AddCustomerIntoTable(newCustomer);
        }


    }
}