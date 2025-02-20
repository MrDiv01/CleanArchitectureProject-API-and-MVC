using EEWF.Domain.DTOs.Question;
using EEWF.Domain.DTOs.Variant;
using EEWF.Domain.Entities;

namespace EEWF.MVC.Areas.Admin.ViewModels
{
    public class QuizViewModel
    {
        public List<QuestionDto> Questions { get; set; }
        public List<VariantDto> Variants { get; set; }
        public QuizForm QuizForm { get; set; }
        public List<Question> questions { get; set; }
    }
}
