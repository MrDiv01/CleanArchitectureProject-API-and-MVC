using EEWF.Application.Core;
using EEWF.Domain.DTOs.Question;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Application.CQRS.QuizQuestion.Queries.GetQuizQuestionById
{
	public class GetQuizQuestionByIdQuery : IRequest<ServiceResult<List<QuestionDto>>>
	{
		public GetQuizQuestionByIdQuery(int questionId)
		{
			QuestionId = questionId;
		}
		public int QuestionId { get; set; }
		public string Query { get; set; }
		public double Point { get; set; }
		//public ICollection<Variant> variants { get; set; }
		//Level
		public int LevelId { get; set; }

	}
}
