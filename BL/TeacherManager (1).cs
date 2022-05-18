using System;
using UniversityConsoleApp.Models;
using UniversityConsoleApp.Interfaces;

namespace UniversityConsoleApp.BL
{
    public class TeacherManager : ICreate, IPrint
    {
        int maxAge = 89;

        public Person Create(string firstName, string lastName, int age)
        {
            return new Teacher(firstName, lastName, age);
        }

        public Person[] Create(int count, int minAge)
        {
            Teacher[] students = new Teacher[count];
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                students[i] = new Teacher($"name{i}", $" lastName{i}", rnd.Next(minAge, maxAge));
            }
            return students;
        }

        public void Print(Person person)
        {
            Console.WriteLine("**********Teacher**********");
            Console.WriteLine($"id:{person.ID} name:{person.FirstName} lastName:{person.LastName} age:{person.Age}");
            if (person is Teacher)
            {
                if (((Teacher)person).Students == null)
                    Console.WriteLine("___________________________________________");
                else
                {
                    for (int i = 0; i < ((Teacher)person).Students.Length; i++)
                        Console.WriteLine($"Student_id:{((Teacher)person).Students[i].ID} name:{((Teacher)person).Students[i].FirstName} lastName:{((Teacher)person).Students[i].LastName} age:{((Teacher)person).Students[i].Age}");
                }

            }

        }

        public void Print(Person[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                Print(people[i]);

            }

        }
    }
}


