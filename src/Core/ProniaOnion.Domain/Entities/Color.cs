namespace ProniaOnion.Domain.Entities
{
    public class Color : BaseNameableEntity
    {
        //Relational
        public ICollection<ProductColor> ProductColors { get; set; }

    }
}
