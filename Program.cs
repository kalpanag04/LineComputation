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
        double length = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
        Console.WriteLine("Length of Line:"+length);
    }
    
}
