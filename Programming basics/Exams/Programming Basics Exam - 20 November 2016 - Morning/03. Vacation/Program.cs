using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var adults = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var night = int.Parse(Console.ReadLine());
            var typeOfTransport = Console.ReadLine();

            var adultsPrice = 0.00;
            var studentsPrice = 0.00;
            var allGroup = adults + students;
            var priceAllGroupNight = 82.99;

            if (typeOfTransport == "train" && allGroup >= 50)
            {
                adultsPrice = 24.99 * 0.5;
                studentsPrice = 14.99 * 0.5;
            } 
            else if (typeOfTransport == "train")
            {
                adultsPrice = 24.99;
                studentsPrice = 14.99;
            }
            else if (typeOfTransport == "bus")
            {
                adultsPrice = 32.5;
                studentsPrice = 28.5;
            }
            else if (typeOfTransport == "boat")
            {
                adultsPrice = 42.99;
                studentsPrice = 39.99;
            }
            else
            {
                adultsPrice = 70.00;
                studentsPrice = 50.00;
            }

            var transportOneSide = adults * adultsPrice + students * studentsPrice;
            var transportTwoSides = transportOneSide * 2;
            var pricePerNight = night * priceAllGroupNight;
            var commission = (transportTwoSides + pricePerNight) * 0.1;
            var totalPrice = transportTwoSides + pricePerNight + commission;
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
