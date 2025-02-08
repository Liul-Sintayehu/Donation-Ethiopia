using System.ComponentModel.DataAnnotations.Schema;
using DE.Domain.Helpers;
using DE.Domain.Models.IncidentHandling.Investigations;
using DE.Domain.Models.Master;
using Severity = DE.Domain.Common.Severity;

namespace DE.Domain.Models.IncidentHandling.Incidents;

public abstract class Incident: BaseEntity
{                 
    public DateTime IncidentDate { get; set; }
    public IncidentCategory IncidentCategory { get; set; }           
    public string? Description { get; set; } = string.Empty;
    public string? Location { get; set; } = string.Empty;   
    public Severity Severity { get; set; }
    public IncidentStatus IncidentStatus { get; set; }
    
    public string? Resolution { get; set; } = string.Empty;   
    public DateTime? ResolvedAt { get; set; }
    public string? Remarks { get; set; } = string.Empty;             
    
    public long RecordedByOfficerId { get; init; }
    [ForeignKey(nameof(RecordedByOfficerId))]
    public Employee RecordedByOfficer { get; set; }
    
    // Navigation property for related investigations
    public virtual ICollection<Investigation> Investigations { get; set; } = new List<Investigation>();
    
    protected void UpdateIncidentStatus(IncidentStatus incidentStatus, string? resolution, string? remark)
    {
        IncidentStatus = incidentStatus;
        Remarks = remark;
        if (incidentStatus != IncidentStatus.Resolved) return;
        
        Resolution = resolution;
        ResolvedAt = Helper.GetDateTimeNow();
    }
}
