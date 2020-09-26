using System;
using System.Collections.Generic;
using System.Text;

namespace Introduction {
    class Movie {
        private string title;
        private string director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating) {
            this.title = aTitle;
            this.director = aDirector;
            Rating = aRating;
        }

        public string Rating { // getter and setter
            get { return rating; }
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "nr") {
                    rating = value;
                } else {
                    rating = "NR";
                }
            }
        }


    }
}
