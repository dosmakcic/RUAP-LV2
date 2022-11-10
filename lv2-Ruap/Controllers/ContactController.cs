using lv2_Ruap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using lv2_Ruap.Services;
using System.Net.Http;

namespace lv2_Ruap.Controllers
{
    public class ContactController : ApiController
    {

        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        } 
   
        // GET: Contact
       

        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
            {
        
     };

        }
        public HttpResponseMessage Post(Contact contact)
        {
            this.contactRepository.SaveContact(contact);

            var response = Request.CreateResponse<Contact>(System.Net.HttpStatusCode.Created, contact);

            return response;
        }
    }
}