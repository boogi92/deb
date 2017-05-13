using System.Drawing;
using System.IO;
using NHibernate.Mapping.ByCode.Conformist;

namespace WebApplication1.Models
{
    public class Menu
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Text { get; set; }
        public virtual byte[] Imeg { get; set; }
        public virtual Image Img {
            get
            {
                return Image.FromStream(new MemoryStream(Imeg));
            }
        }
    }

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