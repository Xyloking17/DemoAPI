using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    /// <summary>
    ///  This is a comment
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();


        public PeopleController()
        {
            people.Add(new Person { FirstName = "Mason", Id = 1, LastName = "Sickler" });
            people.Add(new Person { FirstName = "Mgfn", Id = 2, LastName = "Siasdfer" });
            people.Add(new Person { FirstName = "Msdfehn", Id = 3, LastName = "Sicdfajer" });
        }

        /// <summary>
        /// Gets a list of the first names of all users.
        /// </summary>
        /// <param name="userId"> unique identifier</param>
        /// <param name="age"> we want to know how old they are</param>
        /// <returns>a list of first names</returns>
        [Route("api/People/FirstNames/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstNames(int userId, int age)
        {
            List<string> output = new List<string>();

            foreach (var n in people)
            {
                output.Add(n.FirstName);
            }
            return output;
        }


        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
         
            people.Add(val);
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
