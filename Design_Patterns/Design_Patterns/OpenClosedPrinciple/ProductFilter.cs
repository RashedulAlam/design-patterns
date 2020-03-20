using System.Collections.Generic;

namespace Design_Patterns.OpenClosedPrinciple
{
    public class ProductFilter: IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var product in items)
            {
                if (spec.IsSatisfy(product))
                    yield return product;
            }
        }
    }
}
