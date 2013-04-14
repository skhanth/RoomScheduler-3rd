using System;

//namespace Customers
namespace jin3
{
    public class Customer
    {
        public string FirstName;
        public string LastName;
        public int ID;
        public decimal CreditLimit;

        public Customer(string first, string last, int ID, decimal limit)
        {
            // Class constructor
            this.FirstName = first;
            this.LastName = last;
            this.ID = ID;
            this.CreditLimit = limit;
        }

        public override string ToString()
        {
            return LastName + ", " + FirstName;
            //return FirstName + ", " + LastName;
        }

        public override bool Equals(object obj)
        {
            Customer other;

            if ((obj == null) || (!(obj is Customer)))
                return false;

            other = (Customer)obj;
            return this.ID == other.ID;
        }

        public override int GetHashCode()
        {
            return this.ID.GetHashCode();
        }
    }
}
