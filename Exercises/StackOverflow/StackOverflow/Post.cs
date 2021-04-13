using System;
using System.Collections.Generic;

namespace StackOverflow
{
    public class Post
    {
        public int VoteCount { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime DateTimeCreated { get; } = DateTime.Now;


        public Post(string title, string desc)
        {
            Title = title;
            Description = desc;
        }


        public void UpVote()
        {
            if (VoteCount >= 0)
                VoteCount += 1;
        }

        public void DownVote()
        {
            if (VoteCount >= 1)
                VoteCount -= 1;
        }

    }
}
