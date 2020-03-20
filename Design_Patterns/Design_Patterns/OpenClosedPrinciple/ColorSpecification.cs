using Design_Patterns.SingleResponsibility;

namespace Design_Patterns.OpenClosedPrinciple
{
    public class ColorSpecification: ISpecification<Product>
    {
        private readonly Color _color;

        public ColorSpecification(Color color)
        {
            _color = color;
        }
        public bool IsSatisfy(Product type)
        {
            return type.Color == _color;
        }
    }
}
