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
	public class EducationConfiguration : IEntityTypeConfiguration<Education>
	{
		public void Configure(EntityTypeBuilder<Education> builder)
		{
			builder.Property(x => x.Image).IsRequired();
			builder.Property(x => x.Name).IsRequired();
			builder.Property(x => x.Description).IsRequired();
			//builder.Property(x => x.ButtonText).IsRequired();
			builder.Property(x => x.CreateAt).HasDefaultValueSql("GETUTCDATE()");
			builder.Property(x => x.UpdateAt).HasDefaultValueSql("GETUTCDATE()");
			builder.HasData(new Education
			{
				Id = 1,
				Name = "Test",
				Description = "DescriptionTest",
				Image = "xcvb",
			});
		}
	}
}
