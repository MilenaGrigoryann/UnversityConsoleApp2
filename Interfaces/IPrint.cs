using System;
using UniversityConsoleApp.Models;

namespace UniversityConsoleApp.Interfaces
{
    public interface IPrint
    {
        void Print(Person person);
        void Print(Person[] people);
    }
}
