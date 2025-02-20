//using EEWF.Application.Core;
//using EEWF.Application.Interfaces;
//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EEWF.Application.CQRS.QuizForm.Commands.UpdateQuizForm
//{
//    public class UpdateQuizFormCommandHandler : IRequestHandler<UpdateQuizFormCommand, ServiceResult<int>>
//    {
//        private readonly IQuizFormService _quizFormService;

//        public UpdateQuizFormCommandHandler(IQuizFormService quizFormService)
//        {
//            _quizFormService = quizFormService;
//        }
//        public async Task<ServiceResult<int>> Handle(UpdateQuizFormCommand request, CancellationToken cancellationToken)
//        {
//            var result = await _quizFormService.UpdateQuizForm((int)request.QuizFormId, (int)request.CorectAnswerCount, (int)request.FalseAnswerCount, (int)request.Point, (int)request.LevelId);
//            return result;
//        }
//    }
//}
