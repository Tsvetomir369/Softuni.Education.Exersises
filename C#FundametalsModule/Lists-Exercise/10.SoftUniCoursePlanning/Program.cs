using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input = Console.ReadLine();
            while (input != "course start")
            {
                string[] commands = input.Split(":").ToArray();
                string firstCommand = commands[0];
                string lessonTitle = commands[1];

                switch (firstCommand)
                {
                    case "Add":
                        if (!lessons.Contains(lessonTitle))
                        {
                            lessons.Add(lessonTitle);
                        }                       
                        break;
                    case "Insert":
                        int index = int.Parse(commands[2]);
                        if (!lessons.Contains(lessonTitle))
                        {
                            lessons.Insert(index, lessonTitle);
                        }
                        break;
                    case "Remove":
                            lessons.Remove(lessonTitle);
                        break;
                    case "Swap":
                        string secondLessonTitle = commands[2];

                        int indexOfFirstLesson = lessons.IndexOf(lessonTitle);
                        int indexOfSecondLesson = lessons.IndexOf(secondLessonTitle);

                        if (indexOfFirstLesson != -1 &&  indexOfSecondLesson != -1)
                        {
                            lessons[indexOfFirstLesson] = secondLessonTitle;
                            lessons[indexOfSecondLesson] = lessonTitle;

                            string firstLessonExercise = $"{lessonTitle}-Exercise";
                            int indexFirstExercise = indexOfFirstLesson + 1;

                            if (indexOfFirstLesson < lessons.Count && 
                                lessons[indexFirstExercise] == firstLessonExercise)
                            {
                                lessons.RemoveAt(indexFirstExercise);
                                indexFirstExercise = lessons.IndexOf(lessonTitle);
                                lessons.Insert(indexFirstExercise, firstLessonExercise);
                            }

                            string secondLessonExercise = $"{secondLessonTitle}-Excercise";
                            int indexSecondExercise = indexOfSecondLesson + 1;

                            if (indexSecondExercise < lessons.Count &&
                                lessons[indexSecondExercise] == secondLessonExercise)
                            {
                                lessons.RemoveAt(indexOfSecondLesson + 1);
                                indexOfSecondLesson = lessons.IndexOf(secondLessonTitle);
                                lessons.Insert(indexOfSecondLesson + 1, secondLessonExercise);
                            }
                        }
                        break;
                    case "Exercise":
                        int indexExercise = lessons.IndexOf(lessonTitle);
                        string exercise = $"{lessonTitle}-Exercise";


                        bool isThereAreLesson = lessons.Contains(lessonTitle);
                        bool isThereAreExercise = lessons.Contains(exercise);

                        if (isThereAreLesson && !isThereAreExercise)
                        {
                            lessons.Insert(indexExercise + 1, exercise);
                        }
                        else if (!isThereAreLesson)
                        {
                            lessons.Add(lessonTitle);
                            lessons.Add(exercise);
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}
