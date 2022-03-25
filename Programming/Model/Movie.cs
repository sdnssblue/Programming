﻿using System;

namespace Programming.Model
{
    public class Movie
    {
        private int _releaseYear;
        private double _rating;
        private int _durationMinutes;

        public Movie()
        {

        }

        public Movie(int releaseYear,
                    int durationMinutes,
                    int rating,
                    string title,
                    string genre)
        {
            ReleaseYear = releaseYear;
            DurationMinutes = durationMinutes;
            Rating = rating;
            Title = title;
            Genre = genre;
        }

        public string Title {get; set;}

        public string Genre {get; set;}

        public int DurationMinutes
        {
            get
            {
                return _durationMinutes;
            }
            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentException(
                        "the duration of minutes field must be greater than 0");
                }
                _durationMinutes = value;
            }
        }

        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                DateTime myDateTime = DateTime.Now;
                int year = myDateTime.Year;
                if (1900 > value || value > year)
                {
                    throw new System.ArgumentException(
                        "the release year should be in the range from 1900 to 2022");
                }
                _releaseYear = value;
            }
        }

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (0 > value || value > 10)
                {
                    throw new System.ArgumentException(
                        "the rating should be in the range from 0 to 10");
                }
                _rating = value;
            }
        }
    }
}