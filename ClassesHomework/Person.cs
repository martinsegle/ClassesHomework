

namespace ClassesHomework
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Hobby { get; set; }
        public bool Gender { get; set; }
        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

        public void Greeting()
        {
            Console.WriteLine($"Hello, my name is {Name} {Surname} and I am {GetAge()} years old");
        }


    }
}
