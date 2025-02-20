using EEWF.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Infrastructure.Data.Configurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.Property(x => x.Point).IsRequired();
            builder.Property(x => x.Query).IsRequired();
            builder.Property(x => x.LevelId).IsRequired();
            builder.HasData(new Question
            {
                Id =1,
                Query = "TestQuery",
                Point = 20,
                LevelId = 1,
            });
        }
    }
}
