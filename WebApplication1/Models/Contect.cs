using NHibernate.Bytecode.CodeDom;
using NHibernate.Mapping.ByCode.Conformist;

namespace WebApplication1.Models
{
    public class Contect
    {
        public virtual int Id { get; set; }
        public virtual string Text { get; set; }
    }

    public class ContectMap : ClassMapping<Contect>
    {
        public ContectMap()
        {
            Table("\"Contect\"");
            Id(x=>x.Id, x => x.Column("\"Id\""));
            Property(x=>x.Text, x =>x.Column("\"Text\"") );
        }
    }
}