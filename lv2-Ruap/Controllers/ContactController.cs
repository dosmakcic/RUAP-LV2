using lv2_Ruap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lv2_Ruap.Services;

namespace lv2_Ruap.Controllers
{
    public class ContactController : Controller
    {

        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        } 
   
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
            {
        
     };

        }
    }
}