using System;

namespace davaleba2
{
    class Program
    {
        public static void kvadratuligantoleba(double a, double b, double c)
        {
            double formula = b * b - 4 * a * c;
            double x1, x2;
            if (formula == 0)
            {
                Console.Write("Amoncanas aqvs ertnairi amonaxsni \n");
                x1 = -b / (2 * a);
                x2 = x1;
                Console.Write("Pirveli amonaxsni: \n " + x1);
                Console.Write(" \n Meore amonaxsni: \n" + x2);
            }
            else if (formula > 0)
            {
                Console.Write("amocanas aqvs amonaxsni gasxvavebuli \n");

                x1 = (-b + Math.Sqrt(formula)) / (2 * a);
                x2 = (-b - Math.Sqrt(formula)) / (2 * a);

                Console.Write("Pirveli amonaxsni: \n" + x1);
                Console.Write(" \n Meore amonaxsni: \n" + x2);
            }
            else
                Console.Write("ERROR There is no Root ");

        }

        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Sheiyanet pirveli wevri a:");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sheiyanet pirveli wevri b:");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sheiyanet pirveli wevri c:");
            c = Int32.Parse(Console.ReadLine());
            kvadratuligantoleba(a, b, c);
            Console.ReadKey();
        }
    }
}
