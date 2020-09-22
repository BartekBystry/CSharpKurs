using System;
using System.Collections.Generic;
using System.Linq;


namespace StudentDiary
{
    class Diary
    {
        //State (variables)
        List<float> ratings = new List<float>();

        //Behavior
        public void addRating(float rating)
        {
            ratings.Add(rating);
        }

        public float calculateAverage()
        {
            float sum = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
 
            return sum / ratings.Count();
        }

        public float getMaxRating()
        {
            return ratings.Max();
        }

        public float getMinRating()
        {
            return ratings.Min();
        }


    }
}
