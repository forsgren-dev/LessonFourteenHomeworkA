using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LessonFourteenHomework.Models;

namespace LessonFourteenHomework.Services
{
    internal static class PersonService
    {
       public static void ListPersons()
        {
            Console.WriteLine("Namn: ".PadRight(20) + "Ålder: ");
            foreach (Person p in Person.PersonList)
            {
                Console.WriteLine(p.Name.PadRight(20) + 
                    p.Age.ToString().PadLeft(6));
            }
        }
    }
}
