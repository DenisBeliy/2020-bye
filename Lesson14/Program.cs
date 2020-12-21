using System;
//Benjamin Hancock

namespace Lesson14
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];

            animals[0] = new Ostrich(205673); ;
            animals[1] = new Dragon(true); ;
            animals[2] = new Penguin(State.лежит); ;

            Benjamin_Hancock benjamin_Hancock = new Benjamin_Hancock(animals);
            benjamin_Hancock.Say();


            //   Win.OS.v1();

          Lesson14.Print.CW();

            Console.ReadLine();
        }
    }
    class Benjamin_Hancock
    {
        public Animal[] Cart; // массив

        public Benjamin_Hancock(Animal[] animals)
        {
            this.Cart = animals;
        }

        public void Say()
        {
            for (int i = 0; i < Cart.Length; i++)
            {
                Animal animal = Cart[i];

                if (animal is Ostrich) // попытка превращения
                {
                    Ostrich ostrich = (Ostrich)animal; //превращение DownCast
                    ostrich.Say();
                    Console.WriteLine("Benjamin_Hancock: - Oh! Ты умеешь говорить?");
                }

            }
        }
    }


    class Animal
    {

    }






    class Ostrich: Animal
    { 
        private int feathers ; 
        public  Ostrich(int num_feathers)
        {
          this.feathers = num_feathers;
        }

        public void Say()
        {
            Console.WriteLine("Курлык-курлык...");
        }
    }

    class Dragon : Animal
    {

        private bool isFire;

        public Dragon (bool isFire)
        {
            this.isFire = isFire;
        }
    }

    enum State {лежит,стоит}



    class Penguin : Animal
    {
        private State state;

        public Penguin (State state)
        {
            this.state = state;
        }
    } 
}
namespace Win
{
    class OS
    {

        public static void v1()
        {
            Console.WriteLine("это новый namespase");
        }


    }
}
