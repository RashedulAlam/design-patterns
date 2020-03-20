using Design_Patterns.SingleResponsibility;

namespace Design_Patterns.OpenClosedPrinciple
{
    public class AndSpecification<T>: ISpecification<T>
    {
        private readonly ISpecification<T> _left;
        private readonly ISpecification<T> _right;

        public AndSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            _left = left;
            _right = right;
        }
        public bool IsSatisfy(T type)
        {
            return _left.IsSatisfy(type) && _right.IsSatisfy(type);
        }
    }
}
;