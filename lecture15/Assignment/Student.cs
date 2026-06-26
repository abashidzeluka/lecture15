using System;
using System.Collections.Generic;

namespace Assignment
{
    internal class Student
    {
        public Student()
        {
            Names();
            Scores();
        }

        List<string> studentNames = new List<string>();
        Dictionary<string, int> studentScores = new Dictionary<string, int>();
        public void Names()
        {
            studentNames.Add("Jack");
            studentNames.Add("Emma");
            studentNames.Add("Liam");
            studentNames.Add("Olivia");
            studentNames.Add("Noah");
            studentNames.Add("Ava");
            studentNames.Add("Ethan");
            studentNames.Add("Sophia");
            studentNames.Add("Mason");
            studentNames.Add("Isabella");
        }

        public void Scores()
        {
            studentScores.Add(studentNames[0], 45);
            studentScores.Add(studentNames[1], 78);
            studentScores.Add(studentNames[2], 92);
            studentScores.Add(studentNames[3], 61);
            studentScores.Add(studentNames[4], 55);
            studentScores.Add(studentNames[5], 88);
            studentScores.Add(studentNames[6], 73);
            studentScores.Add(studentNames[7], 49);
            studentScores.Add(studentNames[8], 95);
            studentScores.Add(studentNames[9], 67);
        }

        public void StudentAdd()
        {
            Console.Write("Please enter student name: ");
            string name = Console.ReadLine().Trim();
            name = char.ToUpper(name[0]) + name.Substring(1).ToLower();

            Console.Write("Please enter student score: ");
            int score = int.Parse(Console.ReadLine()); 
            
            studentNames.Add(name);
            studentScores.Add(name, score);
        }

        public void FindStudent()
        {
            Console.Write("Enter student name to find: ");
            string name = Console.ReadLine().Trim();
            for (int i = 0; i < studentNames.Count; i++)
            {
                if (studentNames[i].ToLower() == name.ToLower())
                {
                    Console.WriteLine($"Name: {studentNames[i]} Score: {studentScores[studentNames[i]]}");
                    return;
                }
            }
            Console.WriteLine("Student not found.");
        }

        public void UpdateScore()
        {
            Console.Write("Please enter student's name: ");
            string name = Console.ReadLine().Trim();
            name = char.ToUpper(name[0]) + name.Substring(1).ToLower();

            Console.Write("Please enter new score: ");
            int score = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentNames.Count; i++)
            {
                if (name.ToLower() == studentNames[i].ToLower())
                {
                    studentScores[studentNames[i]] = score;
                    Console.WriteLine("Student's info updated successfully!");
                    return;
                }
            }
            Console.WriteLine("Student not found!");

        }

        public void PrintInfo()
        {
           foreach (var item in studentScores)
    {
        Console.WriteLine($"Name: {item.Key} Score: {item.Value}");
    }
        }

    }
}
