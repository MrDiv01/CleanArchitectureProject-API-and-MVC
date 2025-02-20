using EEWF.Application.CQRS.QuizQuestion.Queries.GetQuizQuestion;
using EEWF.MVC.Areas.Admin.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EEWF.MVC.Areas.Admin.Controllers
{
    [Area("admin")]
    public class QuestionController : Controller
    {
        private readonly IMediator _mediator;
        public QuestionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index(int levelId)
        {
            return View();
        }

      
    }
}
