using EEWF.Application.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Application.CQRS.QuizForm.Commands.UpdateQuizForm
{
    public class UpdateQuizFormCommand:IRequest<ServiceResult<int>>
    {
        public UpdateQuizFormCommand(int id,int correctA, int falseA, int point, int levelId)
        {
            QuizFormId = id;
            CorectAnswerCount = correctA;
            FalseAnswerCount = falseA;
            Point = point;
            LevelId = levelId;
        }
        public int QuizFormId { get; set; }
        public int? CorectAnswerCount { get; set; }
        public int? FalseAnswerCount { get; set; }
        public int? Point { get; set; }
        public int? LevelId { get; set; }
    }
}
