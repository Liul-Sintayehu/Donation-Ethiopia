// using System.Text.Json;
// using DE.Application.Models.Dtos.IncidentHandling.BaggageIncidents.Response;
// using DE.Domain.Models.IncidentHandling.Incidents.BaggageIncidents;
//
// namespace DE.API.Contracts.Resolvers;
// public class BagsResolver : IValueResolver<BaggageIncident, BaggageIncidentResponseDto, ICollection<BagIdentifier>?>
// {
//     public ICollection<BagIdentifier>? Resolve(BaggageIncident source, BaggageIncidentResponseDto destination, ICollection<BagIdentifier>? destMember, ResolutionContext context)
//     {
//         if (string.IsNullOrEmpty(source.BagsSerialized))
//             return new List<BagIdentifier>();
//
//         var bags = JsonSerializer.Deserialize<List<BagIdentifier>>(source.BagsSerialized);
//
//         // Use AutoMapper to map the BagIdentifier domain model to the response DTO
//         return context.Mapper.Map<ICollection<BagIdentifier>>(bags);
//     }
// }