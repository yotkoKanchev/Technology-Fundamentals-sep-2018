﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Galin
{
    class Program
    {
        static void Main(string[] args)
        {
            int articleCount = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < articleCount; i++)
            {
                string[] splitedInput = Console.ReadLine()
                    .Split(", ");

                string title = splitedInput[0];
                string content = splitedInput[1];
                string author = splitedInput[2];

                Article article = new Article(title, content, author);

                articles.Add(article);
            }

            string orderBy = Console.ReadLine();

            if (orderBy == "title")
            {
                articles = articles
                    .OrderBy(x => x.Title)
                    .ToList();
            }
            else if (orderBy == "content")
            {
                articles = articles
                   .OrderBy(x => x.Content)
                   .ToList();
            }
            else if (orderBy == "author")
            {
                articles = articles
                   .OrderBy(x => x.Author)
                   .ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine,articles));
        }
        class Article
        {

            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
