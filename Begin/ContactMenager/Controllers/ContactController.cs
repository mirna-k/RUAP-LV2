using ContactMenager.Models;
using Microsoft.AspNetCore.Mvc;
using ContactMenager.Services;
using System.Web.Http;

namespace ContactMenager.Controllers
{
    public class ContactController : ApiController
    {
        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }

        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }
    }
}
