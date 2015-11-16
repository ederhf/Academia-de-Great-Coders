using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OdeToFood.Models;

namespace OdeToFood.Tests.Features
{
    public class WeightRatingAlgorithm : IRatingAlgorithm
    {
        public RatingResult Compute(IList<RestaurantReview> reviews)
        {
            var result = new RatingResult();
            var counter = 0;
            var total = 0;

            for (int i = 0; i < reviews.Count(); i++)
            {
                if (i < reviews.Count() / 2)
                {
                    counter += 2;
                    total += reviews[i].Rating * 2;
                }
                else
                {
                    counter += 1;
                    total += reviews[i].Rating;
                }
            }

            result.Rating = total / counter;
            return result;
        }
    }
}
