using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursExam = int.Parse(Console.ReadLine());
            var minutesExam = int.Parse(Console.ReadLine());
            var hoursArrival = int.Parse(Console.ReadLine());
            var minutesArrival = int.Parse(Console.ReadLine());

            var examTime = hoursExam * 60 + minutesExam;
            var studentTime = hoursArrival * 60 + minutesArrival;
            var minutesDifference = studentTime - examTime;

            if (minutesDifference < -30)
            {
                Console.WriteLine("Early");
            }
            else if (minutesDifference <= 0)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Late");
            }

            if (minutesDifference != 0)
            {
                var hours = Math.Abs(minutesDifference / 60);
                var minutes = Math.Abs(minutesDifference % 60);
                if (minutesDifference < 0)
                {
                    if (hours != 0)
                    {
                        if (minutes < 10)
                        {
                            Console.WriteLine($"{hours}:0{minutes} hours before the start");
                        }
                        else
                        {
                            Console.WriteLine($"{hours}:{minutes} hours before the start");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"{minutes} minutes before the start");
                    }
                }
                else
                {
                    if (hours != 0)
                    {
                        if (minutes < 10)
                        {
                            Console.WriteLine($"{hours}:0{minutes} hours after the start");
                        }
                        else
                        {
                            Console.WriteLine($"{hours}:{minutes} hours after the start");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"{minutes} minutes after the start");
                    }
                }
            }
        }
    }
}
