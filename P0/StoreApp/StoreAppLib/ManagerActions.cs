using StoreAppDB.Models;
using StoreAppDB.Interfaces;
using StoreAppDB;

namespace StoreAppLib
{
    public class ManagerActions
    {
        private StoreAppContext context;
        private IManagerRepoActions repoActions;

        public ManagerActions(StoreAppContext context, IManagerRepoActions repo)
        {
            this.repoActions = repo;
            this.context = context;

        }

        public void AddBaseballBat(BaseballBat newBaseballBat) {

            repoActions.AddBaseballBatIntoTableAsync(newBaseballBat);
        }

        public bool ManagerExists(string email, string password) {

             return repoActions.CheckIfManagerExists(email, password);

        }
    }
}