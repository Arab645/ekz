using System.Collections.Generic;

namespace LAB5part1
{
    public interface ISearchable
    {
        List<Product> SearchByPrice(decimal maxPrice);
        List<Product> SearchByCategory(string category);
        List<Product> SearchByRating(int minRating);
    }
}