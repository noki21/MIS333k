using System;
using FinalProject12.Models;
using FinalProject12.DAL;
using FinalProject12.Utilities;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject12.Seeding
{

    public static class SeedMovies
    {
        public static void SeedAllMovies(AppDbContext db)
        {
            //Create a counter and a flag so we will know which record is causing problems
            Int32 intMovieID = 0;
            string strMovieTitle = "Begin";

            //Add the list of books
            List<Movie> AllMovies = new List<Movie>();


            AllMovies.Add(new Movie
            {
                MovieNum = 3001,
                MovieName = "Jurassic Park",
                Actor = "Sam Neill, Laura Dern, Jeff Goldblum",
                MovieDescription = "A pragmatic paleontologist touring an almost complete theme park on an island in Central America is tasked with protecting a couple of kids after a power failure causes the park's cloned dinosaurs to run loose.",
                ReleaseYear = 1993,
                Runtime = 90,
                Tagline = "Welcome to Jurassic Park",
                MPAA_Rating = MPAA_Rating.thirteen,
                Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama")
            });

            AllMovies.Add(new Movie
            {
                MovieNum = 3002,
                MovieName = "Toy Story 7",
                Actor = "Tom Hanks, Tim Allen",
                MovieDescription = "Woody and Buzz team up once again to lead the resistance in the Toy Revolt.",
                ReleaseYear = 2023,
                Runtime = 90,
                Tagline = "Play, pretend, and protect",
                MPAA_Rating = MPAA_Rating.G,
                Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Children and Family")
            });

            AllMovies.Add(new Movie
            {
                MovieNum = 3003,
                MovieName = "Fast and Furious 18: Anger Management",
                Actor = "The Rock, Vin Diesel",
                MovieDescription = "They may be riding mechanical scooters, but they are as furious as ever as they attend court-ordered therapy.",
                ReleaseYear = 2023,
                Runtime = 120,
                Tagline = "I drink your milkshake",
                MPAA_Rating = MPAA_Rating.R,
                Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action")
            });

            AllMovies.Add(new Movie
            {
                MovieNum = 3004,
                MovieName = "Titanic",
                Actor = "Leonardo DiCaprio, Kate Winslet",
                MovieDescription = "An epic, action-packed romance set against the ill-fated maiden voyage of the R.M.S. Titanic.",
                ReleaseYear = 1999,
                Runtime = 150,
                Tagline = "Nothing On Earth Could Come Between Them. Collide With Destiny.",
                MPAA_Rating = MPAA_Rating.thirteen,
                Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance")
            });

            AllMovies.Add(new Movie
            {
                MovieNum = 3005,
                MovieName = "The Secret Life of Walter Mitty",
                Actor = "Ben Stiller",
                MovieDescription = "When both he and a colleague are about to lose their job, Walter takes action by embarking on an adventure more extraordinary than anything he ever imagined.",
                ReleaseYear = 2013,
                Runtime = 120,
                Tagline = "Stop dreaming. Start Living.",
                MPAA_Rating = MPAA_Rating.PG,
                Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy")
            });

            AllMovies.Add(new Movie
            {
                MovieNum = 3006,
                MovieName = "The Goonies",
                Actor = "Sean Astin, Josh Brolin, Corey Feldman",
                MovieDescription = "A group of young misfits called The Goonies discover an ancient map and set out on an adventure to find a legendary pirate's long-lost treasure.",
                ReleaseYear = 1985,
                Runtime = 90,
                Tagline = "The treacherous traps. The hidden treasure. And Sloth... Join the adventure.",
                MPAA_Rating = MPAA_Rating.PG,
                Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Children and Family")
            });

            AllMovies.Add(new Movie
            {
                MovieNum = 3007,
                MovieName = "The Sandlot",
                Actor = "Mike Vitar, Patrick Renna, James Earl Jones",
                MovieDescription = "When Scottie Smalls moves to a new neighborhood, he manages to make friends with a group of kids who play baseball at the sandlot.",
                ReleaseYear = 1993,
                Runtime = 90,
                Tagline = "The adventure of a lifetime, the summer of their dreams...the dog of their nightmares.",
                MPAA_Rating = MPAA_Rating.PG,
                Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Children and Family")
            });

            AllMovies.Add(new Movie
            {
                MovieNum = 3008,
                MovieName = "Rocky Horror Picture Show",
                Actor = "Tim Curry, Susan Sarandon",
                MovieDescription = "A newly-engaged couple have a breakdown in an isolated area and must seek shelter at the bizarre residence of Dr. Frank-n-Furter",
                ReleaseYear = 1975,
                Runtime = 90,
                Tagline = "Don't Dream it, Be It!",
                MPAA_Rating = MPAA_Rating.R,
                Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Musical")
            });

            AllMovies.Add(new Movie
            {
                MovieNum = 3009,
                MovieName = "Titanic: Jack's Revenge",
                Actor = "Leonardo DiCaprio, Kate Winslet",
                MovieDescription = "Emerging from the deep with revenge on his mind, Jack Dawson will stop at nothing to find Rose.",
                ReleaseYear = 2023,
                Runtime = 150,
                Tagline = "She let me go, now I'll never let her forget it.",
                MPAA_Rating = MPAA_Rating.R,
                Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Horror")
            });

            AllMovies.Add(new Movie
            {
                MovieNum = 3010,
                MovieName = "The Hobbit: An Unexpected Journey",
                Actor = "Martin Freeman, Ian McKellan, Richard Armitage",
                MovieDescription = "An Unexpected Journey tells the tale of Bilbo Baggins, who is convinced by the wizard Gandalf to accompany thirteen Dwarves, led by Thorin Oakenshield, on a quest to reclaim the Lonely Mountain from the dragon Smaug.",
                ReleaseYear = 2012,
                Runtime = 150,
                Tagline = "From the smallest beginnings come the greatest legends. One journey started it all.",
                MPAA_Rating = MPAA_Rating.thirteen,
                Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction")
            });

            AllMovies.Add(new Movie
            {
                MovieNum = 3011,
                MovieName = "The Hobbit: The Battle of Five Armies",
                Actor = "Martin Freeman, Ian McKellan, Richard Armitage",
                MovieDescription = "Bilbo and company are forced to engage in a war against an array of combatants and keep the Lonely Mountain from falling into the hands of a rising darkness.",
                ReleaseYear = 2014,
                Runtime = 150,
                Tagline = "The defining chapter.",
                MPAA_Rating = MPAA_Rating.thirteen,
                Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction")
            });

            AllMovies.Add(new Movie
            {
                MovieNum = 3012,
                MovieName = "The Hobbit: The Desolation of Smaug",
                Actor = "Martin Freeman, Ian McKellan, Richard Armitage",
                MovieDescription = "The dwarves, along with Bilbo Baggins and Gandalf the Grey, continue their quest to reclaim Erebor, their homeland, from Smaug.",
                ReleaseYear = 2013,
                Runtime = 150,
                Tagline = "It's a really big dragon",
                MPAA_Rating = MPAA_Rating.thirteen,
                Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction")
            });

            AllMovies.Add(new Movie
            {
                MovieNum = 3013,
                MovieName = "Lord of the Rings: Fellowship of the Ring",
                Actor = "Elijah Wood, Sam Astin, Orlando Bloom, Viggo Mortenson, Billy Boyd, Dominic Monaghan, Sean Bean",
                MovieDescription = "The future of civilization rests in the fate of the One Ring, which has been lost for centuries. Powerful forces are unrelenting in their search for it. But fate has placed it in the hands of a young Hobbit named Frodo Baggins, who inherits the Ring and steps into legend.",
                ReleaseYear = 2001,
                Runtime = 150,
                Tagline = "One Ring To Rule Them All. Fate Has Chosen Him. A Fellowship Will Protect Him. Evil Will Hunt Them.",
                MPAA_Rating = MPAA_Rating.thirteen,
                Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction")
            });

            AllMovies.Add(new Movie
            {
                MovieNum = 3014,
                MovieName = "Lord of the Rings: Two Towers",
                Actor = "Elijah Wood, Sam Astin, Orlando Bloom, Viggo Mortenson, Billy Boyd, Dominic Monaghan, Sean Bean",
                MovieDescription = "Frodo and Sam discover they are being followed by the mysterious Gollum.",
                ReleaseYear = 2002,
                Runtime = 150,
                Tagline = "A New Power Is Rising. The Battle for Middle-earth Begins!",
                MPAA_Rating = MPAA_Rating.thirteen,
                Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction")
            });

            AllMovies.Add(new Movie
            {
                MovieNum = 3015,
                MovieName = "Lord of the Rings: The Return of the King",
                Actor = "Elijah Wood, Sam Astin, Orlando Bloom, Viggo Mortenson, Billy Boyd, Dominic Monaghan, Sean Bean",
                MovieDescription = "Continuing the plot of the previous film, Frodo, Sam and Gollum are making their final way toward Mount Doom to destroy the One Ring, unaware of Gollum's true intentions, while Merry, Pippin, Gandalf, Aragorn, Legolas, Gimli and the others join forces together against Sauron and his legions in Minas Tirith.",
                ReleaseYear = 2003,
                Runtime = 180,
                Tagline = "No victory without suffering. No freedom without sacrifice.",
                MPAA_Rating = MPAA_Rating.thirteen,
                Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction")
            });

            AllMovies.Add(new Movie
            {
                MovieNum = 3016,
                MovieName = "Barbie",
                Actor = "Ryan Gosling, Margot Robbie",
                MovieDescription = "Stereotypical Barbie experiences a full on existential crisis and embarks on a journey of self discovery. Along for the ride is her beau Ken.",
                ReleaseYear = 2023,
                Runtime = 120,
                Tagline = "She can do everything. He's just Ken.",
                MPAA_Rating = MPAA_Rating.thirteen,
                Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy")
            });

            AllMovies.Add(new Movie
            {
                MovieNum = 3017,
                MovieName = "Spider-Man: Into the Spider-Verse",
                Actor = "Shameik Moore, Jake Johnson, Hailee Steinfeld, Stan Lee, Oscar Isaac, Nicolas Cage, Mahershala Ali",
                MovieDescription = "Teen Miles Morales becomes the Spider-Man of his universe and must join with five spider-powered individuals from other dimensions to stop a threat for all realities.",
                ReleaseYear = 2018,
                Runtime = 120,
                Tagline = "Enter a universe where more than one wears the mask.",
                MPAA_Rating = MPAA_Rating.PG,
                Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action")
            });

            AllMovies.Add(new Movie
            {
                MovieNum = 3018,
                MovieName = "Spider-Man: Across the Spider-Verse",
                Actor = "Shameik Moore, Hailee Steinfeld, Oscar Isaac, Karan Soni, Andy Samberg, Daniel Kaluuya",
                MovieDescription = "Miles Morales catapults across the Multiverse, where he encounters a team of Spider-People charged with protecting its very existence.",
                ReleaseYear = 2023,
                Runtime = 150,
                Tagline = "With great power comes great responsibility.",
                MPAA_Rating = MPAA_Rating.PG,
                Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action")
            });

            try  //attempt to add or update the book
            {
                //loop through each of the books in the list
                foreach (Movie movieToAdd in AllMovies)
                {
                    //set the flag to the current title to help with debugging
                    strMovieTitle = movieToAdd.MovieName;

                    //look to see if the book is in the database - this assumes that no
                    //two books have the same title
                    Movie dbMovie = db.Movies.FirstOrDefault(m => m.MovieName == movieToAdd.MovieName);

                    //if the dbBook is null, this title is not in the database
                    if (dbMovie == null)
                    {
                        //add the book to the database and save changes
                        db.Movies.Add(movieToAdd);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intMovieID += 1;
                    }
                    else //dbBook is not null - this title *is* in the database
                    {
                        //update all of the book's properties
                        dbMovie.MovieName = movieToAdd.MovieName;
                        dbMovie.MovieDescription = movieToAdd.MovieDescription;
                        dbMovie.ReleaseYear = movieToAdd.ReleaseYear;
                        dbMovie.MPAA_Rating = movieToAdd.MPAA_Rating;
                        dbMovie.Tagline = movieToAdd.Tagline;
                        dbMovie.Runtime = movieToAdd.Runtime;


                        //since we found the correct genre object in a previous step,
                        //this update is easy - both dbBook and bookToAdd have a Genre 
                        //object for this property
                        dbMovie.Genre = movieToAdd.Genre;

                        //update the database and save the changes
                        db.Update(dbMovie);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intMovieID += 1;
                    } //this is the end of the else
                } //this is the end of the foreach loop for the books
            }//this is the end of the try block

            catch (Exception ex)//something went wrong with adding or updating
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("There was a problem adding the job posting with the title: ");
                msg.Append(strMovieTitle);
                msg.Append(" (intMovieID: ");
                msg.Append(intMovieID);
                msg.Append(")");
                throw new Exception(msg.ToString(), ex);
                //Build a messsage using the flags we created
                //String msg = "  Repositories added:" + intMovieID + "; Error on " + strMovieTitle;

                //throw the exception with the new message
                throw new InvalidOperationException(ex.Message + msg);
            }
        }
    }
}
    