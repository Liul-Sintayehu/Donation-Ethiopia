using System.ComponentModel.DataAnnotations;
using DE.API.Controllers.Common;
using DE.Application.Commands.Attachments;
using DE.Application.Models.Dtos.Attachments.Request;
using DE.Application.Models.Dtos.Attachments.Response;
using DE.Application.Queries.Attachments;

namespace DE.API.Controllers.V1._0.Attachments;

public class AttachmentController: BaseController
{
    [HttpGet("GetByEntityId/{entityId:long}")]
    public async Task<IActionResult> GetByEntityId([FromRoute] long entityId, [FromQuery] EntityType entityType)
    {
        var result = await _mediator.Send(new GetAttachmentsByRelatedEntityId(entityId, entityType));
        var response = _mapper.Map<List<AttachmentResponseDto>>(result);
        return Ok(response);
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromForm] CreateAttachmentRequestDto requests)
    {
        var result = await _mediator.Send(new CreateAttachmentsCommand(requests));
        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result.Payload);
    }

    [HttpDelete("Delete/{attachmentId:long}")]
    public async Task<IActionResult> Delete([FromRoute] long attachmentId)
    {
        var result = await _mediator.Send(new DeleteAttachmentsCommand(attachmentId));
        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result.Payload);
    }
}