using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp.Data
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string CellPhone { get; set; }
        public string EmailAddress { get; set; }
        public string Image { get; set; }
        public int ContactTypeId { get; set; }
        public bool IsActive { get; set; } 
        public DateTime LastUpdated { get; set; }
        public List<SocialMediaDetails> SocialMediaDetails { get; set; }
        public Demographic Demographics { get; set; }
    }
}
