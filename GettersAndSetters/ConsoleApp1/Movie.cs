using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Movie
    {
        public string title;
        public string director;
        private string rating; // get and sett allow read and write private

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating; // have to call to get set function
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "5")
                {
                    rating = value;
                }
                else
                {
                    rating = "works";
                }
            }
        }
    }
}
