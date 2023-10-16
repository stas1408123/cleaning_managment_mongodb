using CleaningManagement.Api.Validators.Constants;
using CleaningManagement.Api.ViewModels.CleaningPlan;
using FluentValidation;

namespace CleaningManagement.Api.Validators
{
    public class CleaningPlanViewModelValidator : AbstractValidator<CleaningPlanViewModel>
    {
        public CleaningPlanViewModelValidator()
        {
            RuleFor(x => x.Id).Empty();
            RuleFor(x => x.Title).MinimumLength(ValidationConstants.CleaningPlanValidationData.MinLengthName)
                                .MaximumLength(ValidationConstants.CleaningPlanValidationData.MaxLengthName)
                                .NotNull();
            RuleFor(x => x.CreatedAt).Empty();
            RuleFor(x => x.CustomerId).GreaterThanOrEqualTo(1);
        }
    }
}
