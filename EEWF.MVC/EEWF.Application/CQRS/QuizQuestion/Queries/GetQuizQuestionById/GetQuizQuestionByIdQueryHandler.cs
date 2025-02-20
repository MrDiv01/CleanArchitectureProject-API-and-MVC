//using EEWF.Application.Core;
//using EEWF.Application.Interfaces;
//using EEWF.Domain.DTOs.Question;
//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EEWF.Application.CQRS.QuizQuestion.Queries.GetQuizQuestionById
//{
//	public class GetQuizQuestionByIdQueryHandler : IRequestHandler<GetQuizQuestionByIdQuery, ServiceResult<List<QuestionDto>>>
//	{
//		private readonly IQuizQuestionService _quizQuestionService;

//		public GetQuizQuestionByIdQueryHandler(IQuizQuestionService quizQuestionService)
//        {
//			_quizQuestionService = quizQuestionService;
//		}
//        public async Task<ServiceResult<List<QuestionDto>>> Handle(GetQuizQuestionByIdQuery request, CancellationToken cancellationToken)
//		{
//			var result = await _quizQuestionService.GetQuestionPointById(request.QuestionId);
//			return result;
//		}
//	}
//}
