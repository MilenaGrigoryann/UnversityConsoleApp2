﻿using System;

namespace UniversityConsoleApp.Models
{
    public class Student : Person
    {
        public Teacher Teacher { set; get; }
        public Group Group { set; get; }
        public Student()
        {

        }
        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }

        public Student(string firstName, string lastName, int age, Teacher teacher) : base(firstName, lastName, age)
        {
            Teacher = teacher;
        }
        public Student(string firstName, string lastName, int age, Teacher teacher, Group group) : base(firstName, lastName, age)
        {
            Teacher = teacher;
            Group = group;
        }
    }
}