using EEWF.Application.Core;
using EEWF.Domain.DTOs.Education;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Application.CQRS.Education.Commands.CreateEducation
{
    public class CreateEducationCommand:IRequest<ServiceResult<int>>
    {
        public CreateEducationCommand(string name, string description, IFormFile imageFile)
        {
            Name = name;
            Description = description;
            ImageFile = imageFile;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
