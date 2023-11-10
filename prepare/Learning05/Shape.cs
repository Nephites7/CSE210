
public class Shape
{
    private string color;

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public Shape(string color)
    {
        this.color = color;
    }

    public virtual float GetArea()
    {
        return 0; // Placeholder, to be overridden by derived classes
    }
}
