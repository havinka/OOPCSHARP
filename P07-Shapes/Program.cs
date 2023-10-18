namespace P07_Shapes;
public class Program
{
    static void Main(string[] args)
    {
        IDrawable s1 = new Rectangle() { Width = 5, Height = 5 };
        IDrawable s2 = new Rectangle() { Width = 3, Height = 6 };
        IDrawable s3 = new Cicle() { Radius = 3};
        IDrawable s4 = new Cicle() { Radius = 5 };

        List<IDrawable> s = new List<IDrawable>() { s1, s2, s3, s4 };

        foreach (var shape in s)
        {
            shape.Draw();
        }

    }
}

