﻿using AutoMapper;
using BlogProject.Application.Contract.Persistence;
using BlogProject.Application.Dto.Post;
using BlogProject.Application.Features.Post.Request.Queries;
using MediatR;

namespace BlogProject.Application.Features.Post.Handler.Queries
{
    public class GetAllPostsQueryRequestHandler(IPostRepository _postRepository, IMapper _mapper) : IRequestHandler<GetAllPostsQueryRequest, ApiResponseResult>
    {

        public async Task<ApiResponseResult> Handle(GetAllPostsQueryRequest request, CancellationToken cancellationToken)
        {
            var api = new ApiResponseResult();

            try
            {

                // get all posts from database 
                var posts = await _postRepository
                                                  .GetAll();

                // auto mapping 
                var result = _mapper
                                 .Map<List<PostDto>>(posts);


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
