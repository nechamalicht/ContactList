using ContactListApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactListApp.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public ActionResult GetAllContacts()
        {
            //returns all contacts for full list view
        }

        [HttpGet]
        public ActionResult GetContactById(int contactId)
        {
            //return all details for specific contact view
        }

        [HttpGet]
        public ActionResult Search(string searchTerm)
        {
            //return specific contacts/contacts by search term
        }

        [HttpGet]
        public  ActionResult FilterByCriteria(ContactFilter filter)
        {
            //filter by specific criteria such as city, state, occupation
        }

        [HttpPost]
        public ActionResult AddContact(Contact c)
        {
             //add contact with basic info, demographics and social media
        }

        [HttpPost]
        public ActionResult EditContact(Contact c)
        {
            //edit contact details
        }

        [HttpPost]
        public ActionResult DeleteContact(int contactID)
        {
            //delete specified contact
        }
    }
}