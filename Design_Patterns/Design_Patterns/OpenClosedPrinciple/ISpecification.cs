namespace Design_Patterns.OpenClosedPrinciple
{
    public interface ISpecification<T>
    {
        bool IsSatisfy(T type);
    }
}
