using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * RegistrationNumber
    /// * FirstName
    /// * LastName
    /// * EMail
    /// * Address
    /// * PhoneNumber
    /// * AccountName = [Die ersten 5 Stellen des LastName + RegistrationNumber]
    /// * Gender
    /// * Guid
    /// (4P)s
    /// </summary>
    public class Student : EntityBase
    {
        // TODO: Implementation
        public int RegistrationsNumber { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Address Address { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public string AccountName => LastName.Substring(0, 5) + RegistrationsNumber;
        public Gender Gender { get; set; }
        public Guid Guid { get; set; }

        private List<Subject> _subjects = new();
        public virtual IReadOnlyList<Subject> Subjects { get { return _subjects; } }
        public SchoolClass SchoolClassNavigation { get; set; } = default!;

        protected Student() { }
        public Student(int registrationsNumber, Guid guid, string firstName, string lastName, string email, Gender gender, SchoolClass schoolClass, Address address, PhoneNumber phoneNumber)
        {
            RegistrationsNumber = registrationsNumber;
            Guid = guid;
            Firstname = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;
            SchoolClassNavigation = schoolClass;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public void AddSubjects(List<Subject> subjects)
        {
            _subjects.AddRange(subjects);
        }
    }
}
