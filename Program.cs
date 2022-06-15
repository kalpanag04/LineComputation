class LineComputation
{
    static void Main(string[] args)
    {
        String a1, a2, b1, b2;
        Console.WriteLine("enter a value for a1 : ");
        a1 = Console.ReadLine();
        Console.WriteLine("enter a value for a2 : ");
        a2 = Console.ReadLine();
        Console.WriteLine("enter a value for b1 : ");
        b1 = Console.ReadLine();
        Console.WriteLine("enter a value for b2 : ");
        b2 = Console.ReadLine();

        int x1 = Int32.Parse(a1);
        int x2 = Int32.Parse(a2);
        int y1 = Int32.Parse(b1);
        int y2 = Int32.Parse(b2);

        Console.WriteLine("x1:" + a1 + "  x2:" + a2 + "  y1:" + b1 + "  y2:" + b2);
        double lenone = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
        Console.WriteLine("Length of Line:"+lenone);

        String a3, a4, b3, b4;
        Console.WriteLine("enter a value for a3 : ");
        a3 = Console.ReadLine();
        Console.WriteLine("enter a value for a4 : ");
        a4 = Console.ReadLine();
        Console.WriteLine("enter a value for b3 : ");
        b3 = Console.ReadLine();
        Console.WriteLine("enter a value for b4 : ");
        b4 = Console.ReadLine();

        int x3 = Int32.Parse(a3);
        int x4 = Int32.Parse(a4);
        int y3 = Int32.Parse(b3);
        int y4 = Int32.Parse(b4);

        Console.WriteLine("x3:" + a3 + "  x4:" + a4 + "  y3:" + b4 + "  y4:" + b4);
        double lenTwo = Math.Sqrt((Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2)));
        Console.WriteLine("Length of Line:" + lenTwo);

        if(lenone.Equals(lenTwo))
        {
            Console.WriteLine("Two Lines are equal");
        }
        else
        {
            Console.WriteLine("Two Lines are not equal");
        }
    }   
}
