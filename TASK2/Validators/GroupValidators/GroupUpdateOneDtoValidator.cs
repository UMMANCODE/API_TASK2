using FluentValidation;
namespace TASK1.Validators.GroupValidators
{
  public class GroupUpdateOneDtoValidator : AbstractValidator<GroupUpdateOneDto>
  {
    public GroupUpdateOneDtoValidator()
    {
      RuleFor(x => x.Name)
        .NotEmpty()
        .MinimumLength(4)
        .MaximumLength(5);
      RuleFor(x => x.Limit)
        .NotEmpty()
        .InclusiveBetween(5, 18);
    }
  }
}
