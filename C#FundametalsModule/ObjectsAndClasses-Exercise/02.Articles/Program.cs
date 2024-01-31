using System;
using System.Linq;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            //{title}, {content}, {author}
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Article article = new Article(input[0], input[1], input[2]);

            int numCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCommands; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (commands[0])
                {
                    case "Edit":
                        article.Edit(commands[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(commands[1]);
                        break;
                    case "Rename":
                        article.Rename(commands[1]);
                        break;
                }
            }

            Console.WriteLine(article.ToString());
        }

        //public class Article
        //{
        //    public string Title { get; set; }
        //    public string Content { get; set; }
        //    public string Author { get; set; }

        //    public Article(string title, string content, string author)
        //    {
        //        this.Title = title;
        //        this.Content = content;
        //        this.Author = author;
        //    }

        //    public void Edit(string content)
        //    {
        //        this.Content = content;
        //    }

        //    public void ChangeAuthor(string author)
        //    {
        //        this.Author = author;
        //    }

        //    public void Rename(string title)
        //    {
        //        this.Title = title;
        //    }

        //    public override string ToString()
        //    {
        //        return $"{Title} - {Content}: {Author}";
        //    }
        //}
    }
}
