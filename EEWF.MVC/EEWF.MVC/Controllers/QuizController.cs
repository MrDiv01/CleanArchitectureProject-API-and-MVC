using EEWF.Application.CQRS.CheckQuiz.Queries.CheckingQuiz;
using EEWF.Application.CQRS.CheckQuiz.Queries.GetPoint;
using EEWF.Application.CQRS.Level.Queries.GetLevel;
using EEWF.Application.CQRS.QuizForm.Commands.CreateQuizForm;
using EEWF.Application.CQRS.QuizForm.Commands.UpdateQuizForm;
using EEWF.Application.CQRS.QuizForm.Queries.GetQuizFormId;
using EEWF.Application.CQRS.QuizQuestion.Queries.GetQuizQuestion;
using EEWF.Application.CQRS.QuizQuestion.Queries.GetQuizQuestionById;
using EEWF.Domain.DTOs.Level;
using EEWF.Domain.Entities;
using EEWF.Infrastructure.Data;
using EEWF.MVC.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EEWF.MVC.Controllers
{
    public class QuizController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ApplicationDbContext _applicationDbContext;

        public QuizController(IMediator mediator,ApplicationDbContext applicationDbContext)
        {
            _mediator = mediator;
            _applicationDbContext = applicationDbContext;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> Index(QuizForm quizForm)
        //{
        //    var result = await _mediator.Send(new CreateQuizFormCommand(quizForm.Name, quizForm.SureName, quizForm.Email, quizForm.PhoneNumber));
        //    if (result.StatusCode != (int)HttpStatusCode.OK)
        //    {
        //        foreach (var error in result.Errors)
        //        {
        //            ModelState.AddModelError(error.Key, error.Value);
        //        }

        //        return View(quizForm);
        //    }
        //    var getId = (await _mediator.Send(new GetQuizFormIdQuery(quizForm.Name, quizForm.SureName, quizForm.Email, quizForm.PhoneNumber))).Response;
        //    TempData["id"] = getId;

        //    return RedirectToAction("level", "quiz");
        //}
        public async Task<IActionResult> Level()
        {
            List<LevelDto> levels = (await _mediator.Send(new GetLevelQuery())).Response;
            if (levels == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(levels);
        }
        //    public async Task<IActionResult> Question(int id)
        //    {
        //        QuizViewModel quizViewModel = new QuizViewModel()
        //        {
        //            questions = (await _mediator.Send(new GetQuizQuestionQuery(id))).Response

        //        };
        //        return View(quizViewModel);
        //    }
        //    [HttpPost]
        //    public async Task<JsonResult> CheckQuizById(int variantId, int questionId)
        //    {
        //        var result = (await _mediator.Send(new CheckingQuizQuery(variantId, questionId))).Response;
        //        if (result == true)
        //            return Json(new
        //            {
        //                status = 200
        //            });

        //        return Json(new
        //        {
        //            status = 400
        //        });
        //    }
        //    [HttpPost]
        //    public async Task<IActionResult> UpdateQuizResult(int correct, int incorrect, int count, int levelId)
        //    {
        //        var id = (int)TempData["id"];

        //        var result = await _mediator.Send(new UpdateQuizFormCommand(id, correct, incorrect, count, levelId));
        //        return Json(new { status = 200, message = "Success" });

        //    }


    }
}
