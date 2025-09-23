

using AboutObjectConsoleApp;

Point firstPoint = new Point();
//firstPoint.x = 458;

firstPoint.Show();

Point secondPoint = new Point(4, 87);
secondPoint.Show();

Point thirdPoint = new(5, 68);

firstPoint.SetX(47);
//firstPoint.x = 47;
firstPoint.X = 47;
int a;
a = firstPoint.GetX();
//a = firstPoint.x;
a = firstPoint.X;
firstPoint.Show();

Point3D point4 = new Point3D();
point4.Show();