using CleaningManagement.Api.Validators.Constants;
using CleaningManagement.Api.ViewModels.CleaningPlan;
using FluentValidation;

namespace CleaningManagement.Api.Validators
{
    public class AddCleaningPlanViewModelValidator : AbstractValidator<AddCleaningPlanViewModel>
    {
        public AddCleaningPlanViewModelValidator()
        {

            RuleFor(x => x.Title).MinimumLength(ValidationConstants.CleaningPlanValidationData.MinLengthName)
                                .MaximumLength(ValidationConstants.CleaningPlanValidationData.MaxLengthName)
                                .NotNull();

            RuleFor(x => x.CustomerId)
                .GreaterThanOrEqualTo(1);


        }
    }
}
