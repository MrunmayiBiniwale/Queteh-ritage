namespace Quetehéritage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bipèdes humain = new Bipèdes();
            humain.Move();
            humain.Eat("Humans");

            Bipèdes Singe = new Bipèdes();
            humain.Move();
            humain.Eat("The monkeys");

            Quadrupèdes elephant = new Quadrupèdes();
            elephant.Move();
            elephant.Eat("The Elephants");

            Quadrupèdes tortue = new Quadrupèdes();
            elephant.Move();
            elephant.Eat("The turtles");

            Quadrupèdes lézard = new Quadrupèdes();
            elephant.Move();
            elephant.Eat("The lizards");
        }
    }

    public abstract class Animal { 
        public virtual void Move()
        {
            Console.WriteLine("Animals can move");
        }

    }

    public class Bipèdes : Animal {
        public override void Move() {
            Console.WriteLine("Bipèdes walk on 2 legs.");
        }

        public void Eat(string animalType)
        {
            Console.WriteLine("" + animalType + " eat with their mouth.");
        }
    }

    public class Quadrupèdes : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Quadrupèdes walk on 4 legs.");
        }

        public void Eat(string food)
        {
            Console.WriteLine("All animals eat with their mouth.");
        }
    }

}
