using DE.API.Contracts.Common;
using DE.API.Controllers.Common;
using DE.Application.Commands.AircraftTypes;
using DE.Application.Commands.Master.AircraftTypes;
using DE.Application.Models.Dots.Master.AircraftTypes;
using DE.Application.Queries.Master.AircraftTypes;

namespace DE.API.Controllers.V1._0.Master
{
    public class AircraftTypeController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll(RecordStatus? recordStatus)
        {
            var result = await _mediator.Send(new GetAllAircraftType(recordStatus));
            var response = _mapper.Map<List<AircraftTypeDetailDto>>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        
        {
            var result = await _mediator.Send(new GetByIdAircraftType(id));
            var response = _mapper.Map<AircraftTypeDetailDto>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(response);
        }
        [HttpGet("Search")]
        public async Task<IActionResult> Search(string? aircraftTypeCode, string? aircraftTypeName)
        {
            var result = await _mediator.Send(new GetBySearchAircraftType(aircraftTypeCode, aircraftTypeName));
            var response = _mapper.Map<List<AircraftTypeDetailDto>>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(response);
        }
        [HttpPost("Create")]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] AircraftTypeDto request)
        {
            var result = await _mediator.Send(new CreateAircraftType(request.AircraftTypeCode, request.AircraftTypeName));
            var response = _mapper.Map<AircraftTypeDetailDto>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(response);
        }
        [HttpPut("Update/{id}")]
        [ValidateModel]
        public async Task<IActionResult> Update([FromBody] AircraftTypeDto request, long id)
        {
            var result = await _mediator.Send(new UpdateAircraftType(id, request.AircraftTypeCode, request.AircraftTypeName));
            var response = _mapper.Map<AircraftTypeDetailDto>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(response);
        }
        [HttpPut("UpdateStatus/{id}")]
        [ValidateModel]
        public async Task<IActionResult> Update([FromBody] RecordStatusDto request, long id)
        {
            var result = await _mediator.Send(new UpdateStatusAircraftType(id, request.Status));
            var response = _mapper.Map<AircraftTypeDetailDto>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(response);
        }
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var result = await _mediator.Send(new DeleteAircraftType(id));
            var response = _mapper.Map<AircraftTypeDetailDto>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(response);
        }
    }
}
