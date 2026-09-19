using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Requests
{
    internal class UpdatePropertyRequest
    {
        public int Id { get; set; }
        //We need the agent id to know who is making the update, so we can check if the agent is authorized to update the property
        public int AgentId { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        public decimal Price { get; set; }


    }
}
