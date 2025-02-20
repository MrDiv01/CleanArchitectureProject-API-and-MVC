using EEWF.Application.Core;
using EEWF.Application.Interfaces;
using EEWF.Domain.DTOs.Question;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Application.CQRS.CheckQuiz.Queries.GetPoint
{
    public class GetPointQueryHandler : IRequestHandler<GetPointQuery, ServiceResult<double>>
    {
        private readonly ICheckQuizService _checkQuiz;

        public GetPointQueryHandler(ICheckQuizService checkQuiz)
        {
           _checkQuiz = checkQuiz;
        }
        public Task<ServiceResult<double>> Handle(GetPointQuery request, CancellationToken cancellationToken)
        {
            var result = _checkQuiz.GetPoint(request.VariantId, request.QuestionId);
            return result;
        }
    }
}
