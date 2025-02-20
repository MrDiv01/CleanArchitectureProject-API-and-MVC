using EEWF.Application.Core;
using EEWF.Application.Interfaces;
using EEWF.Domain.DTOs.Question;
using EEWF.Domain.Entities;
using EEWF.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Infrastructure.Services
{
    public class CheckQuizService : ICheckQuizService
    {
        double count = 0;
        private readonly ApplicationDbContext _dbContext;

        public CheckQuizService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ServiceResult<bool>> CheckQuiz(int variant_id, int quiz_id)
        {
            var result = await _dbContext.Variants.Where(x => x.QuestionId == quiz_id &&
                                                              x.Id == variant_id &&
                                                              x.IsCorrect == true)
                                                                             .AnyAsync();
            return ServiceResult<bool>.OK(result);

        }

        public  async Task<ServiceResult<double>> GetPoint(int variant_id, int quiz_id)
        {
            var result = await _dbContext.Variants.Include(x => x.Question).Where(x => x.QuestionId == quiz_id  &&
                                                              x.IsCorrect == true).
                                                                            Select(x => new QuestionDto
                                                                            {
                                                                                  Point = x.Question.Point,
                                                                            }).ToListAsync();
            foreach(var item in result)
            {
                count += item.Point;
            }
            return ServiceResult<double>.OK(count);

        }
    }
}
