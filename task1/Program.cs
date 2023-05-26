using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.classes;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count=0;
            List<variables> vs = new List<variables>();
            List<ship> ship_nos = new List<ship>();
            List<angle> latitudes = new List<angle>();
            List<angle> longitudes = new List<angle>();
            int option;
            while (true)
            {
                option = menu();
                if (option == 1)
                {

                    vs.Add(add_ship());
                    angle latitude = new angle(vs[count].degrees, vs[count].mins, vs[count].direction);
                    angle longitude = new angle(vs[count].degrees1, vs[count].mins1, vs[count].direction1);
                    ship s = new ship(vs[count].ship_no);
                    latitudes.Add(latitude);
                    longitudes.Add(longitude);
                    ship_nos.Add(s);
                    count++;
                }
                if (option == 2)
                {
                    view_ship(ship_nos, latitudes, longitudes);
                }
                if(option==3)
                {
                    view_ship_no(ship_nos, latitudes, longitudes);
                }
                if(option==4)
                {
                   /* change_ship_position(ship_nos, latitudes, longitudes);*/
                }
                if(option==0)
                {
                    Environment.Exit(0);
                }
            }
        }
        static int menu()
        {
            
                Console.Clear();
                int option;
                Console.WriteLine("1.Add ship");
                Console.WriteLine("2.View ship position");
                Console.WriteLine("3.View ship seriel number");
                Console.WriteLine("4.Change ship position");
                Console.WriteLine("0.Exit");
                return option = int.Parse(Console.ReadLine());
        }
        static variables add_ship()
        {
            variables v = new variables();
            Console.WriteLine("Enter ship no");
            v.ship_no = Console.ReadLine();
            Console.WriteLine("Enter ship latitude:");
            Console.WriteLine("Enter degrees:");
            v.degrees =int.Parse (Console.ReadLine());
            Console.WriteLine("Enter minutes:");
            v.mins = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter ship direction:");
            v.direction =char.Parse( Console.ReadLine());
            Console.WriteLine("Enter ship longitude:");
            Console.WriteLine("Enter degrees:");
            v.degrees1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes:");
            v.mins1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter ship direction:");
            v.direction1 = char.Parse(Console.ReadLine());
            return v;
        }
        static int view_ship(List<ship> ship_nos, List<angle> latitudes, List<angle> longitudes)
        {
            string display;
            angle a = new angle();
            string ship_no;
            Console.WriteLine("Enter the Ship no: ");
            ship_no = Console.ReadLine();
           display= a.display_(ship_no,ship_nos,latitudes);
            if (display == null)
            {
            Console.WriteLine("The Ship does not exist");
                return 0;
            }
            Console.WriteLine("The Ship with the serial no {0} is at: ", ship_no);
            Console.WriteLine("Latitude: {0}", display);
           display= a.display_(ship_no,ship_nos,longitudes);
            Console.WriteLine("Longitude: {0}", display);
            Console.ReadLine();
            return 0;
        }
        static int view_ship_no(List<ship> ship_nos, List<angle> latitudes, List<angle> longitudes)
        {
            variables v = new variables();
            string ship_no;
            angle a = new angle();
            string latitude,longitude;
            Console.WriteLine("Enter the ships latitude: ");
            Console.WriteLine("Enter degrees:");
            v.degrees = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes:");
            v.mins = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter ship direction:");
            v.direction = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ships longitude: ");
            Console.WriteLine("Enter degrees:");
            v.degrees1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes:");
            v.mins1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter ship direction:");
            v.direction1 = char.Parse(Console.ReadLine());
              latitude= v.degrees.ToString() + "\u00b0" + v.mins.ToString() + "'" + v.direction;
            longitude = v.degrees1.ToString() + "\u00b0" + v.mins1.ToString() + "'" + v.direction1;
            ship_no = a.display_no(latitude,longitude,ship_nos, latitudes,longitudes);
            if (ship_no != null)
            {
                Console.WriteLine("The ship's Seriel no: is {0} ", ship_no);
            }
            else
            {
                Console.WriteLine("No such ship exists.");
            }
            Console.ReadKey();

            return 0;
        }
      /*  static int change_ship_position(List<ship> ship_nos, List<angle> latitudes, List<angle> longitudes)*/

    }
}
