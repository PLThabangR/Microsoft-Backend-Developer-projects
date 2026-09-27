using Application.Wrapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feature.Agents.Commands
{
    //Make this a mediatr request 
    //This will travel through a mediator pipeline to the handler, which will then call the service to create a new agent

    public class CreateAgentCommand: IRequest<IResponseWrapper>
    {
        //parameters for the command, which will be used to create a new agent
        public CreateAgentRequest CreateAgent { get; set; }

    }

    //Handler Request Class
    //To handle the command, we need to create a handler class that will implement the IRequestHandler interface, which will take in the command and return a response wrapper
    // Then implement t request and t response , which will be the command and the response wrapper
    public class CreateAgentCommandHandler : IRequestHandler<CreateAgentCommand, IResponseWrapper>
    {
        //Inject the IAgentService into the handler class, so we can call the service to create a new agent
        private IAgentService _agentService;
        public CreateAgentCommandHandler(IAgentService agentService)
        {
            //
            _agentService = agentService;

        }
        //Implement the Handle method, which will take in the command and return a response wrapper
        //The Handle method will be called by the mediator when the command is sent, and will call the service to create a new agent
        public async Task<IResponseWrapper> Handle(CreateAgentCommand request, CancellationToken cancellationToken)
        {

            //Use mapter to map from request to domain agent model, so we can call the service to create a new agent
            var newAgent = request.CreateAgent.Adapt<Agent>();
            //Call the service to create a new agent
            var result = await _agentService.CreateAgent(newAgent);

            //Return the response wrapper
            return ResponseWrapper.Success(data: result, message: "Agent created successfully");

        }
    }
}
