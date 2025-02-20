using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Application.CQRS.QuizForm.Commands.CreateQuizForm
{
	public class CreateQuizFormCommandValidator:AbstractValidator<CreateQuizFormCommand>
	{
        public CreateQuizFormCommandValidator()
        {
			RuleFor(x => x.Name).NotEmpty().WithMessage("The name field cannot be empty.");
			RuleFor(x => x.SureName).NotEmpty().WithMessage("The surname field cannot be empty.");
			RuleFor(x => x.Email).NotEmpty().WithMessage("The email field cannot be empty.");
			RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("The phone number field cannot be empty.");
		}
    }
}
