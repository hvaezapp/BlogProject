using AutoMapper;
using BlogProject.Application.Contract.Persistence;
using BlogProject.Application.Dto.Post;
using BlogProject.Application.Dto.PostTag;
using BlogProject.Application.Features.PostTag.Request.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Application.Features.PostTag.Handler.Commands
{
    public class CreatePostTagCommandRequestHandler : IRequestHandler<CreatePostTagCommandRequest, ApiResponseResult>
    {
        private readonly IPostTagRepository _postTagRepository;
        private readonly IMapper _mapper;

        public CreatePostTagCommandRequestHandler(IPostTagRepository postTagRepository, IMapper mapper)
        {
            _postTagRepository = postTagRepository;
            _mapper = mapper;
        }

        public async Task<ApiResponseResult> Handle(CreatePostTagCommandRequest request, CancellationToken cancellationToken)
        {
            var api = new ApiResponseResult();

            try
            {

                var postTag = _mapper.Map<Domain.entity.PostTag>(request.CreatePostTagDto);

                await _postTagRepository.Create(postTag);
                await _postTagRepository.SaveAsync();


                var result = _mapper.Map<GetPostTagDto>(postTag);

                api.Success(result);

            }
            catch (Exception ex)
            {
                api.Error(ex.Message);
            }

            return api;
        }
    }
}
