using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Property
    {
        public int Id { get; set; }

        //this is our foreign key to the Agent table
        public int AgentId { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        public decimal Price { get; set; }

        public DateTime ListingDate { get; set; }

        //A propperty belog to a specific agent, so we will have a navigation property to the Agent class
        public Agent Agent { get; set; }
    }
}
