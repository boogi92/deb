using NHibernate.Mapping.ByCode.Conformist;
using WebApplication1.Models;

namespace WebApplication1.Mapping
{
    public class ContextMap : ClassMapping<Context>
    {
        public ContextMap()
        {
            Table("\"Context\"");
            Id(x => x.Id, x => x.Column("\"Id\""));
            Property(x => x.Text, x => x.Column("\"Text\""));
        }
    }
}