using Microsoft.AspNetCore.Http;

namespace DE.Application.Models.Dtos.LostAndFound.Request;

public class AddAgentSignatureRequestDto
{
   public IFormFile Signature { get; set; }
}