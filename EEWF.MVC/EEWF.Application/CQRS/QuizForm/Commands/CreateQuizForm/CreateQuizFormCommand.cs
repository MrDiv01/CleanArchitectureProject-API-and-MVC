using EEWF.Application.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Application.CQRS.QuizForm.Commands.CreateQuizForm
{
    public class CreateQuizFormCommand : IRequest<ServiceResult<int>>
    {
        public CreateQuizFormCommand(string name, string sureName, string email, string phoneNumber)
        {
            Name = name;
            SureName = sureName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        public int QuizFormId { get; set; }
        public string Name { get; set; }
        public string SureName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
