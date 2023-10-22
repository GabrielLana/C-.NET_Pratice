
using ExercicioFixacaoVetores01;

namespace Course
{
    public class Couse
    {
        public static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? "); byte n = byte.Parse(Console.ReadLine());
            while (n > 10)
            {
                Console.WriteLine("We only have 10 rooms available!");
                Console.Write("How many rooms will be rented? "); n = byte.Parse(Console.ReadLine());
            }

            Person[] personList = new Person[10];

            for (int i = 0; i < n; i++)
            {
                Person person = new Person();
                Console.WriteLine($"Rent #{i + 1}");
                Console.Write("Name: "); person.Name = Console.ReadLine();
                Console.Write("Email: "); person.Email = Console.ReadLine();
                Console.Write("Room: "); person.Room = byte.Parse(Console.ReadLine());
                personList[person.Room] = person;
            }

            foreach (var person in personList)
            {
                if(person != null)
                    Console.WriteLine(person);
            }
        }
    }
}