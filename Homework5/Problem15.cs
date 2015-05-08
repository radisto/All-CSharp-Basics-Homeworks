using System;

class Triangle
{
    static void Main()
    {
        int ax = int.Parse(Console.ReadLine());
		int ay = int.Parse(Console.ReadLine());
		int bx = int.Parse(Console.ReadLine());
		int by = int.Parse(Console.ReadLine());
		int cx = int.Parse(Console.ReadLine());
		int cy = int.Parse(Console.ReadLine());
		double ccx = (ax > bx) ? ax-bx : bx-ax;
		double ccy = (ay > by) ? ay-by : by-ay;
		double c = Math.Sqrt(ccx*ccx + ccy*ccy);
		double aax = (bx > cx) ? bx-cx : cx-bx;
		double aay = (by > cy) ? by-cy : cy-by;
		double a = Math.Sqrt(aax*aax + aay*aay);
		double bbx = (ax > cx) ? ax-cx : cx-ax;
		double bby = (ay > cy) ? ay-cy : cy-ay;
		double b = Math.Sqrt(bbx*bbx + bby*bby);
		double p = (a+b+c)/2;
		double s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        if (s == 0)
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:0.00}", c);
        }
        else
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0:0.00}", s);
        }
    }
}
