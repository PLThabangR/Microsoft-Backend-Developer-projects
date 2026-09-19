using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Requests
{
    public class UpdateAgentRequest
    {   //We need to add the properties that we want to update for the agent. For example, we can add FirstName, LastName, PhoneNumber, and Email.
        //We nee dto know the primary key of the agent that we want to update. We can add an Id property to the UpdateAgentRequest class.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
