using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cilindr
{

    private int r, h;

    public int H { get => h; set => h = value; }
    public int R { get => r; set => r = value; }

    public Cilindr()
    {
        this.R = 0;
        this.H = 0;
    }


    public Cilindr(int a, int b)
    {
        R = a;
        H = b;

    }
    public double getCilindr()
    {

        return R * R * 3.14 * H;
    }
    public static Cilindr operator +(Cilindr a, Cilindr b)
    {
        int H = (b.R * b.R * b.H) + (a.R * a.R * a.H);
        int h = 0;
        if (a.R > b.R)
        {
            h = H / (a.R * a.R);
            return new Cilindr(a.R, h);
        }
        else
        {
            h = H / (b.R * b.R);
            return new Cilindr(b.R, h);
        }


    }

    public override string ToString()
    {
        double V = this.R * this.R * this.H * 3.14;

        return String.Format("{0}  {1} {2}", this.R, this.H, V);


    }

    public void PrintLine(Cilindr a)
    {

        Console.WriteLine(a);

    }

}


class Program
{
    static void Main()
    {
        Cilindr c1 = new Cilindr(2, 3);
        Cilindr c2 = new Cilindr();


        c2.R = 3; c2.H = 4;
        Cilindr c3 = new Cilindr();
        c3 = c1 + c2;

        c1.PrintLine(c1);
        c2.PrintLine(c2);
        c3.PrintLine(c3);

    }
}