using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercises
    {
        class Exercise
        {
            public string Topic { get; set; }
            public string CourseName { get; set; }
            public string JudgeContestLink { get; set; }
            public List<string> Problems { get; set; }
        }

        static void Main(string[] args)
        {
            List<Exercise> exercises = new List<Exercise>();
            string input = Console.ReadLine();

            while (input != "go go go")
            {
                string[] inputParams = input
                    .Split(new[] { ',', ' ', '-', '>' },
                        StringSplitOptions.RemoveEmptyEntries);

                string topic = inputParams[0];
                string courseName = inputParams[1];
                string judgeLink = inputParams[2];
                List<string> problems = inputParams.Skip(3).ToList();

                Exercise newExercise = new Exercise();
                newExercise.Topic = topic;
                newExercise.CourseName = courseName;
                newExercise.JudgeContestLink = judgeLink;
                newExercise.Problems = problems;

                exercises.Add(newExercise);


                input = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");

                int counter = 1;
                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine($"{counter}. {problem}");
                    counter++;
                }
            }
        }
    }
}
