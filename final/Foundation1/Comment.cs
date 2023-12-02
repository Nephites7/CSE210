public class UserComment
{
    private string commenter;
    private string commentText;

    public UserComment(string commenter, string commentText)
    {
        this.commenter = commenter;
        this.commentText = commentText;
    }

    public string Commenter => commenter;
    public string CommentText => commentText;
}
