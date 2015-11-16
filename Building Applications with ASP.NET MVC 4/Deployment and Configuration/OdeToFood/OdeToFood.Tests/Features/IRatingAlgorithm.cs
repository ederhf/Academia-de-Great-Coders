using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OdeToFood.Tests.Features
{
    public interface IRatingAlgorithm
    {
        RatingResult Compute(IList<Models.RestaurantReview> reviews);                   
    }
}
