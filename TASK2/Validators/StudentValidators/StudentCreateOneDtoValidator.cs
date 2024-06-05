using FluentValidation;
namespace TASK1.Validators.StudentValidators
{
  public class StudentCreateOneDtoValidator : AbstractValidator<StudentCreateOneDto>
  {
    public StudentCreateOneDtoValidator()
    {
      RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
      RuleFor(x => x.Email).NotEmpty().EmailAddress();
      RuleFor(x => x.GroupId).NotEmpty();
    }
  }
}
