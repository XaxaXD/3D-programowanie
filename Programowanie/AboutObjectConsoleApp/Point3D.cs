
namespace AboutObjectConsoleApp;

internal class Point3D : Point
{
    protected int z;

    public Point3D() /*: base()*/
    {
        z = 64;
    }

    public Point3D(int q, int w, int e) : base(q, w)
    {
        //x = q;
        //Y = w;
        z = e;
    }

    public new void Show()
    {
        Console.WriteLine($"({x},{Y},{z})");
        base.Show();
    }
}


class A /*: C*/
{

}

class B : A
{

}

class C : B
{

}