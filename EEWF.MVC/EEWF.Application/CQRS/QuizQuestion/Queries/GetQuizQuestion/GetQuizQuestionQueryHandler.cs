//using EEWF.Application.Core;
//using EEWF.Application.Interfaces;
//using EEWF.Domain.DTOs.Question;
//using EEWF.Domain.Entities;
//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EEWF.Application.CQRS.QuizQuestion.Queries.GetQuizQuestion
//{

//    public class GetQuizQuestionQueryHandler : IRequestHandler<GetQuizQuestionQuery, ServiceResult<List<Question>>>
//    {
//        private readonly IQuizQuestionService _quizQuestionService;

//        public GetQuizQuestionQueryHandler(IQuizQuestionService quizQuestionService)
//        {
//            _quizQuestionService = quizQuestionService;
//        }
//        public async Task<ServiceResult<List<Question>>> Handle(GetQuizQuestionQuery request, CancellationToken cancellationToken)
//        {
//            var result = await _quizQuestionService.GetQuestionByLevelId(request.LevelId);
//            return result;
//        }
//    }
//}
