using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Requests
{
    public class PropertyRequest
    {
        //We need the agent id to create a new property
        public int AgentId { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        public decimal Price { get; set; }

        //the time we be autoatically created when we create a new property, so we don't need to add it to the request

    }
}
