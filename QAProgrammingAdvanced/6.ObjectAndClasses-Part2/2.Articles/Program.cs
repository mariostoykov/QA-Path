
public class Article
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public void Edit(string newContent)
    {
        Content = newContent;
    }

    public void ChangeAuthor(string newAuthor)
    {
        Author = newAuthor;
    }

    public void Rename(string newContent)
    {
        Title = newContent;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}

public class Program
{
    public static void Main()
    {
        string[] articleData = Console.ReadLine().Split(", ");
        string title = articleData[0];
        string content = articleData[1];
        string author = articleData[2];

        Article article = new Article(title, content, author);

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] commandParts = Console.ReadLine().Split(": ", 2);
            string command = commandParts[0];
            string argument = commandParts[1];

            switch (command)
            {
                case "Edit":
                    article.Edit(argument);
                    break;
                case "ChangeAuthor":
                    article.ChangeAuthor(argument);
                    break;
                case "Rename":
                    article.Rename(argument);
                    break;
            }
        }

        Console.WriteLine(article);
    }
}