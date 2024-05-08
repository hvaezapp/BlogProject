using AutoMapper;
using BlogProject.Application.Contract.Persistence;
using BlogProject.Application.Dto.Post;
using BlogProject.Application.Features.Category.Request.Commands;
using BlogProject.Application.Features.Post.Request.Commands;
using BlogProject.Domain.entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Application.Features.Post.Handler.Commands
{
    public class CreatePostCommandRequestHandler : IRequestHandler<CreatePostCommandRequest, ApiResponseResult>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public CreatePostCommandRequestHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }


        public async Task<ApiResponseResult> Handle(CreatePostCommandRequest request, CancellationToken cancellationToken)
        {
            var api = new ApiResponseResult();

            try
            {
                // create

                //mapping => dto => entity

                var  post =  _mapper.Map<Domain.entity.Post>(request.CreatePostDto);

                await _postRepository.Create(post);
                await _postRepository.SaveAsync();

                api.Success(_mapper.Map<GetPostDto>(post));

            }
            catch (Exception ex)
            {

                api.Error(ex.Message);
            }

            return api;
        }


    }
}
