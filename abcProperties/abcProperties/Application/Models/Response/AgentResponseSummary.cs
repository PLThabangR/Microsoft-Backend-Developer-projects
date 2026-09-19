using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Response
{
    public class AgentResponseSummary
    {
        public int Id { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }
        public DateTime ListingDate { get; set; }
    }
}
