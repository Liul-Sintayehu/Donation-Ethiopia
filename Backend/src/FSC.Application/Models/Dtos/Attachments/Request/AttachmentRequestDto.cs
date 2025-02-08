using Microsoft.AspNetCore.Http;

namespace DE.Application.Models.Dtos.Attachments.Request;

public class AttachmentRequestDto
{
    public IFormFile File { get; set; }
    public string? Caption { get; set; }
}