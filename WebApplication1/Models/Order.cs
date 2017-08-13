namespace WebApplication1.Models
{
    using System.Collections.Generic;
    public class Order
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Tell { get; set; }
        public virtual string Address { get; set; }
        public virtual string Comment { get; set; }
        private IList<OrderProduct> _orderProduct;
        public virtual IList<OrderProduct> OrderProduct
        {
            get { return _orderProduct ?? (_orderProduct = new List<OrderProduct>()); }
            set { _orderProduct = value; }
        }
    }
}