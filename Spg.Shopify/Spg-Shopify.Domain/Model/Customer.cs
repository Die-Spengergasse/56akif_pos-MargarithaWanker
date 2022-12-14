using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg_Shopify.Domain.Model
{
    public enum  Genders 
    { 
        Male   = 0, 
        Female = 1, 
        Other  = 2 
    }

    public class Customer : EntityBase
    {
        //public int Id { get; private set; }
        public Genders Gender { get; set; }
        public long CustomerNumber { get; private set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime BirthDate { get; private set; }
        public DateTime RegistrationDateTime { get; private set; }
        public Address? Address { get; set; } = default!;
        public string? PhoneNumber { get; set; }
        //public string PasswordHash { get; set; } = string.Empty;
        private List<ShoppingCart> _shoppingCarts= new();
        public virtual IReadOnlyList<ShoppingCart> ShoppingCarts => _shoppingCarts;
        protected Customer() { }
        public Customer(Genders gender, 
            long customerNumber, 
            string firstName, 
            string lastName, 
            string email, 
            DateTime birthDate, 
            DateTime registrationDateTime)
        {
            Gender = gender;
            CustomerNumber = customerNumber;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDate = birthDate;
            RegistrationDateTime = registrationDateTime;;
        }

     }
}
