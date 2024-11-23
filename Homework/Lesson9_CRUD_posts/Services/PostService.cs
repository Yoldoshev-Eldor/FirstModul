using Lesson9_CRUD_posts.Models;

namespace Lesson9_CRUD_posts.Services;

internal class PostService
{
    private List<Post> posts;
    public PostService()
    {
        var posts = new List<Post>();
    }
    public Post AddPost(Post addingPost)
    {
        addingPost.Id = Guid.NewGuid();
        posts.Add(addingPost);
        return addingPost;
    }
    public bool DeletePost(Guid postId)
    {
        bool exists = false;
        foreach (var post in posts)
        {
            if (post.Id == postId)
            {
                posts.Remove(post);
                exists = true;
                break;
            }
        }
        return exists;
    }
    public bool UpdatePost(Post updatePost)
    {
        bool exists = false;
        for (var i = 0; i < posts.Count; i++)
        {
            if (posts[i].Id == updatePost.Id)
            {
                posts[i] = updatePost;
                exists = true;
                break;
            }
        }
        return exists;
    }
    public List<Post> GetAllPost()
    {
        return posts;
    }
    public Post GetMostViewedPost()
    {
        var mostViewes = 0;
        foreach (var post in posts)
        {
            if (post.ViewerNames.Count > mostViewes)
            {
                mostViewes = post.ViewerNames.Count;
            }
        }
        var responsePost = new Post();

        foreach (var post in posts)
        {
            if (post.ViewerNames.Count == mostViewes)
            {
                responsePost = post;
                break;
            }
        }
        return responsePost;
    }

    public Post GetMostLikedPost()
    {
        var mostLikedPost = 0;
        foreach (var post in posts)
        {
            if (post.QuantityLikes > mostLikedPost)
            {
                mostLikedPost = post.ViewerNames.Count;
            }
        }
        var responsePost = new Post();

        foreach (var post in posts)
        {
            if (post.QuantityLikes == mostLikedPost)
            {
                responsePost = post;
                break;
            }
        }
        return responsePost;
    }


    public Post GetMostCommentedPost()
    {
        var mostCommentCount = 0;
        foreach (var post in posts)
        {
            if (post.Comments.Count > mostCommentCount)
            {
                mostCommentCount = post.Comments.Count;
            }
        }
        var responsePost = new Post();

        foreach (var post in posts)
        {
            if (post.Comments.Count == mostCommentCount)
            {
                responsePost = post;
                break;
            }
        }
        return responsePost;
    }

    public List<Post> GetPostsByComment(string comment)
    {
        var responseComments = new List<Post>();
        
        foreach(var post in posts)
        {
            if(post.Comments.Contains(comment) is true)
            {
                responseComments.Add(post);
            }
        }


        return responseComments;
    }

}
