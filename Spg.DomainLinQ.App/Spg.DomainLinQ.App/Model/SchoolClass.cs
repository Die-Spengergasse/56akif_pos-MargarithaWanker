using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Name
    /// * Department [Die ersten 3 Zeichen von Name]
    /// * Guid
    /// (4P)
    /// </summary>
    public class SchoolClass : EntityBase
    {
        // TODO: Implementation
        public string Name { get; private set; }
        public string Department => Name.Substring(0, 3);
        //public string Department
        //{
        //    get { return Name.Substring(0, 3); }
        //    set
        //    {
        //        Department = Name.Substring(0, 3);
        //    }
        //}
        public Guid Guid { get; private set; }

        public Subject SubjectNavigation { get; set; } = default!;
        //protected List<Teacher> _teachers = new();
        //public virtual IReadOnlyList<Teacher> KV => _teachers;
        public virtual Teacher KV { get; private set; } = default!;

        protected SchoolClass()
        { }

        public SchoolClass(string name, Teacher teacher, Guid guid)
        {
            Name = name;
            KV = teacher;
            Guid = guid;
        }
    }
}
