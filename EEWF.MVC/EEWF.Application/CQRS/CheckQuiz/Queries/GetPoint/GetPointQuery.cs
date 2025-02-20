using EEWF.Application.Core;
using EEWF.Domain.DTOs.Question;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Application.CQRS.CheckQuiz.Queries.GetPoint
{
    public class GetPointQuery : IRequest<ServiceResult<double>>
    {
        public GetPointQuery(int variantId, int questionId)
        {
            VariantId = variantId;

            QuestionId = questionId;

        }
        public int VariantId { get; set; }
        public int QuestionId { get; set; }
        public int point { get; set; }
    }
}
