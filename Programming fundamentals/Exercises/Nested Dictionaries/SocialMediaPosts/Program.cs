using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPosts
{
    class Program
    {
        // They are here because we want to use them in methods. 
        // If they are not here we should call them every time when we want to use them again.

        static Dictionary<string, Dictionary<string, string>> postsComments =
            new Dictionary<string, Dictionary<string, string>>();

        static Dictionary<string, int> postLikes =
            new Dictionary<string, int>();

        static Dictionary<string, int> postDislikes =
            new Dictionary<string, int>();

        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "drop the media")
            {
                string[] inputTokens =  input.Split(' ');

                string command = inputTokens[0];
                string postName = inputTokens[1];

                switch (command)
                {
                    case "post":
                    {
                        CreatePost(postName);
                        break;
                    }
                    case "like":
                    {
                        LikePost(postName);
                        break;
                    }
                    case "dislike":
                    {
                        DislikePost(postName);
                        break;
                    }
                    case "comment":
                    {
                        string commentatorName = inputTokens[2];
                        string commentContent = string.Join(" ", inputTokens.Skip(3));

                        CommentPost(postName, commentatorName, commentContent);
                        break;
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var postCommentData in postsComments)
            {
                string postName = postCommentData.Key;
                int likes = postLikes[postName];
                int dislikes = postDislikes[postName];
                Dictionary<string, string> commentsData = postCommentData.Value;

                Console.WriteLine($"Post: {postName} | Likes: {likes} | Dislikes: {dislikes}");

                Console.WriteLine("Comments:");
                if (commentsData.Count == 0)
                {
                    Console.WriteLine("None");
                }

                foreach (var commentData in commentsData)
                {
                    string commentatorName = commentData.Key;
                    string commentContent = commentData.Value;

                    Console.WriteLine($"*  {commentatorName}: {commentContent}");
                }
            }
        }

        static void CreatePost(string postName)
        {
            postsComments.Add(postName, new Dictionary<string, string>());
            postLikes.Add(postName, 0);
            postDislikes.Add(postName, 0);
        }

        static void LikePost(string postName)
        {
            postLikes[postName]++;
        }

        static void DislikePost(string postName)
        {
            postDislikes[postName]++;
        }

        static void CommentPost(string postName, string commentatorName, string commentContent)
        {
            postsComments[postName].Add(commentatorName, commentContent);
        }
    }
}