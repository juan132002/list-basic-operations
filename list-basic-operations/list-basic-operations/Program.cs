using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_basic_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List courtlist = new List();


            CourtRental c1 = new CourtRental();
            c1.Cost = 80000;
            c1.Time = 1700;
            c1.Type = "futbol 10";
            courtlist.Add(c1);

            CourtRental c2 = new CourtRental();
            c2.Cost = 50000;
            c2.Time = 1400;
            c2.Type = "futbol 11";
            courtlist.Add(c2);

            CourtRental c3 = new CourtRental();
            c3.Cost = 10000;
            c3.Time = 1100;
            c3.Type = "futbol 10 (Nuevo)";
            courtlist.Add(c3);


            CourtRental c4 = new CourtRental();
            c4.Cost = 90000;
            c4.Time = 800;
            c4.Type = "futbol 5";
            courtlist.Add(c4);

            CourtRental c5 = new CourtRental();
            c5.Cost = 20000;
            c5.Time = 1200;
            c5.Type = "futbol 11";
            courtlist.Add(c5);

            CourtRental c6 = new CourtRental();
            c6.Cost = 5000;
            c6.Time = 900;
            c6.Type = "futbol 11";
            courtlist.Add(c6);



            courtlist.Print();

            Console.ReadKey();
        }
    }
}
