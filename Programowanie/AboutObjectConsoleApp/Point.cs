namespace AboutObjectConsoleApp;

internal class Point
{
    private int x;
    public int X
    {
        set
        {
            //if (value > 0)
            x = value;
        }
        get
        {
            return x;
        }
    }

    /*
    private int y;
    public int Y
    {
        set
        {
            y = value;
        }
        get
        {
            return y;
        }
    }
    */
    public int Y { get; set; }


    public Point()
    {
        x = 15;
        Y = 68;
    }

    public Point(int a, int b)
    {
        x = a; 
        Y = b;
    }

    public void SetX(int x)
    {
        //if (x > 0)
        this.x = x;
    }

    public int GetX()
    {
        return x;
    }

    public void Show()
    {
        Console.WriteLine($"({x},{Y})");
    }
}
