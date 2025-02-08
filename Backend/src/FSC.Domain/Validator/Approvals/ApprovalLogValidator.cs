using DE.Domain.Models.Approvals;

namespace DE.Domain.Validator.Approvals
{
    public class ApprovalLogValidator : AbstractValidator<ApprovalLog>
    {
        public ApprovalLogValidator()
        {

            RuleFor(x => x.MajorFlightTaskAssignmentId)
                  .NotNull().WithMessage("Code can't be null")
                  .NotEmpty().WithMessage("Code can't be empty");
        }
    }
}
