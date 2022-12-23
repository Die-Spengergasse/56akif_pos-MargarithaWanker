using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Date (?)
    /// * Lesson (int?)
    /// * Created
    /// * Guid
    /// * Grade (Note 1-5)
    /// (4P)
    /// </summary>
    public class Exam : EntityBase
    {
        // TODO: Implementation
        public DateTime? Date { get; private set; }
        public int? Lesson { get; set; }
        private DateTime Created { get; set; }
        public Guid Guid { get; set; }
        public int Grade
        {
            get { return _grade; }
            set 
            { 
                if(value > 0 && value < 6)
                {
                    Grade = value;
                }
            }
        }
        private int _grade;

        public Subject SubjectNavigation { get; set; } = default!;

        public Exam(Guid guid, DateTime? date, int? lesson, int grade, Subject subject, DateTime created)
        {
            Guid = guid;
            Date = date;
            Lesson = lesson;
            Grade = grade;
            SubjectNavigation = subject;
            Created = created;
            
        }

    }
}
