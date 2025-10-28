using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonFourteenHomework.Models
{
    internal class Person
    {
        private string _name;
        private int _age;
        

        public static List<Person> PersonList = new();
        public string Name 
        { 
            get => _name; 
            set => _name = value ?? throw new ArgumentNullException(); 
        
        }
        public int Age
        {
            get => _age;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _age = value;
            }
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            PersonList.Add(this);
        }
    }
}
