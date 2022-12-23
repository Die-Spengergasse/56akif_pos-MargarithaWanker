using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * FirstName
    /// * LastName
    /// * EMail
    /// * Address
    /// * Gender
    /// * Guid
    /// (4P)
    /// </summary>
    public class Teacher : EntityBase
    {
        // TODO: Implementation
        public string Firstname { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Address Address { get; set; }
        public Gender Gender { get; set; }
        public Guid Guid { get; set; }

        private List<Subject> _subjects = new();
        public virtual IReadOnlyList<Subject> Subjects { get { return _subjects;} }

        protected Teacher() { }

        public Teacher(string firstName, string lastName, string email, Gender genders, Guid guid, Address address)
        {
            Firstname = firstName;
            LastName = lastName;
            Email = email;
            Gender = genders;
            Guid = guid;
            Address = address;
        }

        public void AddSubject(Subject subject)
        {
            _subjects.Add(subject);
        }
    }
}
