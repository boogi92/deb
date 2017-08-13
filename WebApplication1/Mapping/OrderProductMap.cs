using NHibernate.Mapping.ByCode;

namespace WebApplication1.Mapping
{
    using NHibernate.Mapping.ByCode.Conformist;
    using Models;

    public class OrderProductMap : ClassMapping<OrderProduct>
    {
        public OrderProductMap()
        {
            Table("\"OrderProduct\"");
            Id(x => x.Id, x => x.Column("\"Id\""));
            Property(x => x.Count, x => x.Column("\"Count\""));
            Property(x => x.Price, x => x.Column("\"Price\""));
            Property(x => x.TypeId, x => x.Column("\"TypeId\""));
            Property(x => x.OrderId, x => x.Column("\"OrderId\""));
            Property(x => x.ProductId, x => x.Column("\"ProductId\""));
            //ManyToOne(x => x.Order,
            //    c =>
            //    {
            //        c.Cascade(Cascade.All);
            //        c.Column("\"OrderId\"");
            //    });
        }
    }
}