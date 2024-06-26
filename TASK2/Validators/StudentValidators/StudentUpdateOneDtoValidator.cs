using FluentValidation;
using TASK2.Dtos.StudentDtos;
namespace TASK2.Validators.StudentValidators {
  public class StudentUpdateOneDtoValidator : AbstractValidator<StudentUpdateOneDto> {
    public StudentUpdateOneDtoValidator() {
      RuleFor(x => x.FirstName).NotEmpty().MaximumLength(50);
      RuleFor(x => x.LastName).NotEmpty().MaximumLength(50);
      RuleFor(x => x.Email).NotEmpty().MaximumLength(100).EmailAddress();
      RuleFor(x => x.Address).NotEmpty().MaximumLength(200);
      RuleFor(x => x.Phone).NotEmpty().MaximumLength(12);
      RuleFor(x => x.BirthDate).NotEmpty();
      RuleFor(x => x.GroupId).NotEmpty();
      RuleFor(x => x.Id).NotEmpty();
    }
  }
}
