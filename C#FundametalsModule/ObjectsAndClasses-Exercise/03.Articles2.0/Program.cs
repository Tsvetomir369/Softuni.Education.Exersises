﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Article> articles = new List<Article>();
            int numOfArticles = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfArticles; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Article article = new Article(input[0], input[1], input[2]);
                articles.Add(article);
            }

            string sortedBy = Console.ReadLine();

            switch (sortedBy)
            {
                case "title":
                    articles = articles.OrderBy(x => x.Title).ToList();
                    break;
                case "content":
                    articles = articles.OrderBy(x => x.Content).ToList();
                    break;
                case "author":
                    articles = articles.OrderBy(x => x.Author).ToList();
                    break;
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
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

        //    public override string ToString()
        //    {
        //        return $"{Title} - {Content}: {Author}";
        //    }
        //}
    }
}
