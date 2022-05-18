using System;
using UniversityConsoleApp.Models;

namespace UniversityConsoleApp.Interfaces
{
    public interface ICreate
    {
        Person Create(string firstName, string lastName, int age);
        Person[] Create(int count, int minAge);
    }
}
