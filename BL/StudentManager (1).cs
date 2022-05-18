using System;
using UniversityConsoleApp.Models;
using UniversityConsoleApp.Interfaces;
namespace UniversityConsoleApp.BL
{
    public class StudentManager : ICreate, IPrint
    {
        int maxAge = 89;
        public Person Create(string firstName, string lastName, int age) => new Student(firstName, lastName, age);
        public Person[] Create(int count, int minAge)
        {
            Student[] students = new Student[count];
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                students[i] = new Student($"name{i}", $" lastName{i}", rnd.Next(minAge, maxAge));
            }
            return students;
        }

      

        public void  Print(Person person)
        {
            Console.WriteLine("**********Student**********");
            Console.WriteLine($"id:{person.ID} name:{person.FirstName} lastName:{person.LastName} age:{person.Age}");
            if (person is Student)
            {
                if (((Student)person).Teacher == null)
                    Console.WriteLine("___________________________________________");
                else
                    Console.WriteLine($"Teacher_id:{((Student)person).Teacher.ID} name:{((Student)person).Teacher.FirstName} lastName:{((Student)person).Teacher.LastName} age:{((Student)person).Teacher.Age}");
                if (((Student)person).Group != null)
                    Console.WriteLine($"GroupId:{((Student)person).Group.ID} GroupName:{((Student)person).Group.Name}");
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
