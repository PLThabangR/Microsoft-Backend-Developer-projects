using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Agent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        //Agent can have a list of properties/listings
        //Agent can have many properties, so we will have a navigation property to the Property class
        public List<Property> PropertyListings { get; set; }
    }
}
