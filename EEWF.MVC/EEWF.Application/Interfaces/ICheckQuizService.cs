using EEWF.Application.Core;
using EEWF.Domain.DTOs.Question;
using EEWF.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Application.Interfaces
{
    public interface ICheckQuizService
    {
        Task<ServiceResult<bool>> CheckQuiz(int variant_id, int quiz_id);
        Task<ServiceResult<double>> GetPoint(int variant_id, int quiz_id);
    }
}
