using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    public class Movies
    {
        public string Title;
        public string Category;

        public string getData()
        {
            return this.Title;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Movies> Animated = new List<Movies>();
            Animated.Add(new Movies());
            Animated[0].Title = "Incredibles 2";
            Animated[0].Category = "Animated";
            Animated.Add(new Movies());
            Animated[1].Title = "The Grinch";
            Animated[1].Category = "Animated";
            Animated.Add(new Movies());
            Animated[2].Title = "Hotel Transylvania";
            Animated[2].Category = "Animated";

            List<Movies> Drama = new List<Movies>();
            Drama.Add(new Movies());
            Drama[0].Title = "The Hate U Give";
            Drama[0].Category = "Drama";
            Drama.Add(new Movies());
            Drama[1].Title = "A Star is Born";
            Drama[1].Category = "Drama";
            Drama.Add(new Movies());

            Drama[2].Title = "Nobody's Fool";
            Drama[2].Category = "Drama";

            List<Movies> Horror = new List<Movies>();
            Horror.Add(new Movies());
            Horror[0].Title = "The Predator";
            Horror[0].Category = "Horror";
            Horror.Add(new Movies());
            Horror[1].Title = "Overlord";
            Horror[1].Category = "Horror";
            Horror.Add(new Movies());
            Horror[2].Title = "Halloween";
            Horror[2].Category = "Horror";

            List<Movies> Scifi = new List<Movies>();
            Scifi.Add(new Movies());
            Scifi[0].Title = "Black Panther";
            Scifi[0].Category = "Scifi";
            Scifi.Add(new Movies());
            Scifi[1].Title = "Jurassic World:  Fallen Kingdom";
            Scifi[1].Category = "Scifi";
            Scifi.Add(new Movies());
            Scifi[2].Title = "Rampage";
            Scifi[2].Category = "Scifi";

            // string.Equals("y", StringComparison.Ordinal); (Per your suggestion. Can't get it to work)

            Console.WriteLine("Welcome to the Movie List Application!\n\n" +
                "There are 12 movies in this list.\n\nWhat category are you interested in?\n\n" +
                "Animated     Drama     Horror     SciFi\n\n");

            string userInput = Console.ReadLine();
            //Can't figure out how to select categories and attached to titles.

            foreach (Movies mov in Animated)
            {
                Console.WriteLine(mov.getData());
            }
            Console.ReadLine();

            foreach (Movies mov in Drama)
            {
                Console.WriteLine(mov.getData());
            }
            Console.ReadLine();

            foreach (Movies mov in Horror)
            {
                Console.WriteLine(mov.getData());
            }
            Console.ReadLine();

            foreach (Movies mov in Scifi)
            {
                Console.WriteLine(mov.getData());
            }
            Console.ReadLine();
            Console.WriteLine("Continue\"(y/n)\"?");




        }

    }
}


