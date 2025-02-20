using EEWF.Application.Core;
using EEWF.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Application.CQRS.CheckQuiz.Queries.CheckingQuiz
{
    public class CheckingQuizQueryHandler : IRequestHandler<CheckingQuizQuery, ServiceResult<bool>>
    {
        private readonly ICheckQuizService _checkQuizService;

        public CheckingQuizQueryHandler(ICheckQuizService checkQuizService)
        {
            _checkQuizService = checkQuizService;
        }

        Task<ServiceResult<bool>> IRequestHandler<CheckingQuizQuery, ServiceResult<bool>>.Handle(CheckingQuizQuery request, CancellationToken cancellationToken)
        {
                var resut = _checkQuizService.CheckQuiz(request.VariantId, request.QuestionId);
                return resut;
        }
    }
}
