using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI;

namespace WpfApp3.Model
{
   public class Person
    {
        public ColumnObjectCollections ColumnCollection
        {
            get;
            set;
        }
        public Person()
        {
            ColumnCollection = new ColumnObjectCollections();
        }
        public Person(string name, int age, int score)
        {
            Name = name;
            Age = age;
            Score = score;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }

        public static Person[] Get()
        {
            return new Person[]
            {
                new Person("Zhang", 14, 91),
                new Person("Mgen",21,77),
                new Person("Lee",40,93),
                new Person("123",32,35),
                new Person("Gao",22,71),
                new Person("Sun",9,21),
                new Person("David",71,12)
            };
        }
    }
}