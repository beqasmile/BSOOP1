using FirstOOPProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> myMoviesList = new List<Movie>(); // list creation and definition

            for (int i = 0; i < 5; i++)
            {
                Movie myMovie = new Movie(i);


                Console.WriteLine("Please input movie name >");
                String movieName = Console.ReadLine();
                myMovie.SetMovieName(movieName);
                Console.WriteLine("Please input movie type >");
                String movieType = Console.ReadLine();
                myMovie.SetMovieType(movieType);
                Console.WriteLine("Please input movie lenght >");

                int movieLength = int.Parse(Console.ReadLine());
                myMovie.SetMovieLength(movieLength);
                Console.WriteLine("Please input movie director >");

                String movieDirector = Console.ReadLine();
                MovieDirector md1 = new MovieDirector(movieDirector);
                myMovie.SetMovieDirector(md1);


                Console.WriteLine("Please input the number of actors>");
                int numberActors = int.Parse(Console.ReadLine());


                for (int j = 0; j < numberActors; j++)
                {
                    Console.WriteLine("Please input actor name ");
                    string actorName = Console.ReadLine();

                    Console.WriteLine("Please input actor sur name ");
                    string actorSUrName = Console.ReadLine();


                    Console.WriteLine("Please input actor type ");
                    string actorType = Console.ReadLine();


                    int birthDay = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please input bitrhday >");

                    MovieActor movieActor = new MovieActor(i, actorName, actorSUrName, birthDay, actorType);

                    myMovie.AddActor(movieActor);

                }


                myMoviesList.Add(myMovie);


            }


            // myMoviesList.Remove(movie1);                   // remove object from list

            foreach (Movie movieTemp in myMoviesList)       // pass over list
            {
                Console.WriteLine(movieTemp.ToString());
            }

            Console.ReadKey();

        }
    }
}
