using System.Reflection.PortableExecutable;

namespace EnumIndexerTask
{
    public class Person /*:IComparable*/
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        //public int CompareTo(object? obj)
        //{
        //    Person other = obj as Person;
        //    return this.Age.CompareTo(other.Age);
        //}
        public static bool operator <(Person a, Person b)
        {
              return a.Age < b.Age; 
        }
        public static bool operator >(Person a, Person b)
        {
            return a.Age > b.Age;
        }
        public override string ToString()
        {
            return $"{Name} {Surname} , Age: {Age}";
        }
    }
}
