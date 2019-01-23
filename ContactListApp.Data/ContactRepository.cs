using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp.Data
{
    public class ContactRepository
    {
        public string _connection { get; set; }
        public ContactRepository(string connection)
        {
            _connection = connection;
        }

        public IEnumerable<Contact> GetAllContacts()
        {
           
        }

        public Contact GetContactById(int contactId)
        {

        }

        public IEnumerable<Contact> Search(string searchTerm)
        {

        }

        public IEnumerable<Contact> FilterByCriteria(ContactFilter filter)
        {

        }

        public Contact AddContact(Contact c)
        {
            //add basic info then call next two methods, passing in the newly added contactid, c.SocialMediaDetails and c.Demographics
        }

        public bool AddSocialInfo( int contactId, List<SocialMediaDetails> socialMediaDetails)
        {

        }

        public bool AddDemographicInfo(int contactId, Demographic d)
        {

        }

        public Contact EditContact (Contact c)
        {

        }

        public bool DeleteContact (int contactId)
        {

        }
    }
}
