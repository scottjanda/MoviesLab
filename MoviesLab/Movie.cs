using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLab
{
    public class Movie
    {
        public string title;
        public string category;
        public int runTime;
        public int releaseYear;

        public Movie(string memberTitle, string memberCategory, int memberRunTime, int memberReleaseYear)
        {
            title = memberTitle;
            category = memberCategory;
            runTime = memberRunTime;
            releaseYear = memberReleaseYear;
        }

    }
}