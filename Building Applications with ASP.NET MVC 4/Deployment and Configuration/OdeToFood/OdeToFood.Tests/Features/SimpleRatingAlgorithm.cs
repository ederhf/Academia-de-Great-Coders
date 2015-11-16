using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Tests.Features
{
    public class SimpleRatingAlgorithm : IRatingAlgorithm
    {
        public RatingResult Compute(IList<Models.RestaurantReview> reviews)
            {
                var result = new RatingResult();
                result.Rating = (int)reviews.Average(r => r.Rating);
                return result;
            }
    }
}
