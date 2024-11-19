using System;


class T2D
{
    protected int a11, a12, a13, a21, a22, a23;
    public void SetNumbers(int a11, int a12, int a13, int a21, int a22, int a23)
    {
        this.a11 = a11;
        this.a12 = a12;
        this.a13 = a13;
        this.a21 = a21;
        this.a22 = a22;
        this.a23 = a23;

    }
    public void Print()
    {
        Console.WriteLine("коефiцiенти перетворення: ");
        Console.WriteLine("a11: " + a11 + " a12: " + a12 + " a13: " + a13);
        Console.WriteLine("a21: " + a21 + " a22: " + a22 + " a23: " + a23);
    }
    public void Math(int x, int y)
    {
        int tempx = a11 * x + a12 * y + a13;
        int tempy = a21 * x + a22 * y + a23;
        x = tempx;
        y = tempy;
        Console.WriteLine("\nРезультат:\nx = " + x + "\ny = " + y + "\n");
    }
}
class T3D : T2D
{
    private int a14, a24, a31, a32, a33, a34;
    public void SetNumbers(int a11, int a12, int a13, int a14,
      int a21, int a22, int a23, int a24,
      int a31, int a32, int a33, int a34)
    {

        base.SetNumbers(a11, a12, a13, a21, a22, a23);
        this.a14 = a14;
        this.a24 = a24;
        this.a31 = a31;
        this.a32 = a32;
        this.a33 = a33;
        this.a34 = a34;

    }
    public void Print()
    {
        Console.WriteLine("коефiцiенти перетворення: ");
        Console.WriteLine("a11: " + a11 + " a12: " + a12 + " a13: " + a13 + " a14: " + a14);
        Console.WriteLine("a21: " + a21 + " a22: " + a22 + " a23: " + a23 + " a24: " + a24);
        Console.WriteLine("a31: " + a31 + " a32: " + a32 + " a33: " + a33 + " a34: " + a34);
    }
    public void Math(int x, int y, int z)
    {
        int tempx = a11 * x + a12 * y + a13 * z + a14;
        int tempy = a21 * x + a22 * y + a23 * z + a24;
        int tempz = a31 * x + a32 * y + a33 * z + a34;
        x = tempx;
        y = tempy;
        z = tempz;
        Console.WriteLine("\nРезультат:\nx = " + x + "\ny = " + y + "\nz = " + z);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введiть значення x та y для 2д: ");
        string textX = Console.ReadLine();
        string textY = Console.ReadLine();

        int x1;
        int y1;
        if (int.TryParse(textX, out x1) && int.TryParse(textY, out y1))
        {
            T2D t2D = new T2D();
            t2D.SetNumbers(1, 2, 3, 4, 5, 6);
            t2D.Print();
            t2D.Math(x1, y1);
            Console.WriteLine();


        }
        else
        {
            Console.WriteLine("помилка вводу");
            Console.ReadLine();
        }

        Console.WriteLine("Введiть значення x, y та z для 3д: ");
        string textX2 = Console.ReadLine();
        string textY2 = Console.ReadLine();
        string textZ2 = Console.ReadLine();

        int x2;
        int y2;
        int z2;
        if (int.TryParse(textX2, out x2) && int.TryParse(textY2, out y2) && int.TryParse(textZ2, out z2))
        {
            T3D t3D = new T3D();
            t3D.SetNumbers(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
            t3D.Print();
            t3D.Math(x2, y2, z2);

        }
        else
        {
            Console.WriteLine("помилка вводу");
            Console.ReadLine();
        }


    }
}