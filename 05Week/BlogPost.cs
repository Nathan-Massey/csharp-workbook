using System;

public class Program
{
	public static void Main()
	{
        // Create a blog using one of the constructors
        Blog myBlog = new Blog("I am learning C#");

        myBlog.Description = "This is the content of the blog.";
        myBlog.Created = DateTime.Now;

        // Voting
        myBlog.IncrementDownvote();
        myBlog.IncrementUpvote();
        myBlog.IncrementUpvote();

        Console.WriteLine(myBlog.Title);
        Console.WriteLine(myBlog.Description);
        Console.WriteLine(myBlog.CreatedOn);

        Console.WriteLine(myBlog.Upvote);
        Console.WriteLine(myBlog.Downvote);
        Console.ReadLine();

	}
}

public class Blog
{
    // Field
    public string Title;
    public string Description;
    public DateTime Created;

    // Non public fields
    // Avoid having them set to 0
    private int _upvote;
    private int _downvote;

    // Constructor
    // Blog myBlog = new Blog();
    public Blog()
    {
        _upvote = 0;
        _downvote = 0;
    }

    // Constructor overload
    public Blog(string title)
    {
        Title = title;
    }

    // Properties
    public string Upvote
    {
        get
        {
            return "Number of upvotes: " + _upvote;
        }
    }

    public string Downvote
    {
        get
        {
            return "Number of downvotes: " +  _downvote;
        }
    }

    public string CreatedOn
    {
        get
        {
            return "Created on " + string.Format("{0:MM/dd/yy}", Created);
        }
    }
    
    // Methods
    public void IncrementUpvote()
    {
        _upvote++;
    }

    public void IncrementDownvote()
    {
        _downvote++;
    }
}