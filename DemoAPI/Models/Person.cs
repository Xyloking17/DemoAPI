using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    /// <summary>
    /// represents one specific person
    /// </summary>
    public class Person
    {
       /// <summary>
       /// id from sequel
       /// </summary>
        public int Id { get; set; } = 0;

        /// <summary>
        /// firstname
        /// </summary>
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

    }
}