using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhonebookProject.Controllers
{
    public class AddController : Controller
    {
        // GET: Add
        public ActionResult Index()
        {
            return View();
            public List<Contact> getAllContacts()
            {
                return contacts;
            }



            public List<Contact> searchBasedOnEmail(String emailIdText)
            {
                List<Contact> searched = new ArrayList<Contact>();

                for (int i = 0; i < contacts.size(); i++)
                {
                    if (contacts.get(i).getEmail().contains(emailIdText))
                    {
                        searched.add(contacts.get(i));
                    }
                }
                return searched;
            }



            public List<Contact> searchBasedOnName(String nameText)
            {
                List<Contact> searched = new ArrayList<Contact>();

                for (int i = 0; i < contacts.size(); i++)
                {
                    if (contacts.get(i).getName().contains(nameText))
                    {
                        searched.add(contacts.get(i));
                    }
                }
                return searched;
            }


            public List<Contact> searchBasedOnContact(String contacText)
            {
                List<Contact> searched = new ArrayList<Contact>();

                for (int i = 0; i < contacts.size(); i++)
                {
                    if (contacts.get(i).getContactNumber().contains(contacText))
                    {
                        searched.add(contacts.get(i));
                    }
                }
                return searched;





            }
        }
}