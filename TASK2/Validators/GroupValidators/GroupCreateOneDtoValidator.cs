using FluentValidation;
namespace TASK1.Validators.GroupValidators
{
  public class GroupCreateOneDtoValidator : AbstractValidator<GroupCreateOneDto>
  {
    public GroupCreateOneDtoValidator()
    {
      RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
      RuleFor(x => x.Limit)
        .NotEmpty()
        .InclusiveBetween(5, 18);
    }
  }
}
