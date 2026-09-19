using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Response
{
    public class AgentResponse
    {   
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        //We are adding a list of properties to our response model, so we can return the properties that belong to the agent when we return the agent information
        List<PropertySummaryResponse> PropertySummaries { get; set; }
    }
}
