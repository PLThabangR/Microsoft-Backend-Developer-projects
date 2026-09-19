using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Response
{
    public class PropertyResponse
    {
        public int Id { get; set; }
        public int AgentId { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }

        //Lets create a navigation property to the AgentResponse class, so we can return the agent information when we return the property information
        public AgentResponse Agent { get; set; }



    }
}
