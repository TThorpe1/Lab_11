using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    // James - I love that you made a movie class and gave it a title and category field!
    // I also liked that you figured out how to use this method you created to return the field! good job!
    // as an extra challenge, Try using properties instead.
    //
    // public string Title { get; set; }
    // this actually does what your getData method is doing and it also uses a field
    // behind the scene. so this would make your movie class look like...
    //
    // public class Movies
    //{
    //  public string Title { get; set;}
    //  public string Category { get; set; }
    //}
    // 
    // and thats it!
    // then to get the data you would just type movie.Title, and this will "get" the title for you!
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

            // so your code is printing all of the movies in each list. I'm glad to see that you are looping 
            // just fine.  the next step is to take the user's input and print the correct list based on a selection.
            // you can do this with IF statements.
            // so for example, you could write 
            // if (userInput.Equals("drama", StringComparison.OrdinalCase))
            // {
            //      foreach (Movies mov in Drama)
            //      {
            //          Console.WriteLine(mov.getData());
            //      }
            // }
            //
            // so what the Equals method is doing is it's returning a boolean.
            // remember a boolean is either true or false.
            // booleans are important because they go hand in hand with
            // conditional statements.
            //
            // a conditional statement checks if a statement is either true or false, which
            // also returns a boolean
            // so for example 
            // 
            // var number = 2;
            // so we are storing an integer 2 in a variable called number.
            //
            // if (number == 1)
            //{
            //  // do something 
            //}
            //
            // so the number == 1 is a boolena expression, this will return a boolean, which is to say, this will return
            // if a number is 2, than true, and if it's not true, than it returns fasle.
            // this if statement will ONLY run the code inside the block below if the boolean expression evaluates to TRUE.
            //
            // so circling back to the Equal method, this method returns a BOOLEAN
            // which means we can totally use it inside of an if statement
            //
            //  if (userInput.Equals("drama", StringComparison.OrdinalCase))
            // {
            //   // do something
            // }
            //
            // so this is esentially saying if the user input evaluates to drama while ignoring case, then do whatever is in 
            // the block.
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


