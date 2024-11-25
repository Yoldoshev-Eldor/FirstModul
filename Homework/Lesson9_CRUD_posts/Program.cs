using Lesson9_CRUD_posts.Models;
using Lesson9_CRUD_posts.Services;

namespace Lesson9_CRUD_posts
{
    public class Program
    {
        static void Main(string[] args)
        {
           StartFrontEndEvent();
        }
        public static void StartFrontEndPost()
        {
            var postService = new PostService();
            while (true)
            {
                Console.WriteLine("1. Add Post : ");
                Console.WriteLine("2. Update Post:");
                Console.WriteLine("3. Delete Post :");
                Console.WriteLine("4. Get all Post: ");
                Console.WriteLine("5. Get by Id Post: ");
                Console.WriteLine("6. Get Most Viewed Post: ");
                Console.WriteLine("7. Get Most Liked Post: ");
                Console.WriteLine("8. Get Most Comment Post: ");
                Console.Write("Choose ===> : ");
                var option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    var post = new Post();
                    Console.Write("Enter Owner name :");
                    post.OwnerName = Console.ReadLine();
                    Console.Write("Enter Desrtiption : ");
                    post.Description = Console.ReadLine();
                    Console.Write("Enter Type : ");
                    post.Type = Console.ReadLine();
                    Console.Write("Enter Post likes count :");
                    post.QuantityLikes = int.Parse(Console.ReadLine());
                    post.PostedTime = DateTime.Now;
                    Console.Write("enter post comment count ");
                    var countComments = int.Parse(Console.ReadLine());
                    for (var i = 0; i < countComments; ++i)
                    {
                        Console.Write($"Enter {i + 1}-comment :");
                        var comment = Console.ReadLine();
                        post.Comments.Add(comment);
                    }
                    Console.Write("Enter Viewer name count : ");
                    var countViewer = int.Parse(Console.ReadLine());
                    for (var i = 0; i < countViewer; ++i)
                    {
                        Console.Write($"Enter {i + 1}-Viewer :");
                        var viewer = Console.ReadLine();
                        post.ViewerNames.Add(viewer);
                    }
                    postService.AddPost(post);
                    Console.WriteLine("Post added . . . ");
                }
                else if (option == 2)
                {
                    var post = new Post();
                    Console.WriteLine("Enter Guid ID : ");
                    post.Id = Guid.Parse(Console.ReadLine());
                    Console.Write("Enter Owner name :");
                    post.OwnerName = Console.ReadLine();
                    Console.Write("Enter Desrtiption : ");
                    post.Description = Console.ReadLine();
                    Console.Write("Enter Type : ");
                    post.Type = Console.ReadLine();
                    Console.Write("Enter Post likes count :");
                    post.QuantityLikes = int.Parse(Console.ReadLine());
                    post.PostedTime = DateTime.Now;
                    Console.Write("enter post comment count ");
                    var countComments = int.Parse(Console.ReadLine());
                    for (var i = 0; i < countComments; ++i)
                    {
                        Console.Write($"Enter {i + 1}-comment :");
                        var comment = Console.ReadLine();
                        post.Comments.Add(comment);
                    }
                    Console.Write("Enter Viewer name count : ");
                    var countViewer = int.Parse(Console.ReadLine());
                    for (var i = 0; i < countViewer; ++i)
                    {
                        Console.Write($"Enter {i + 1}-Viewer :");
                        var viewer = Console.ReadLine();
                        post.ViewerNames.Add(viewer);
                    }
                    var boolResult = postService.UpdatePost(post);
                    if (boolResult)
                    {
                        Console.WriteLine("Succesfull . . . ");
                    }
                    else
                    {
                        Console.WriteLine("ERROR . . . ");
                    }
                }
                else if (option == 3)
                {
                    Console.Write("Enter ID  : ");
                    var deletePostId = Guid.Parse(Console.ReadLine());
                    var result = postService.DeletePost(deletePostId);
                    if (result)
                    {
                        Console.WriteLine("Delete Post Succsesfull . . . ");
                    }
                    else
                    {
                        Console.WriteLine("Error . . . ");
                    }
                }
                else if (option == 4)
                {
                    var allPosts = postService.GetAllPost();
                    for (var i = 0; i < allPosts.Count; ++i)
                    {
                        foreach (var post in allPosts)
                        {
                            Console.WriteLine($"ID :         {post.Id}");
                            Console.WriteLine($"Owner Name : {post.OwnerName}");
                            Console.WriteLine($"Description : {post.Description}");
                            Console.WriteLine($"Type : {post.Type}");
                            Console.WriteLine($"Posted Time :{post.PostedTime}");
                            Console.WriteLine($"Quantity Likes :{post.QuantityLikes}");
                        }
                    }
                }
                else if (option == 5)
                {
                    Console.Write("Enter Id post : ");
                    var idPost = Guid.Parse(Console.ReadLine());
                    var post = postService.GetById(idPost);
                    if (post != null)
                    {
                        Console.WriteLine($"ID :         {post.Id}");
                        Console.WriteLine($"Owner Name : {post.OwnerName}");
                        Console.WriteLine($"Description : {post.Description}");
                        Console.WriteLine($"Type : {post.Type}");
                        Console.WriteLine($"Posted Time :{post.PostedTime}");
                        Console.WriteLine($"Quantity Likes :{post.QuantityLikes}");
                        Console.WriteLine($"omments ");
                        foreach (var comment in post.Comments)
                        {
                            Console.Write($"{comment} , ");
                        }
                        Console.Write($"viewer post : ");
                        foreach (var viewer in post.ViewerNames)
                        {
                            Console.Write($"{viewer} , ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("error . . . ");
                    }
                }
                else if (option == 6)
                {
                    var post = postService.GetMostViewedPost();
                    Console.WriteLine($"ID :         {post.Id}");
                    Console.WriteLine($"Owner Name : {post.OwnerName}");
                    Console.WriteLine($"Description : {post.Description}");
                    Console.WriteLine($"Type : {post.Type}");
                    Console.WriteLine($"Posted Time :{post.PostedTime}");
                    Console.WriteLine($"Quantity Likes :{post.QuantityLikes}");
                    Console.WriteLine($"omments ");
                    foreach (var comment in post.Comments)
                    {
                        Console.Write($"{comment} , ");
                    }
                    Console.Write($"viewer post : ");
                    foreach (var viewer in post.ViewerNames)
                    {
                        Console.Write($"{viewer} , ");
                    }

                }
                else if (option == 7)
                {
                    var post = postService.GetMostLikedPost();
                    Console.WriteLine($"ID :         {post.Id}");
                    Console.WriteLine($"Owner Name : {post.OwnerName}");
                    Console.WriteLine($"Description : {post.Description}");
                    Console.WriteLine($"Type : {post.Type}");
                    Console.WriteLine($"Posted Time :{post.PostedTime}");
                    Console.WriteLine($"Quantity Likes :{post.QuantityLikes}");
                    Console.WriteLine($"omments ");
                    foreach (var comment in post.Comments)
                    {
                        Console.Write($"{comment} , ");
                    }
                    Console.Write($"viewer post : ");
                    foreach (var viewer in post.ViewerNames)
                    {
                        Console.Write($"{viewer} , ");
                    }
                }
                else if (option == 8)
                {
                    var post = postService.GetMostCommentedPost();
                    Console.WriteLine($"ID :         {post.Id}");
                    Console.WriteLine($"Owner Name : {post.OwnerName}");
                    Console.WriteLine($"Description : {post.Description}");
                    Console.WriteLine($"Type : {post.Type}");
                    Console.WriteLine($"Posted Time :{post.PostedTime}");
                    Console.WriteLine($"Quantity Likes :{post.QuantityLikes}");
                    Console.WriteLine($"omments ");
                    foreach (var comment in post.Comments)
                    {
                        Console.Write($"{comment} , ");
                    }
                    Console.Write($"viewer post : ");
                    foreach (var viewer in post.ViewerNames)
                    {
                        Console.Write($"{viewer} , ");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void StartFrontEndEvent()
        {
            var eventService = new EventService();
            while (true)
            {
                Console.WriteLine("1. Add Event : ");
                Console.WriteLine("2. Update Event : ");
                Console.WriteLine("3. Delete event : ");
                Console.WriteLine("4. Get all Eventc: ");
                Console.WriteLine("5. Get one Event :");
                Console.WriteLine("6. Get events by location :");
                Console.WriteLine("7. Get max tagged Event :");
                Console.WriteLine("8. Add person to Event : ");
                Console.Write("Choose --> : ");
                var choose = int.Parse(Console.ReadLine());

                if (choose == 1)
                {
                    var evenT = new Event();
                    Console.Write("Enter Title :");
                    evenT.Title = Console.ReadLine();
                    Console.Write("Enter Location : ");
                    evenT.Location = Console.ReadLine();
                    evenT.DateTime = DateTime.Now;
                    Console.Write("Enter Discription : ");
                    evenT.Discription = Console.ReadLine();
                    Console.Write("ENter Attends count : ");
                    var countAttends = int.Parse(Console.ReadLine());
                    for (var i = 0; i < countAttends; ++i)
                    {
                        Console.Write($"Enter {i + 1} - Attend :");
                        var attend = Console.ReadLine();
                        evenT.Attends.Add(attend);
                    }
                    Console.Write("Enter Tags count : ");
                    var countTags = int.Parse(Console.ReadLine());
                    for (var i = 0; i < countTags; ++i)
                    {
                        Console.Write($"Enter {i + 1} - Tag :");
                        var tag = Console.ReadLine();
                        evenT.Tags.Add(tag);
                    }
                    eventService.AddEvent(evenT);
                    Console.WriteLine("Event Added . . . ");
                }
                else if (choose == 2)
                {
                    var evenT = new Event();
                    Console.Write("Enter Id : ");
                    evenT.Id = Guid.Parse(Console.ReadLine());
                    Console.Write("Enter Title :");
                    evenT.Title = Console.ReadLine();
                    Console.Write("Enter Location : ");
                    evenT.Location = Console.ReadLine();
                    evenT.DateTime = DateTime.Now;
                    Console.Write("Enter Discription : ");
                    evenT.Discription = Console.ReadLine();
                    Console.Write("ENter Attends count : ");
                    var countAttends = int.Parse(Console.ReadLine());
                    for (var i = 0; i < countAttends; ++i)
                    {
                        Console.Write($"Enter {i + 1} - Attend :");
                        var attend = Console.ReadLine();
                        evenT.Attends.Add(attend);
                    }
                    Console.Write("Enter Tags count : ");
                    var countTags = int.Parse(Console.ReadLine());
                    for (var i = 0; i < countTags; ++i)
                    {
                        Console.Write($"Enter {i + 1} - Tag :");
                        var tag = Console.ReadLine();
                        evenT.Tags.Add(tag);
                    }
                    var result = eventService.UpdateEvent(evenT);
                    if (result)
                    {
                        Console.WriteLine("Updated . . . ");
                    }
                    else
                    {
                        Console.WriteLine("Eror . . . ");
                    }
                }
                else if (choose == 3)
                {
                    Console.Write("Enter Delete event Id");
                    var id = Guid.Parse(Console.ReadLine());
                    var result = eventService.DeleteEvent(id);
                    if (result)
                    {
                        Console.WriteLine("Deleted . . . ");
                    }
                    else
                    {
                        Console.WriteLine("Eror . . . ");
                    }
                }
                else if (choose == 4)
                {
                    var eventAll = eventService.GetAllEvent();
                    foreach (var eventt in eventAll)
                    {
                        Console.WriteLine($"ID  :          {eventt.Id}");
                        Console.WriteLine($"Title  :       {eventt.Title}");
                        Console.WriteLine($"Location  :    {eventt.Location}");
                        Console.WriteLine($"Date Time  :   {eventt.DateTime}");
                        Console.WriteLine($"Diccription  : {eventt.Discription}");

                    }
                }
                else if (choose == 5)
                {
                    Console.Write("Enter id : ");
                    var id = Guid.Parse(Console.ReadLine());
                    var eventt = eventService.GetById(id);
                    if (eventt != null)
                    {
                        Console.WriteLine($"ID :          {eventt.Id}");
                        Console.WriteLine($"Title :       {eventt.Title}");
                        Console.WriteLine($"Location :    {eventt.Location}");
                        Console.WriteLine($"Date Time :   {eventt.DateTime}");
                        Console.WriteLine($"Diccription : {eventt.Discription}");
                        foreach (var attend in eventt.Attends)
                        {
                            Console.Write($"{attend} , ");
                        }
                        foreach (var tag in eventt.Tags)
                        {
                            Console.Write($"{tag} , ");
                        }
                    }

                }
                else if (choose == 6)
                {
                    Console.Write("Enter location >> ");
                    var eventLocation = Console.ReadLine();
                    var allEventsList = eventService.GetEventsByLocation(eventLocation);
                    foreach(var evenT in allEventsList)
                    {
                        Console.WriteLine($"ID :          {evenT.Id}");
                        Console.WriteLine($"Title :       {evenT.Title}");
                        Console.WriteLine($"Location :    {evenT.Location}");
                        Console.WriteLine($"Discription : {evenT.DateTime}");
                    }
                    
                }
                else if (choose == 7)
                {
                    Console.WriteLine("The event id with the most tags : ");
                    var id = eventService.GetMaxTaggedEvent();
                    Console.WriteLine(id);
                }
                else if (choose == 8)
                {
                    Console.Write("Enter Id : ");
                    var id = Guid.Parse(Console.ReadLine());
                    var eventt = eventService.GetById(id);
                    Console.Write("Enter add person name :");
                    var name = Console.ReadLine();
                    eventt.Attends.Add(name);
                }
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
