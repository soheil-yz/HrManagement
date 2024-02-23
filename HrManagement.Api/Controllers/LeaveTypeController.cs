using Hr_Management;
using Hr_Management.Application.DTOs.Type;
using Hr_Management.Application.features.LeaveTypes.Requests.Commonds;
using Hr_Management.Application.features.LeaveTypes.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HrManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LeaveTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<ActionResult<List<LeaveTypeDto>>> Get()
        {
            var leaveTypes = await _mediator.Send(new GetLeaveTypeListRequest());
            return Ok(leaveTypes);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveTypeDto>> Get(int id)
        {
            var leaveType = await _mediator.Send(new GetLeaveTypeDetailRequest { Id = id });
            return Ok(leaveType);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateLeaveTypeDto leaveTypeDto)
        {
            var command = new CreateLeaveTypeCommands { LeaveTypeDto = leaveTypeDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] LeaveTypeDto leaveType)
        {
            var command = new UpdateLeaveTypeCommands { LeaveTypeDto = leaveType };
            await _mediator.Send(command);
            return NoContent(); 
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command  = new DeleteLeaveTypeCommands { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
