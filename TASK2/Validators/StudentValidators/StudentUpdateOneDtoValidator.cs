using FluentValidation;
namespace TASK1.Validators.StudentValidators
{
  public class StudentUpdateOneDtoValidator : AbstractValidator<StudentUpdateOneDto>
  {
    public StudentUpdateOneDtoValidator()
    {
      RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
      RuleFor(x => x.Email).NotEmpty().EmailAddress();
      RuleFor(x => x.GroupId).NotEmpty();
    }
  }
}
