using System;

namespace StackOverflow
{

class Program
    {
        static void Main(string [] args)
        {
            // Create new post.
            var post = new Post("First Post", "First Description");

            // Cast votes.
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();

            // Display post.
            Console.WriteLine($"{post.Title} - {post.Description} (Posted: {post.DateTimeCreated})\nTotal Votes: {post.VoteCount}");
        }
    }
}
