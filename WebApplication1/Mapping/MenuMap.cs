namespace WebApplication1.Mapping
{
    using NHibernate.Mapping.ByCode.Conformist;
    using Models;

    public class MenuMap : ClassMapping<Menu>
    {
        public MenuMap()
        {
            Table("\"Menu\"");
            Id(x => x.Id, x => x.Column("\"Id\""));
            Property(x => x.Name, x => x.Column("\"Name\""));
            Property(x => x.Text, x => x.Column("\"Text\""));
            Property(x => x.Imeg, x => x.Column("\"Imeg\""));
        }
    }
}