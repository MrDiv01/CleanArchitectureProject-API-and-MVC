using EEWF.Application.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Application.CQRS.CheckQuiz.Queries.CheckingQuiz
{
    public class CheckingQuizQuery:IRequest<ServiceResult<bool>>
    {
        public CheckingQuizQuery(int variantId, int questionId)
        {
            VariantId = variantId;

            QuestionId = questionId;

        }
        public int VariantId { get; set; }
        public int QuestionId { get; set; }
    }
}
