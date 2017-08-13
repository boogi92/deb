using System.ComponentModel.DataAnnotations.Schema;
using NHibernate.Mapping.ByCode.Conformist;

namespace WebApplication1.Models
{
    public class OrderProduct
    {
        public virtual int Id { get; set; }
        public virtual int Count { get; set; }
        public virtual int Price { get; set; }
        public virtual int TypeId { get; set; }
        public virtual int ProductId { get; set; }
        public virtual int OrderId { get; set; }
        //public virtual Order Order { get; set; }
    }
}