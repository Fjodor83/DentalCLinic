using FluentValidation;

namespace DentalCLinic.Models
{
    public class ContactFormModelValidator : AbstractValidator<ContactFormModel>
    {
        public ContactFormModelValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(100).WithMessage("Name cannot exceed 100 characters");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Please enter a valid email address");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Phone number is required")
                .MaximumLength(20).WithMessage("Phone number cannot exceed 20 characters")
                .Matches(@"^[\d\s\-\+\(\)]+$").WithMessage("Please enter a valid phone number format");

            RuleFor(x => x.Message)
                .NotEmpty().WithMessage("Message is required")
                .MinimumLength(10).WithMessage("Message must be at least 10 characters")
                .MaximumLength(1000).WithMessage("Message cannot exceed 1000 characters");
        }
    }
}
