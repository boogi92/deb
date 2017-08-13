namespace WebApplication1.Mapping
{
    using NHibernate.Mapping.ByCode.Conformist;
    using Models;

    public class OrderMap : ClassMapping<Order>
    {
        public OrderMap()
        {
            Table("\"Order\"");
            Id(x => x.Id, x => x.Column("\"Id\""));
            Property(x => x.Name, x => x.Column("\"Name\""));
            Property(x => x.Tell, x => x.Column("\"Tell\""));
            Property(x => x.Address, x => x.Column("\"Address\""));
            Property(x => x.Comment, x => x.Column("\"Comment\""));
            Bag(x => x.OrderProduct,
                c =>
                {
                    c.Key(k => k.Column("\"OrderId\""));
                    c.Inverse(true);
                },
                r => r.OneToMany());
        }
    }
}