using System.Collections.Generic;

namespace DevHomework
{
    class User
    {
        private string firstName;
        private string lastName;
        private List<Purchase> purchases;

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
        }
        public List<Purchase> Purchases
        {
            get
            {
                return purchases;
            }
        }

        public User(string firstName, string lastName)
        {
            // Set basic user data
            this.firstName = firstName;
            this.lastName = lastName;

            // Initiate list for purchase history.
            purchases = new List<Purchase>();
        }

        // Adds purchases to user history
        public void AddPurchase(Purchase purchase)
        {
            purchases.Add(purchase);
        }
    }
}
