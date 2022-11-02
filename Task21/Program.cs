System.Console.WriteLine("Enter the coordinates of the two points (x1, y1, z1; x2, y2, z2):");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(TwoPointsDistance3D(x1, y1, z1, x2, y2, z2));
 
double TwoPointsDistance3D(int a1, int b1, int c1, int a2, int b2, int c2)
{
    double p1 = Math.Pow((a2 - a1), 2);
    double p2 = Math.Pow((b2 - b1), 2);
    double p3 = Math.Pow((c2 - c1), 2);
    double distance = Math.Sqrt(p1 + p2 + p3);
    return distance;
}