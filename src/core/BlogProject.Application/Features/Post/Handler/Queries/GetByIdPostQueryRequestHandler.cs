using AutoMapper;
using BlogProject.Application.Contract.Persistence;
using BlogProject.Application.Dto.Post;
using BlogProject.Application.Features.Post.Request.Queries;
using BlogProject.Infrastructure.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Application.Features.Post.Handler.Queries
{
    public class GetByIdPostQueryRequestHandler : IRequestHandler<GetByIdPostQueryRequest, ApiResponseResult>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public GetByIdPostQueryRequestHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }



        public async Task<ApiResponseResult> Handle(GetByIdPostQueryRequest request, CancellationToken cancellationToken)
        {
            var api = new ApiResponseResult();
            try
            {
                var post = await _postRepository.FirstOrDefualt(a=>a.Id == request.PostId , Joins.PostTags , Joins.Category);

                if (post == null)
                    throw new Exception($"پست مورد نظر  شناسه {request.PostId} یافت نشد");

                post.ViewCount += 1;
                // update post
                await _postRepository.Update(post);
                await _postRepository.SaveAsync();

                var result =  _mapper.Map<GetPostDto>(post);

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
