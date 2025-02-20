using EEWF.Application.CQRS.Education.Queries.GetEducationById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EEWF.MVC.Controllers
{
	public class EducationInfoController : Controller
	{
		private readonly IMediator _mediator;

		public EducationInfoController(IMediator mediator)
        {
			_mediator = mediator;
		}
        public async Task<IActionResult> Index(int id)
		{
			var education = (await _mediator.Send(new GetEducationByIdQuery(id))).Response;
			if(education == null)
			{
			return	RedirectToAction("Index", "Home");
			}
			return View(education);
		}
	}
}
