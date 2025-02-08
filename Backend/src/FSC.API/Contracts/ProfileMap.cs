// using DE.API.Contracts.Resolvers;
using DE.Application.Models.Dots.Master.AircraftTypes;
// using DE.Application.Models.Dots.Master.CostCenters;
// using DE.Application.Models.Dots.Master.Positions;
// using DE.Application.Models.Dtos.Approvals.Response;
// using DE.Application.Models.Dtos.Assignments.ClearanceAssignments.Response;
// using DE.Application.Models.Dtos.Assignments.ClearanceSubTaskAssignments.Response;
using DE.Application.Models.Dtos.Attachments.Response;
// using DE.Application.Models.Dtos.EmployeeAssignments.Escorts.Response;
// using DE.Application.Models.Dtos.EmployeeAssignments.Response;
// using DE.Application.Models.Dtos.IncidentHandling.AirCraftIncidents.Response;
// using DE.Application.Models.Dtos.IncidentHandling.BaggageIncidents.Response;
// using DE.Application.Models.Dtos.IncidentHandling.Incidents.Response;
// using DE.Application.Models.Dtos.IncidentHandling.InjuryIncidents.Response;
// using DE.Application.Models.Dtos.IncidentHandling.Investigations.Response;
// using DE.Application.Models.Dtos.IncidentHandling.Suspects.Response;
// using DE.Application.Models.Dtos.IncidentHandling.TheftIncidents.Response;
// using DE.Application.Models.Dtos.IncidentHandling.VehicleIncidents.Response;
// using DE.Application.Models.Dtos.IncidentHandling.Witnesses.Response;
using DE.Application.Models.Dtos.LostAndFound.Response;
using DE.Application.Models.Dtos.Master.Employees;
// using DE.Application.Models.Dtos.Master.FlightSchedules;
// using DE.Application.Models.Dtos.Master.MajorTasks;
// using DE.Application.Models.Dtos.Master.SubTasks;
using DE.Application.Models.Dtos.Notifications.Response;
// using DE.Application.Models.Dtos.OffloadBaggages.Response;
// using DE.Application.Models.Dtos.WeaponAlert.Response;
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

namespace DE.API.Contracts;
public class ProfileMap : Profile
{
    public ProfileMap()
    {
        // CreateMap<CostCenter, CostCenterDetailDto>();
        CreateMap<AircraftType, AircraftTypeDetailDto>();
        // CreateMap<Position, PositionDetailDto>();
        CreateMap<Employee, EmployeeDetailDto>();
        
        // CreateMap<FlightSchedule, FlightScheduleDetailDto>();
        // CreateMap<MajorTask, MajorTaskDetailDto>();
        // CreateMap<SubTask, SubTaskDetailDto>();
        //
        // CreateMap<ClearanceAssignment, ClearanceAssignmentResponseDto>();
        // CreateMap<ClearanceSubTaskAssignment, ClearanceSubTaskAssignmentResponseDto>();
        // CreateMap<Approval, ApprovalResponseDto>();
        // CreateMap<ClearanceAssignmentApprovals, ClearanceAssignmentApprovalResponseDto>();
        //
        // CreateMap<ApprovalLog, ApprovalDetailDto>();
        // CreateMap<ApprovalLog, ApprovalLogResponse>();
        // CreateMap<LatestApprovalsWithStatus, LatestApprovalsWithStatusResponseDto>();
        //
        // CreateMap<Weapon, WeaponResponseDto>();
        // CreateMap<WeaponHandling, WeaponAlertResponseDto>();
        
        CreateMap<Notification, NotificationListResponseDto>();
        CreateMap<Notification, NotificationDetailResponseDto>();

        CreateMap<Attachment, AttachmentResponseDto>();
        
        // CreateMap<Incident, IncidentDto>();
        // CreateMap<BaggageIncident, BaggageIncidentResponseDto>()
        //     .ForMember(dest => dest.Bags, opt => 
        //         opt.MapFrom<BagsResolver>());
        // CreateMap<TheftIncident, TheftIncidentResponseDto>()
        //     .ForMember(dest => dest.Exhibits, opt =>
        //         opt.MapFrom<ExhibitsResolver>());
        // CreateMap<AirCraftIncident, AirCraftIncidentResponseDto>();
        // CreateMap<InjuryIncident, InjuryIncidentResponseDto>();
        // CreateMap<VehicleIncident, VehicleIncidentResponseDto>();
        //
        // CreateMap<Investigation, InvestigationResponseDto>();
        // CreateMap<Suspect, SuspectResponseDto>();
        // CreateMap<Witness, WitnessResponseDto>();
        //
        // CreateMap<OffloadBaggage, OffloadBaggageResponseDto>();
        
        CreateMap<LostAndFoundItem, LostAndFoundItemDetailDto>();
        
        // CreateMap<Post, PostResponseDto>();
        // CreateMap<PostAssignment, PostAssignmentResponseDto>();
        //
        // CreateMap<Escort, EscortResponseDto>();
        // CreateMap<EscortAssignment, EscortAssignmentResponseDto>();
    }
}
