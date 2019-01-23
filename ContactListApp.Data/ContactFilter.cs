using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp.Data
{
    public class ContactFilter
    {   
        public string City { get; set; }
        public string Country { get; set; }
        public bool IsActive { get; set; }
        public int ContactType { get; set; }
        public List<SocialMediaDetails> SocialMediaDetails { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public GenderEnum Gender { get;set; }
        public string Occupation { get; set; }
    }
}
