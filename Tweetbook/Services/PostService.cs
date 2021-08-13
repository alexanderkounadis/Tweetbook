using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetbook.Data;
using Tweetbook.Domain;

namespace Tweetbook.Services
{
    public class PostService : IPostService
    {
        private readonly DataContext _ctx;

        public PostService(DataContext ctx)
        {
            _ctx = ctx;
        }
       
        public async Task<List<Post>> GetPostsAsync()
        {
            return await _ctx.Posts.ToListAsync();
        }

        public async Task<bool> CreatePostAsync(Post post)
        {
            await _ctx.Posts.AddAsync(post);
            return await _ctx.SaveChangesAsync() > 0;
        }

        public async Task<Post> GetPostByIdAsync(Guid postId)
        {
            return await _ctx.Posts.SingleOrDefaultAsync<Post>(p => p.Id == postId);
        }

        public async Task<bool> UpdatePostAsync(Post postToUpdate)
        {

           _ctx.Posts.Update(postToUpdate);
            var updated = await _ctx.SaveChangesAsync();
            return updated > 0;
        }

        public async Task<bool> DeletePostAsync(Guid postId)
        {
            var post = await GetPostByIdAsync(postId);
            if (post == null) return false;
            _ctx.Posts.Remove(post);
            return await _ctx.SaveChangesAsync() > 0;
        }
    }
}
