using System.Collections.Generic;

namespace Design_Patterns.OpenClosedPrinciple
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}
