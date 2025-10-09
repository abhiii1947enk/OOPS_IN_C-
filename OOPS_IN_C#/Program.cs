using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_IN_C_
{
    internal class Program
    {
        public class Animal
        {
            public string skill;

            public void Eat()
            {
                Console.WriteLine("Eat");
                Console.WriteLine("Eating");
            }
        }

        interface ILiving
        {
            void Live();
        }

        public abstract class Sound
        {
            public abstract void Play();
            public void Play(string test)
            {
                Console.WriteLine($"{test}");
            }
        }

        public class Cat : Sound
        {
            public override void Play()
            {
                throw new NotImplementedException();
            }
        }
        

        public class Dog : Animal, ILiving
        {
            public void Bark()
            {
                Console.WriteLine("Bark");
                Console.WriteLine("Barking");
            }

            public void Live()
            {
                Console.WriteLine("Live");
                Cat ct = new Cat();
                ct.Play();
                ct.Play("skill");
            }
           
        }
        static void Main(string[] args)
        {
            Dog objDog = new Dog();
            objDog.Eat();
            objDog.Bark();
            objDog.Live();

            Cat objCat = new Cat();
            objCat.Play();
        }
    }
}
