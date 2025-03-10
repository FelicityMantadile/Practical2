using Practical2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical2.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PeopleList()
        {
            List<Person> people = new List<Person>();
            {
                people.Add(new Models.Person
                {
                    StudentNumber = "23554925",
                    FirstName = "Felicity",
                    LastName = "Mantadile",
                    EmailAddress = "u23554925@tuks.co.za",
                    myLink = "~/HTML/Person1.html",

                });
                people.Add(new Models.Person()
                {
                    StudentNumber = "19087765",
                    FirstName = "Obuang",
                    LastName = "Mphahlele",
                    EmailAddress = "u19087765@tuks.co.za",
                    myLink = "~/HTML/Person2.html",

                });
                people.Add(new Models.Person()
                {
                    StudentNumber = "20335544",
                    FirstName = "Kgosi",
                    LastName = "Gumede",
                    EmailAddress = "u20335544@tuks.co.za",
                    myLink = "~/HTML/Person3.html",

                });
                people.Add(new Models.Person()
                {
                    StudentNumber = "18546731",
                    FirstName = "Liam",
                    LastName = "Maison",
                    EmailAddress = "u1854731@tuks.co.za",
                    myLink = "~/HTML/Person4.html",

                });
                people.Add(new Models.Person()
                {
                    StudentNumber = "21567890",
                    FirstName = "Olivia",
                    LastName = "Smith",
                    EmailAddress = "u21567890@tuks.co.za",
                    myLink = "~/HTML/Person5.html",

                });

            };
            return View(people);
        }
    }
}