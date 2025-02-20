//using EEWF.Application.Core;
//using EEWF.Application.Interfaces;
//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EEWF.Application.CQRS.QuizForm.Queries.GetQuizFormId
//{
//    public class GetQuizFormIdQueryHandler : IRequestHandler<GetQuizFormIdQuery, ServiceResult<int>>
//    {
//        private readonly IQuizFormService _quizFormService;

//        public GetQuizFormIdQueryHandler(IQuizFormService quizFormService)
//        {
//            _quizFormService = quizFormService;
//        }
//        public async Task<ServiceResult<int>> Handle(GetQuizFormIdQuery request, CancellationToken cancellationToken)
//        {
//            var result = await _quizFormService.GetFormId(request.Name,request.Surename,request.Email,request.Phone);
//            return result;
//        }
//    }
//}
