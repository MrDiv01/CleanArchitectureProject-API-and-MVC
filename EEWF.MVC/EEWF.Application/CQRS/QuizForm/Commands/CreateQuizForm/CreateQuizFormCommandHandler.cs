//using EEWF.Application.Core;
//using EEWF.Application.Interfaces;
//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EEWF.Application.CQRS.QuizForm.Commands.CreateQuizForm
//{
//    public class CreateQuizFormCommandHandler : IRequestHandler<CreateQuizFormCommand, ServiceResult<int>>
//    {
//        private readonly IQuizFormService _quizFormService;

//        public CreateQuizFormCommandHandler(IQuizFormService quizFormService)
//        {
//            _quizFormService = quizFormService;
//        }
//        public async Task<ServiceResult<int>> Handle(CreateQuizFormCommand request, CancellationToken cancellationToken)
//        {
//            var result = await _quizFormService.CreateQuizForm(request);
//            return result;
//        }
//    }
//}
