using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01
{
    public class SmartPhoneApp : List<Post>
    {
        public string SmartPhoneId { get; set; } = string.Empty;

        public new void Add(Post p)
        {
            if(p is not null)
            {
                base.Add(p);
                p.SmartPhone = this;
            }
        }

        public SmartPhoneApp(string smartPhoneId)
        {
            SmartPhoneId = smartPhoneId;
        }

        public string ProcessPosts()
        {
            string stringbuilder = string.Empty;
            foreach (Post p in this)
            {
                stringbuilder += p.Html;
            }
            return stringbuilder;
        }

        public int CalcRating()
        {
            int rating = 0;
            foreach (Post p in this)
            {
                rating += p.Rating;
                
            }
            return rating;
        }

        public Post? this[string title]
        {
            get
            {
                foreach (Post p in this)
                {
                    if(p.Title == title)
                    {
                        return p;
                    }
                }
                return null;
                
            }
        }
    }
}
