using AutoMapper;
using BlogProject.Application.Contract.Persistence;
using BlogProject.Application.Dto.Post;
using BlogProject.Application.Features.Post.Request.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Application.Features.Post.Handler.Commands
{
    public class UpdatePostCommandRequestHandler : IRequestHandler<UpdatePostCommandRequest, ApiResponseResult>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public UpdatePostCommandRequestHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }


        public async Task<ApiResponseResult> Handle(UpdatePostCommandRequest request, CancellationToken cancellationToken)
        {
            var api = new ApiResponseResult();

            try
            {
                var updateblePost = _mapper.Map<Domain.entity.Post>(request.UpdatePostDto);

                await _postRepository.Update(updateblePost);
                await _postRepository.SaveAsync();

                var result = _mapper.Map<GetPostDto>(updateblePost);

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
