using Pri.Generics.Cons.Entities;
using Pri.Generics.Cons.Generics;

namespace Pri.Generics.Cons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics voorbeelden");
            var order1 = new Order<int>(1, 10);
            var order2 = new Order<string>("My item", 5);
            //complex types
            var television = new Television 
            {
                Brand = "Philips",
                ScreenSize = 50,
                
            };
            var order3 = new Order<Television>(television, 20);
            //list van complex objects
            var televionList = new List<Television>
            {
                television,
                new Television
                {
                    Brand = "Philips",
                    ScreenSize = 40,
                },
                new Television
                {
                    Brand = "LG",
                    ScreenSize = 60,
                },
            };
            var order4 = new Order<List<Television>>(televionList, 4);
            //use a generic interface
            //a repo of int
            IRepository<int> numberRepository = new Repository<int>();
            numberRepository.Add(1);
            numberRepository.Add(12);
            numberRepository.Add(23);
            var firstNumber = numberRepository.Get(0);
            var allNumber = numberRepository.GetAll();
            //a repo of string
            IRepository<string> stringRepository = new Repository<string>();
            stringRepository.Add("First");
            stringRepository.Add("Second");
            stringRepository.Add("Third");
            stringRepository.Add("Fourth");
            var allStrings = stringRepository.GetAll();
            var secondString = stringRepository.Get(1);
            //complexe objecten
            //repository of persons
            IRepository<Person> personRepository = new Repository<Person>();
            personRepository.Add(new Person { Firstname = "Dries", Lastname = "Deboosere" });
            personRepository.Add(new Person { Firstname = "Maxim", Lastname = "Lesy" });
            personRepository.Add(new Person { Firstname = "Joachim", Lastname = "Francois" });
            personRepository.Add(new Person { Firstname = "William", Lastname = "Schokkelé" });
            var lectorProg = personRepository.Get(1);
            personRepository.Delete(lectorProg);
        }
    }
}