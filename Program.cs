using LessonFourteenHomework.Services;
using LessonFourteenHomework.Models;

namespace LessonFourteenHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var personOne = new Person("Kalle Andersson", 42);
            var personTwo = new Person("Lisa Larsson", 8);
            var personThree = new Person("Hasse Hansson", 49);

            PersonService.ListPersons();
        }
    }
}
