
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using(Repository repo = new Repository(@"C:\Users\NAVER-0721\Documents\Visual Studio 2012\Projects\TestConsoleApplication"))
            {
                Commit commit = repo.Lookup<Commit>("bdd786ef2b5fba3a4fba95f6f3805fd30941f6a5");
                Console.WriteLine("Author: {0}", commit.Author.Name);
                Console.WriteLine("Message: {0}", commit.MessageShort);

                /*PushOptions push = new PushOptions
                {
                    Credentials =
                    new UsernamePasswordCredentials
                    {
                        Password = "password",
                        Username = "Username"
                    }
                };
                Remote remote = repo.Network.Remotes["origin"];

                LibGit2Sharp.Signature author = new LibGit2Sharp.Signature("name", "email", DateTime.Now);

                repo.Network.Push(remote, "HEAD", @"refs/heads/master", pushOptions, author, null);*/
            }

            /*var github = new GitHubClient(new ProductHeaderValue("MyAmazingApp"));
            var user = github.User.Get("half-ogre");
            Console.WriteLine("Hello World!");*/
        }
    }
}
