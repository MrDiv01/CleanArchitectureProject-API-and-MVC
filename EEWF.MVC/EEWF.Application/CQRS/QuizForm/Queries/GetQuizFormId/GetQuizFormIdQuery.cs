using EEWF.Application.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Application.CQRS.QuizForm.Queries.GetQuizFormId
{
    public class GetQuizFormIdQuery:IRequest<ServiceResult<int>>
    {
        public GetQuizFormIdQuery(string name, string surename, string email, string phone)
        {
            Name = name;
            Surename = surename;
            Phone = phone;
            Email = email;
        }

        public string Name { get; set; }
        public string Surename { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

    }
}
