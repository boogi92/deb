using NHibernate.Mapping.ByCode;

namespace WebApplication1.Mapping
{
    using NHibernate.Mapping.ByCode.Conformist;
    using Models;

    public class ProductMap : ClassMapping<Product>
    {
        public ProductMap()
        {
            Table("\"Product\"");
            Id(x => x.Id, x => x.Column("\"Id\""));
            Property(x => x.Name, x => x.Column("\"Name\""));
            Property(x => x.Text, x => x.Column("\"Text\""));
            Property(x => x.Value, x => x.Column("\"Value\""));
            //Property(x => x.TypeId, x => x.Column("\"TypeId\""));
            ManyToOne(x=>x.Type, c => {
                c.Cascade(Cascade.Persist);
                c.Column("\"TypeId\"");
            });
            Property(x => x.Imeg, x => x.Column("\"Imeg\""));
        }
    }
}