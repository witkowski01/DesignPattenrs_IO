using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattenrs_IO
{
    public interface IRepository<T>
    {
        void Add(T instance);
        void Remove(T instance);
        void Update(T instance);
        void DeleteById(T instance);
        void Display(T instance);
    }

    interface IPerson : IRepository<Person>
    {
        void AddSkill(Person person, Skill skill);
    }
    class Skill
    {
        public string Name { get; set; }
    }
    class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public UInt16 Age { get; set; }
        public int Id { get; set; }
        public List<Skill> Skills { get; set; }
    }

    class PersonRepository:IPerson
    {
        private List<Person> _entities;

        private int _count;
        public void AddSkill(Person person, Skill skill)
        {
            person.Skills.Add(skill);
        }

        public void Add(Person instance)
        {
            _entities=new List<Person>();

            instance.FirstName = "FirstName"; // this should be load from somewhere
            instance.SecondName = "SecondName";
            instance.Age = 22;
            instance.Id = _count++;
            instance.Skills = null;

            _entities.Add(instance);
        }

        public void Remove(Person instance)
        {
            _entities.Remove(instance);
        }

        public void Update(Person instance)
        {
            instance.Age += instance.Age; //Age update, you can update anythink
        }

        public void DeleteById(Person instance)
        {
            _entities.Remove(instance);
        }


        public void Display(Person instance)
        {
            Console.WriteLine(instance.Id);
            Console.WriteLine(instance.FirstName);
            Console.WriteLine(instance.SecondName);
            Console.WriteLine(instance.Age);
            Console.WriteLine(instance.Skills);
        }
    }

    class RepositoryUse
    {
        public void Use()
        {
            var per1 = new Person();
            IRepository<Person> repository = new PersonRepository();
            repository.Add(per1);
            
            repository.Display(per1);
        }
    }


}
