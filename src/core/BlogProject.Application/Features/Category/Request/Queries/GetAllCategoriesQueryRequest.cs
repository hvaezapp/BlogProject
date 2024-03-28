using BlogProject.Domain.entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Application.Features.Category.Request.Queries
{
    public class GetAllCategoriesQueryRequest : IRequest<IEnumerable<Domain.entity.Category>>
    {

    }
}
