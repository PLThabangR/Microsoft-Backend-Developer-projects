using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feature.Agents
{
    public interface IAgentService
    {
         /* Commands for Data manipulation */
        //We are returning a int primarily because we want to return the Id of the newly created agent. This is useful for the client to know the Id of the agent that was just created, so they can use it for further operations if needed.
        //Task means this operation will be asynchronous, which is a common practice in modern applications to avoid blocking the main thread, especially for I/O operations like database access.
        Task<int> CreateAgentAsync(Agent newAgent);

        //UpdateAgentAsync method takes an UpdateAgentRequest object as a parameter, which contains the details of the agent to be updated. It returns a Task, indicating that it's an asynchronous operation. The method is expected to update the agent's information in the database based on the provided request.
        Task<Agent> UpdateAgentAsync(Agent updatedAgent);

        //DeleteAgentAsync method takes an integer agentId as a parameter, which represents the unique identifier of the agent to be deleted. It returns a Task, indicating that it's an asynchronous operation. The method is expected to remove the agent with the specified ID from the database.
        Task<int> DeleteAgentAsync(int agentId);

        /* Queries for Data retrieval */

        //We return the Agent object
        Task<Agent> GetAgentByIdAsync(int agentId);

        Task<List<Agent>> GetAllAgentsAsync();

        //Helper method
        //this will return a boolean
        Task<bool> DoesExistAsync(int agentId);



    }
}
