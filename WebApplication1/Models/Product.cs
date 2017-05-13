using NHibernate.Mapping.ByCode.Conformist;

namespace WebApplication1.Models
{
    public class Product
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Text { get; set; }
        public virtual decimal Value { get; set; }
        public virtual int Type_id { get; set; }
        public virtual byte[] Imeg { get; set; }
    }

    public class ProductMap : ClassMapping<Product>
    {
        public ProductMap()
        {
            Table("\"Product\"");
            Id(x => x.Id, x => x.Column("\"Id\""));
            Property(x => x.Name, x => x.Column("\"Name\""));
            Property(x => x.Text, x => x.Column("\"Text\""));
            Property(x => x.Value, x => x.Column("\"Value\""));
            Property(x => x.Type_id, x => x.Column("\"Type_id\""));
            Property(x => x.Imeg, x => x.Column("\"Imeg\""));
        }
    }
}