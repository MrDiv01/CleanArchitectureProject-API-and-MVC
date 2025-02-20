using EEWF.Application.Core;
using EEWF.Domain.DTOs.Question;
using EEWF.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Application.CQRS.QuizQuestion.Queries.GetQuizQuestion
{
    public class GetQuizQuestionQuery:IRequest<ServiceResult<List<Question>>>
    {
        public GetQuizQuestionQuery(int id)
        {
            LevelId = id;
        }
        public string Query { get; set; }
        public double Point { get; set; }
        public ICollection<Variant> Variants { get; set; }
        //Level
        public int LevelId { get; set; }
    }
}
