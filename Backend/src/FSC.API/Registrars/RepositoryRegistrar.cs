// using DE.Application.Models.Dtos.CrewManager;
// using DE.Application.Models.Dtos.SapDataTables;
using DE.Domain.Models.Approvals;
using DE.Domain.Models.Assignment;
using DE.Domain.Models.Attachments;
using DE.Domain.Models.EmployeeAssignments;
using DE.Domain.Models.IncidentHandling.Incidents;
using DE.Domain.Models.IncidentHandling.Incidents.AirCraftIncidents;
using DE.Domain.Models.IncidentHandling.Incidents.BaggageIncidents;
using DE.Domain.Models.IncidentHandling.Incidents.InjuryIncidents;
using DE.Domain.Models.IncidentHandling.Incidents.TheftIncidents;
using DE.Domain.Models.IncidentHandling.Incidents.VehicleIncidents;
using DE.Domain.Models.IncidentHandling.Investigations;
using DE.Domain.Models.LostAndFound;
using DE.Domain.Models.Master;
using DE.Domain.Models.Notifications;
using DE.Domain.Models.OffloadBaggages;
using DE.Domain.Models.WeaponAlert;

namespace DE.API.Registrars
{
    public class RepositoryRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped(typeof(IRepositoryBase<Position>), typeof(RepositoryBase<Position>));
            builder.Services.AddScoped(typeof(IRepositoryBase<CostCenter>), typeof(RepositoryBase<CostCenter>));
            builder.Services.AddScoped(typeof(IRepositoryBase<AircraftType>), typeof(RepositoryBase<AircraftType>));
            builder.Services.AddScoped(typeof(IRepositoryBase<Employee>), typeof(RepositoryBase<Employee>));
            builder.Services.AddScoped(typeof(IRepositoryBase<FlightSchedule>), typeof(RepositoryBase<FlightSchedule>));
            builder.Services.AddScoped(typeof(IRepositoryBase<MajorTask>), typeof(RepositoryBase<MajorTask>));
            builder.Services.AddScoped(typeof(IRepositoryBase<SubTask>), typeof(RepositoryBase<SubTask>));

            builder.Services.AddScoped(typeof(IRepositoryBase<FlightClearanceAssignment>), typeof(RepositoryBase<FlightClearanceAssignment>));
            builder.Services.AddScoped(typeof(IRepositoryBase<MajorFlightTaskAssignment>), typeof(RepositoryBase<MajorFlightTaskAssignment>));
            builder.Services.AddScoped(typeof(IRepositoryBase<ApprovalLog>), typeof(RepositoryBase<ApprovalLog>));
            
            builder.Services.AddScoped(typeof(IRepositoryBase<ClearanceAssignment>), typeof(RepositoryBase<ClearanceAssignment>));
            builder.Services.AddScoped(typeof(IRepositoryBase<ClearanceSubTaskAssignment>), typeof(RepositoryBase<ClearanceSubTaskAssignment>));
            builder.Services.AddScoped(typeof(IRepositoryBase<Approval>), typeof(RepositoryBase<Approval>));

            builder.Services.AddScoped(typeof(IRepositoryBase<Weapon>), typeof(RepositoryBase<Weapon>));
            builder.Services.AddScoped(typeof(IRepositoryBase<WeaponHandling>), typeof(RepositoryBase<WeaponHandling>));
            builder.Services.AddScoped(typeof(IRepositoryBase<Notification>), typeof(RepositoryBase<Notification>));

            builder.Services.AddScoped(typeof(IRepositoryBase<Attachment>), typeof(RepositoryBase<Attachment>));

            builder.Services.AddScoped(typeof(IRepositoryBase<Incident>), typeof(RepositoryBase<Incident>));
            builder.Services.AddScoped(typeof(IRepositoryBase<BaggageIncident>), typeof(RepositoryBase<BaggageIncident>));
            builder.Services.AddScoped(typeof(IRepositoryBase<TheftIncident>), typeof(RepositoryBase<TheftIncident>));
            builder.Services.AddScoped(typeof(IRepositoryBase<AirCraftIncident>), typeof(RepositoryBase<AirCraftIncident>));
            builder.Services.AddScoped(typeof(IRepositoryBase<InjuryIncident>), typeof(RepositoryBase<InjuryIncident>));
            builder.Services.AddScoped(typeof(IRepositoryBase<VehicleIncident>), typeof(RepositoryBase<VehicleIncident>));

            builder.Services.AddScoped(typeof(IRepositoryBase<Investigation>), typeof(RepositoryBase<Investigation>));
            builder.Services.AddScoped(typeof(IRepositoryBase<Suspect>), typeof(RepositoryBase<Suspect>));
            builder.Services.AddScoped(typeof(IRepositoryBase<Witness>), typeof(RepositoryBase<Witness>));

            builder.Services.AddScoped(typeof(IRepositoryBase<LostAndFoundItem>), typeof(RepositoryBase<LostAndFoundItem>));

            builder.Services.AddScoped(typeof(IRepositoryBase<OffloadBaggage>), typeof(RepositoryBase<OffloadBaggage>));
            
            builder.Services.AddScoped(typeof(IRepositoryBase<Post>), typeof(RepositoryBase<Post>));
            builder.Services.AddScoped(typeof(IRepositoryBase<PostAssignment>), typeof(RepositoryBase<PostAssignment>));
            
            builder.Services.AddScoped(typeof(IRepositoryBase<Escort>), typeof(RepositoryBase<Escort>));
            builder.Services.AddScoped(typeof(IRepositoryBase<EscortAssignment>), typeof(RepositoryBase<EscortAssignment>));

            // builder.Services.AddScoped(typeof(IRepositoryBase<EmployeeLeave>), typeof(RepositoryBase<EmployeeLeave>));
            // builder.Services.AddScoped(typeof(IRepositoryBase<EmployeeShift>), typeof(RepositoryBase<EmployeeShift>));
            //
            // builder.Services.AddScoped(typeof(IRepositoryBase<Crew>), typeof(RepositoryBase<Crew>));
        }
    }
}
