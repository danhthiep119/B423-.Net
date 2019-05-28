using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bai ptb1 ax+b=0
            /*Console.WriteLine("Chuong trinh giai phuong trinh bac nhat ax+b=0");
            Console.WriteLine("Moi ban nhap a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap b");
            double b = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem.");
                }
                else
                    Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                double tong = -b / a;
                Console.WriteLine("Nghiem phuong trinh {0}x+{1}=0 : {2}",a,b,tong);
            }
            Console.ReadKey();*/

            //Bai ptb2 ax2+bx+c=0
            Console.WriteLine("Chuong trinh giai phuong trinh bac hai ax2+bx+c=0");
            Console.WriteLine("Moi ban nhap a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap c");
            double c = double.Parse(Console.ReadLine());
            double kq,delta,x1,x2;
            kq = 0;
            if(a==0)
            {
                if(b==0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem");
                    }
                    else
                        Console.WriteLine("Phuong trinh vo nghiem");
                }
                else
                {
                    kq = -c / b;
                    Console.WriteLine("phuong trinh co 1 nghiem duy nhat x={0}",kq);
                }
            }
            else
            {
                delta = (b * b) - (4 * a * c);
                if (delta<0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                if(delta==0)
                {
                    kq = -b / (2 * a);
                    Console.WriteLine("Phuong trinh co nghiem kep x={0}",kq);
                }
                if (delta > 0)
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet x1={0} va x2={1}", x1,x2);
                }
            }
            Console.ReadKey();
        }
    }
}
